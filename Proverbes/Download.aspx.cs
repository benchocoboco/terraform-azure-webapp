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
using System.Configuration;

namespace Proverbes.net
{
	/// <summary>
	/// Page de téléchargement, elle renvoie vers le code source ou vers la page de requête.
	/// </summary>
	public class Download : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// L'hébergement a changé, on repart
			string stRedirect = ConfigurationSettings.AppSettings["Redirect"];
			if ( stRedirect != "no" )
			{
				Response.Redirect(stRedirect + Request.Path);
				return;
			}

			try
			{
				// Créer le web service
				WebServiceDownload.ServiceDownload ws = new WebServiceDownload.ServiceDownload();
				ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceDownload.asmx";
				ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

				// Récupérer le numéro de demande
				String stId = Request.QueryString["request"];
				if ( stId != null )
				{
					// S'il est valide, on renvoi vers le code
					if ( ws.newDownload(stId) )
					{
						Response.Redirect(ConfigurationSettings.AppSettings["FileToDownload"]);
						return;
					}
				}

				// Sinon il faut refaire une demande
				Server.Transfer("DownloadRequest.aspx");
		
			}
			catch (System.Net.WebException)
			{
				// En cas d'erreur on reboucle vers la demande
				Server.Transfer("DownloadRequest.aspx");
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
