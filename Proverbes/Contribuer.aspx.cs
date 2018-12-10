//================================================================================
//  Copyright (c) 2003 Lionel Laské
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
	/// Page de Contribution.
	/// </summary>
	public class Contribuer : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox pseudo;
		protected System.Web.UI.WebControls.TextBox email;
		protected System.Web.UI.WebControls.TextBox proverbe;
		protected System.Web.UI.WebControls.Button bValider;
		protected System.Web.UI.WebControls.RequiredFieldValidator proverbeRequired;
		protected System.Web.UI.WebControls.RequiredFieldValidator descriptionRequired;
		protected System.Web.UI.WebControls.ValidationSummary summaryError;
		protected System.Web.UI.WebControls.RegularExpressionValidator emailIsValid;
		protected System.Web.UI.WebControls.TextBox description;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// L'hébergement a changé, on repart
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
			// CODEGEN : Cet appel est requis par le Concepteur Web Form ASP.NET.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{    
			this.bValider.Click += new System.EventHandler(this.bValider_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion


		/// <summary>
		/// Appuie sur le bouton valider.
		/// </summary>
		private void bValider_Click(object sender, System.EventArgs e)
		{
			// Charger l'assembly d'envoi de mail
			Assembly asmb = null;
			try
			{
				asmb = Assembly.Load(ConfigurationSettings.AppSettings["SmtpContribAssembly"]);
				if ( asmb == null )
					return;
			}
			catch (System.IO.FileNotFoundException)
			{
				return;
			}

			// Créer la classe
			Mail.ISmtpMail mail = (Mail.ISmtpMail) asmb.CreateInstance(ConfigurationSettings.AppSettings["SmtpContribClass"]);
			if ( mail == null )
				return;

			// Créer le message
			String stTo = ConfigurationSettings.AppSettings["SmtpContrib"];
			String stFrom = ConfigurationSettings.AppSettings["SmtpContrib"];
			String stSubject = "Nouvelle contribution";
			if ( email.Text != null && email.Text.Length != 0 )
				stSubject += " de " + email.Text;
			String stBody = "Pseudo: " + pseudo.Text + "\n"
						 + "Proverbe: " + proverbe.Text + "\n"
						 + "Description:\n\n" + description.Text + "\n";
			
			// Envoyer
			mail.Server = ConfigurationSettings.AppSettings["SmtpContribServer"];
			mail.AuthLogon = ConfigurationSettings.AppSettings["SmtpContribLogon"];
			mail.AuthPassword = ConfigurationSettings.AppSettings["SmtpContribPassword"];
			if ( mail.Send(stFrom, stTo, stSubject, stBody) )
				Server.Transfer("MerciContrib.aspx");		
		}
	}
}
