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

	/// <summary>
	/// Classe d'affichage du bandeau.
	/// </summary>
	/// <remarks>
	/// - La propri�t� "Titre" repr�sente le titre � afficher
	/// - La propri�t� "background" correspond � l'image de fond
	/// - Le titre est affich� avec le style CSS "BandeauTitre"
	/// </remarks>
	public abstract class Bandeau : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Label lblTitre;

		private void Page_Load(object sender, System.EventArgs e)
		{
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
		/// Titre de la fen�tre
		/// </summary>
		public String Titre
		{
			get
			{
				return lblTitre.Text;
			}

			set
			{
				lblTitre.Text = value;
			}
		}
		
		/// <summary>
		/// Image de fond du bandeau
		/// </summary>
		private String stFond;

		public String background
		{
			get
			{
				return stFond;
			}

			set
			{
				stFond = value;
			}
		}

		#endregion
	}
}
