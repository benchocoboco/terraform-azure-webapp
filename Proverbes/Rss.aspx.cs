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
using System.Xml;
using System.Configuration;
using System.IO;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


namespace Proverbes.net
{
	/// <summary>
	/// Génération d'un flux RSS 2.0.
	/// </summary>
	public class Rss : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Initialisation
			DateTime dtLast = DateTime.MinValue;
			WebServiceProverbes.Proverbe[] pAll = null;

			// Positionner le content-type
			Response.ContentType = "text/xml";
			Response.ContentEncoding = Encoding.UTF8;

			// S'il n'y a rien dans le cache
			if (Cache["Rss"] == null)
			{
				// Lire les proverbes
				try
				{
					// Créer le Web Service
					WebServiceProverbes.ServiceProverbes ws = new WebServiceProverbes.ServiceProverbes();
					ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceProverbes.asmx";	
					ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

					// Récupérer tous les proverbes
					pAll = ws.search("", "", "");

					// Calculer la date de dernière publication
					foreach( WebServiceProverbes.Proverbe proverbe in pAll )
					{
						if ( proverbe.Date > dtLast )
							dtLast = proverbe.Date;
					}
				}
				catch (System.Net.WebException)
				{
					// On ne fait rien
					return;
				}

				// Créer un XmlTextWriter
				StringWriter sw = new StringWriter();
				XmlTextWriter writer = new XmlTextWriter(sw);

				// Ecrire la version <rss version="2.0">
				writer.WriteStartElement("rss");
				writer.WriteAttributeString("version", "2.0");

				// Ecrire <channel>
				writer.WriteStartElement("channel");
				writer.WriteElementString("title", "Ma grand-mère disait...");
				writer.WriteElementString("link", "http://www.proverbes-grandmere.net/");
				writer.WriteElementString("description", "Derniers proverbes publiés sur le site http://www.proverbes-grandmere.net.");
				writer.WriteElementString("language", "fr-fr");
				writer.WriteElementString("webMaster", "webmaster@proverbes-grandmere.net");
				writer.WriteElementString("ttl", "60");

				// Pour chaque proverbe
				foreach( WebServiceProverbes.Proverbe proverbe in pAll )
				{
					// S'il n'a pas été publié récemment, on l'ignore
					if ( proverbe.Date != dtLast )
						continue;

					// Créer un <item> pour le proverbe
					writer.WriteStartElement("item");
					writer.WriteElementString("title", proverbe.Titre);
					writer.WriteElementString("link", String.Format(ConfigurationSettings.AppSettings["URLDetail"], proverbe.Id));
					writer.WriteElementString("description", proverbe.Description);
					writer.WriteElementString("category", proverbe.Theme);
					writer.WriteElementString("pubDate", proverbe.Date.ToString("r"));
					writer.WriteEndElement();
				}

				// Fermer </channel>
				writer.WriteEndElement();

				// Fermer </rss>
				writer.WriteEndElement();

				// Sauvegarder dans le cache
				Cache.Insert("Rss", sw.ToString(), null, DateTime.Now.AddHours(int.Parse(ConfigurationSettings.AppSettings["CacheTimeout"])), TimeSpan.Zero);

				writer.Close();
			}				

			// Réecrire le cache
			Response.Write(Cache["Rss"].ToString());
		}

		#region Code généré par le Concepteur Web Form
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
