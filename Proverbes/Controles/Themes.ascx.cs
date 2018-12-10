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

namespace Proverbes.net
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Configuration;

	/// <summary>
	/// Classe d'affichage des Themes.
	/// </summary>
	/// <remarks>
	/// Le contr�le prend en param�tre le th�me s�lectionn�.
	/// Mettre vide pour aucune s�lection ou "First" pour le premier th�me.
	/// </remarks>
	public class Themes : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.PlaceHolder holder;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Charger le Web Service
			WebServiceProverbes.ServiceProverbes ws = new WebServiceProverbes.ServiceProverbes();
			ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceProverbes.asmx";
			ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

			// Charger les categories
			foreach( String theme in ws.categories() )
			{
				// Cr�er le d�calage
				HtmlGenericControl tab = new HtmlGenericControl();
				tab.InnerHtml = "&nbsp;&nbsp;&nbsp;&nbsp;";
				holder.Controls.Add(tab);

				// Cr�er la ligne
				if ( theme != selection )
				{
					// Sous forme de lien
					HtmlAnchor lien = new HtmlAnchor();
					lien.HRef = "../ListProverbe.aspx?theme="+theme;
					lien.InnerHtml = "<b>"+theme+"</b>";
					holder.Controls.Add(lien);				
				}
				else
				{
					// Sous forme statique
					HtmlGenericControl text = new HtmlGenericControl("b");
					text.Attributes["class"] = "ThemeLinkCurrent";
					text.InnerText = theme;
					holder.Controls.Add(text);
				}


				// Cr�er le saut de ligne
				HtmlGenericControl br = new HtmlGenericControl();
				br.InnerHtml = "<br>";
				holder.Controls.Add(br);
			}
		}

		#region Code g�n�r� par le Concepteur Web Form
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN�: Cet appel est requis par le Concepteur Web Form ASP.NET.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		M�thode requise pour la prise en charge du concepteur - ne modifiez pas
		///		le contenu de cette m�thode avec l'�diteur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		#region Propri�t�s du contr�le
		
		/// <summary>
		/// Th�me s�lectionn�.
		/// </summary>
		private String selection = null;

		public String Selection
		{
			get
			{
				return selection;
			}

			set
			{
				selection = value;
			}
		}

		#endregion
	}
}
