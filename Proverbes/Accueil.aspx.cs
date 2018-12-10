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
	/// Description r�sum�e de [!output SAFE_CLASS_NAME].
	/// </summary>
	public class Accueil : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList themes;
		protected System.Web.UI.WebControls.Label txtLastMAJ;
		protected System.Web.UI.WebControls.Label txtNbProv;
		protected System.Web.UI.WebControls.HyperLink urlNouveautes;
		protected DetailProverbe pDuJour;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// L'h�bergement a chang�, on repart
			string stRedirect = ConfigurationSettings.AppSettings["Redirect"];
			if ( stRedirect != "no" )
			{
				Response.Redirect(stRedirect + Request.Path);
				return;
			}

			// Charger le Web Service
			WebServiceProverbes.ServiceProverbes ws = new WebServiceProverbes.ServiceProverbes();
			ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceProverbes.asmx";	
			ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

			// Affecter le proverbe du jour
			pDuJour = (DetailProverbe)FindControl("DetailProverbe1");
			pDuJour.LeProverbe = ws.today();
			pDuJour.DuJour = true;

			// Calculer les nouveaut�s depuis la derni�re visite
			urlNouveautes.Visible = false;
			try
			{
				// Cr�er le Web Service
				WebServiceCompteur.ServiceCompteur wc = new WebServiceCompteur.ServiceCompteur();
				wc.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceCompteur.asmx";	
				wc.Credentials= System.Net.CredentialCache.DefaultCredentials;

				// R�cup�rer le cookie
				Guid guid = new Guid("4EA29A24-CFD0-4079-898B-39EA49555857");
				HttpCookie ckie = Request.Cookies["CNTR-"+guid];

				// Si le visiteur est d�j� venu...
				if ( ckie != null )
				{
					// On r�cup�re la date de sa derni�re visite
					WebServiceCompteur.Visiteur visiteur = wc.getVisitor(ckie.Value);
					if ( visiteur != null )
					{
						String stLastVisit = visiteur.DerniereVisite.ToString("yyyy-MM-dd");

						// R�cup�rer les nouveaux proverbes
						WebServiceProverbes.Proverbe[] pNews = ws.search("", "", stLastVisit);

						// Afficher le nombre de nouveaut�s s'il y en a
						int iNbNews = pNews.Length;
						if ( iNbNews > 0 )
						{
							if ( iNbNews == 1 )
								urlNouveautes.Text = Convert.ToString(iNbNews) + " nouveau proverbe depuis votre derni�re visite";
							else
								urlNouveautes.Text = Convert.ToString(iNbNews) + " nouveaux proverbes depuis votre derni�re visite";
							urlNouveautes.NavigateUrl = "ListProverbe.aspx?date=" + HttpUtility.UrlEncode(stLastVisit);
							urlNouveautes.Visible = true;
						}
					}
				}

			}
			catch (System.Net.WebException)
			{
				// On ne fait rien
			}

			// Mettre � jour les compteurs
			WebServiceProverbes.Proverbe[] pAll = ws.search("", "", "");
			txtNbProv.Text = Convert.ToString(pAll.Length);
			DateTime dtLast = DateTime.MinValue;
			foreach( WebServiceProverbes.Proverbe proverbe in pAll )
			{
				if ( proverbe.Date > dtLast )
					dtLast = proverbe.Date;
			}
			txtLastMAJ.Text = dtLast.ToString("dd/MM/yyyy");
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
