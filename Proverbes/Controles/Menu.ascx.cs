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

namespace Proverbes.net
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Collections.Specialized;
	using System.Configuration;

	/// <summary>
	/// Affichage du menu d'entête.
	/// </summary>
	/// <remarks>
	/// - Les différents éléments à afficher sont récupérés dans la section "menuSettings" du web.config.
	/// - Le style CSS "MenuFond" donne la couleur de fond.
	/// - Le style CSS "Menu" donne le style des éléments.
	/// </remarks>
	public abstract class Menu : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.PlaceHolder holder;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Charger les éléments de menu
			if (LoadItems())
			{
				// Ajouter les items
				for(int i = 0 ; i < items.Count ; i++)
				{
					// Créer la cellule
					HtmlTableCell cell = new HtmlTableCell("td");
					cell.Attributes.Add("class", "Menu");
					cell.Attributes.Add("width", "90");
					cell.Attributes.Add("align", "center");

					// Créer le lien
					HtmlAnchor href = new HtmlAnchor();
					href.HRef = items.Get(i);
					href.InnerText = items.GetKey(i);
					cell.Controls.Add(href);

					// Ajouter la ligne
					holder.Controls.Add(cell);
				}
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
		
		///		Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		///		le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		#region Propriétés du contrôle
		
		/// <summary>
		/// Ensemble des items du menu.
		/// </summary>
		private NameValueCollection items = null;

		#endregion


		/// <summary>
		/// Chargement des éléments de menu dans le web.config
		/// </summary>
		/// <returns>
		/// Retourne true si OK, false si erreur.
		/// </returns>
		protected bool LoadItems()
		{
			items = (NameValueCollection)ConfigurationSettings.GetConfig("menuSettings");
			return true;
		}
	}
}
