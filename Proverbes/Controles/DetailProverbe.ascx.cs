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
	using System.Configuration;

	/// <summary>
	/// Classe permettant l'affichage d'un proverbe.
	/// </summary>
	/// <remarks>Les différents éléments affichés suivent les styles CSS:
	/// - ProvFondJour: la couleur de fond pour le proverbe du jour,
	/// - ProvFondNormal: la couleur de fond pour un proverbe quelconque,
	/// - ProvTitre: pour le style du titre du proverbe,
	/// - ProvDescription: pour le style de la description,
	/// - ProvContrib: pour le style du contributeur et de la date.
	/// </remarks>
	public class DetailProverbe : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Label lblTitre;
		protected System.Web.UI.WebControls.Image imgImage;
		protected System.Web.UI.WebControls.Label lblDescription;
		protected System.Web.UI.WebControls.HyperLink lblContrib;
		protected System.Web.UI.WebControls.Label lblDate;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Placer ici le code utilisateur pour initialiser la page
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
		/// Proverbe associé
		/// </summary>
		private WebServiceProverbes.Proverbe proverbe = null;

		public WebServiceProverbes.Proverbe LeProverbe
		{
			get
			{
				return proverbe;
			}

			set
			{
				proverbe = value;
				if ( proverbe != null )
				{
					lblTitre.Text = proverbe.Titre;
					imgImage.ImageUrl = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/" + proverbe.Image;
					lblDescription.Text = proverbe.Description;
					lblContrib.Text = proverbe.Contribution;
					lblContrib.NavigateUrl = "../ListProverbe.aspx?contributor=" + HttpUtility.UrlEncode(proverbe.Contribution);
					lblDate.Text = proverbe.Date.ToString("dd/MM/yyyy");
				}
			}
		}

		/// <summary>
		/// Indique si c'est le proverbe du jour ou pas.
		/// </summary>
		private bool estDuJour = false;

		public bool DuJour
		{
			get
			{
				return estDuJour;
			}

			set
			{
				estDuJour = value;
			}
		}

		#endregion
  

	}
}
