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
using System.Configuration;


namespace Proverbes.net
{
	/// <summary>
	/// Liste les proverbes par cat�gorie. Re�oit le nom du th�me en param�tre.
	/// </summary>
	public class ListProverbe : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.PlaceHolder holder;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// L'h�bergement a chang�, on repart
			string stRedirect = ConfigurationSettings.AppSettings["Redirect"];
			if ( stRedirect != "no" )
			{
				Response.Redirect(stRedirect + Request.Path);
				return;
			}

			// R�cup�rer la s�lection demand�e
			String current = Request.QueryString["theme"];
			String contrib = Request.QueryString["contributor"];
			String date = Request.QueryString["date"];
			String id = Request.QueryString["id"];

			// Charger le Web Service
			WebServiceProverbes.ServiceProverbes ws = new WebServiceProverbes.ServiceProverbes();
			ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceProverbes.asmx";	
			ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

			// Charger les categories
			Themes themes = (Themes)FindControl("Themes1");
			if ( current != null )
				themes.Selection = current;

			// R�cup�rer le proverbe du jour pour le mettre en valeur
			WebServiceProverbes.Proverbe dujour = ws.today();

			// S'il n'y a qu'un seul proverbe � afficher
			if ( id != null )
			{
				// Afficher le d�tail du proverbe
				WebServiceProverbes.Proverbe result = ws.get(id);
				if ( result == null )
					return;
				DetailProverbe detail = (DetailProverbe)LoadControl("Controles/DetailProverbe.ascx");
				detail.LeProverbe = result;
				detail.DuJour = (result.Id == dujour.Id);
				holder.Controls.Add(detail);
			}
			else
			{
				// Afficher le d�tail de chaque proverbe
				WebServiceProverbes.Proverbe[] results = ws.search(current, contrib, date);
				foreach( WebServiceProverbes.Proverbe proverbe in results )
				{
					DetailProverbe detail = (DetailProverbe)LoadControl("Controles/DetailProverbe.ascx");
					detail.LeProverbe = proverbe;
					detail.DuJour = (proverbe.Id == dujour.Id);
					holder.Controls.Add(detail);
				}
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

	}
}
