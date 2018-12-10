//================================================================================
//  Copyright (c) 2003 Lionel Lask�
//
// This file is part of Proverbes.net.
//
// Proverbes.net is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// Proverbes.net is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Proverbes.net; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
//================================================================================

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Mail;
using System.Configuration;
using System.Reflection;

namespace Proverbes.net
{
	/// <summary>
	/// Page permettant de faire une demande de download.
	/// </summary>
	public class DownloadRequest : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.RequiredFieldValidator emailRequired;
		protected System.Web.UI.WebControls.RegularExpressionValidator emailIsValid;
		protected System.Web.UI.WebControls.ValidationSummary summaryError;
		protected System.Web.UI.WebControls.Button bValider;
		protected System.Web.UI.WebControls.TextBox email;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// L'h�bergement a chang�, on repart
			string stRedirect = ConfigurationSettings.AppSettings["Redirect"];
			if ( stRedirect != "no" )
			{
				Response.Redirect(stRedirect + Request.Path);
				return;
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN�: Cet appel est requis par le Concepteur Web Form ASP.NET.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// M�thode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette m�thode avec l'�diteur de code.
		/// </summary>
		private void InitializeComponent()
		{    
			this.bValider.Click += new System.EventHandler(this.bValider_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void bValider_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Cr�er le web service
				WebServiceDownload.ServiceDownload ws = new WebServiceDownload.ServiceDownload();
				ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceDownload.asmx";
				ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

				// Cr�er la demande
				String stId = ws.newRequest(email.Text);
				if ( stId != null )
				{
					// Charger l'assembly d'envoi de mail
					Assembly asmb = null;
					try
					{
						asmb = Assembly.Load(ConfigurationSettings.AppSettings["SmtpDownloadAssembly"]);
						if ( asmb == null )
							return;
					}
					catch (System.IO.FileNotFoundException)
					{
						return;
					}

					// Cr�er la classe
					Mail.ISmtpMail mail = (Mail.ISmtpMail) asmb.CreateInstance(ConfigurationSettings.AppSettings["SmtpDownloadClass"]);
					if ( mail == null )
						return;

					// Cr�er le message
					String stTo = email.Text;
					String stFrom = ConfigurationSettings.AppSettings["SmtpDownload"];
					String stSubject = "T�l�chargement du code source Proverbes.net";
					String stBody = "\nSuite � votre demande de t�l�chargement sur le site Proverbes.net, "
						+ "je vous invite � t�l�charger le code � l'adresse:\n\n"
						+ ConfigurationSettings.AppSettings["URLDownload"] + stId + "\n\n"
						+ "Merci de votre int�r�t pour ce site. N'h�sitez pas � me contacter en cas de probl�me.\n"
						+ "Attention: le fichier t�l�charg� doit �tre enregistr� localement puis renomm� en .ZIP.";

			
					// Envoyer
					mail.Server = ConfigurationSettings.AppSettings["SmtpDownloadServer"];
					mail.AuthLogon = ConfigurationSettings.AppSettings["SmtpDownloadLogon"];
					mail.AuthPassword = ConfigurationSettings.AppSettings["SmtpDownloadPassword"];
					if ( mail.Send(stFrom, stTo, stSubject, stBody) )
						Server.Transfer("MerciDownload.aspx");
				}
				
			}
			catch (System.Net.WebException)
			{
				// En cas d'erreur, tant pis
			}


		}
	}
}
