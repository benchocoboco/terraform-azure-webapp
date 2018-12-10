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
	/// Contrôle d'affichage d'un compteur.
	/// </summary>
	/// <remarks>
	/// - La propriété "guid" indique l'identifiant du compteur à incrémenter.
	/// - La propriété "displayVisit" indique s'il faut afficher le nombre de visites ou de visiteurs.
	/// </remarks>
	public abstract class Compteur : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Image imgCompteur1;
		protected System.Web.UI.WebControls.Image imgCompteur2;
		protected System.Web.UI.WebControls.Image imgCompteur3;
		protected System.Web.UI.WebControls.Image imgCompteur4;
		protected System.Web.UI.WebControls.Image imgCompteur5;
		protected System.Web.UI.WebControls.Image imgCompteur6;

		/// <summary>
		/// Chargement de la page, on créé les visiteurs et on incrémente les visites
		/// </summary>
		private void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
				// Créer le Web Service
				WebServiceCompteur.ServiceCompteur ws = new WebServiceCompteur.ServiceCompteur();
				ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceCompteur.asmx";	
				ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

				// Récupérer le cookie 
				HttpCookie ckie = Request.Cookies["CNTR-"+guid];

				// C'est un nouveau visiteur on l'enregistre
				if ( ckie == null )
				{
					ckie = new HttpCookie("CNTR-"+guid, ws.newVisitor(guid));
					ckie.Expires = DateTime.MaxValue;
					Response.Cookies.Add(ckie);
				}

				// C'est une nouvelle visite on la stocke
				else
					ws.newVisit(ckie.Value);

				// Charger les informations sur le compteur
				int iCount;
				WebServiceCompteur.Compteur counter = ws.getCounter(guid);

				// Récupérer la valeur du compteur
				if ( bVisites )
					iCount = counter.NbreVisites;
				else
					iCount = counter.NbreVisiteurs;

				// Afficher la valeur
				displayNumber(iCount);
			}
			catch (System.Net.WebException)
			{
				// Valeur bidon en cas d'erreur
				displayNumber(999999);
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
		/// Identifiant du compteur associé
		/// </summary>
		private String stGuid = null;

		public String guid
		{
			get
			{
				return stGuid;
			}

			set
			{
				stGuid = value;
			}
		}

		/// <summary>
		/// Indique si c'est le nombre de visites qui est affiché (sinon, c'est le nombre de visiteurs).
		/// </summary>
		private bool bVisites = false;

		public bool displayVisit
		{
			get
			{
				return bVisites;
			}

			set
			{
				bVisites = value;
			}
		}
		
		/// <summary>
		/// Préfixe de l'URL et du nom des images des nombres à afficher.
		/// </summary>
		private String stPrefixeURL = null;

		public String urlprefix
		{
			get
			{
				return stPrefixeURL;
			}

			set
			{
				stPrefixeURL = value;
			}
		}


		#endregion


		/// <summary>
		/// Formatter le chiffre digit par digit.
		/// </summary>
		/// <param name="iCount">Valeur à formatter</param>
		protected void displayNumber(int iCount)
		{
			// Formater le nombre sur 6 positions
			String stFormattedCount = Convert.ToString(iCount);
			String stZeroString = "000000";
			stFormattedCount = stZeroString.Substring(0, stZeroString.Length-stFormattedCount.Length) + stFormattedCount;

			// Afficher les chiffres au compteur
			int i = 0;
			imgCompteur1.ImageUrl = stPrefixeURL + stFormattedCount[i++] + ".gif";
			imgCompteur2.ImageUrl = stPrefixeURL + stFormattedCount[i++] + ".gif";
			imgCompteur3.ImageUrl = stPrefixeURL + stFormattedCount[i++] + ".gif";
			imgCompteur4.ImageUrl = stPrefixeURL + stFormattedCount[i++] + ".gif";
			imgCompteur5.ImageUrl = stPrefixeURL + stFormattedCount[i++] + ".gif";
			imgCompteur6.ImageUrl = stPrefixeURL + stFormattedCount[i++] + ".gif";
		}

 	
	}
}
