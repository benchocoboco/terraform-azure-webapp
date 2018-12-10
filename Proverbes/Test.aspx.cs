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
using System.Data.SqlClient;


namespace Proverbes.net
{
	/// <summary>
	/// Description résumée de Test.
	/// </summary>
	public class TestDotNet : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label txtFwk;
		protected System.Web.UI.WebControls.Label txtDb;
		protected System.Web.UI.WebControls.Label txtFwkIsOK;
		protected System.Web.UI.WebControls.Button bTestDb;
		protected System.Web.UI.WebControls.Button bTestFwk;
		protected System.Web.UI.WebControls.Button bTestWSP;
		protected System.Web.UI.WebControls.Label txtWSPIsOK;
		protected System.Web.UI.WebControls.Label txtWSProv;
		protected System.Web.UI.WebControls.Label txtError;
		protected System.Web.UI.WebControls.Label txtWSCompteur;
		protected System.Web.UI.WebControls.Label txtWSCIsOK;
		protected System.Web.UI.WebControls.Button bTestWSC;
		protected System.Web.UI.WebControls.Label txtDbIsOK;
	
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
			this.bTestWSP.Click += new System.EventHandler(this.bTestWSP_Click);
			this.bTestDb.Click += new System.EventHandler(this.bTestDb_Click);
			this.bTestWSC.Click += new System.EventHandler(this.bTestWSC_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void bTestDb_Click(object sender, System.EventArgs evt)
		{
			try
			{
				// Connexion à la base
				SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnStr"]);
				myConnection.Open();

				// Lancer une requête de test
				String selectCmd = ConfigurationSettings.AppSettings["TestReq"];
				SqlCommand myCommand = new SqlCommand(selectCmd, myConnection);
				SqlDataReader myReader = myCommand.ExecuteReader();
				myReader.Close();

				// Fermer la connexion
				myConnection.Close();

				// MAJ Affichage
				txtDbIsOK.Text = "OK";
				txtDbIsOK.ForeColor = Color.Navy;
				txtError.Text = "";
			}
			catch(SqlException e)
			{
				// MAJ Affichage
				txtDbIsOK.Text = "KO";
				txtDbIsOK.ForeColor = Color.Red;
				txtError.Text = e.Message + " " + e.StackTrace;
			}		
		}

		private void bTestWSP_Click(object sender, System.EventArgs evt)
		{
			try
			{
				// Charger le Web Service
				WebServiceProverbes.ServiceProverbes ws = new WebServiceProverbes.ServiceProverbes();
				ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceProverbes.asmx";	
				ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

				// Récupérer le proverbe du jour
				WebServiceProverbes.Proverbe dujour = ws.today();

				// MAJ Affichage
				txtWSPIsOK.Text = "OK";
				txtWSPIsOK.ForeColor = Color.Navy;
				txtError.Text = "";
			}
			catch (System.Net.WebException e)
			{
				// MAJ Affichage
				txtWSPIsOK.Text = "KO";
				txtWSPIsOK.ForeColor = Color.Red;
				txtError.Text = e.Message + " " + e.StackTrace;
			}
		}

		private void bTestWSC_Click(object sender, System.EventArgs evt)
		{
			try
			{
				// Créer le Web Service
				WebServiceCompteur.ServiceCompteur ws = new WebServiceCompteur.ServiceCompteur();
				ws.Url = ConfigurationSettings.AppSettings["WebServicePrefix"] + "/ServiceCompteur.asmx";	
				ws.Credentials= System.Net.CredentialCache.DefaultCredentials;

				// Récupérer le cookie 
				string guid = "4EA29A24-CFD0-4079-898B-39EA49555857";
				HttpCookie ckie = Request.Cookies["CNTR-"+guid];

				// C'est un nouveau visiteur on l'enregistre
				bool bNewVisitor = false;
				string guidvisitor = "";
				if ( ckie == null )
				{
					guidvisitor = ws.newVisitor(guid);
					ckie = new HttpCookie("CNTR-"+guid, guidvisitor);
					ckie.Expires = DateTime.MaxValue;
					Response.Cookies.Add(ckie);
					bNewVisitor = true;
				}

				// C'est une nouvelle visite on la stocke
				else
				{
					ws.newVisit(ckie.Value);
				}

				// Charger les informations sur le compteur
				int iCount;
				WebServiceCompteur.Compteur counter = ws.getCounter(guid);

				// Récupérer la valeur du compteur
				iCount = counter.NbreVisiteurs;

				// MAJ Affichage
				if ( !bNewVisitor )
					txtWSCIsOK.Text = "OK, [" + iCount.ToString() + "]";
				else
					txtWSCIsOK.Text = "OK, [+1="+guidvisitor+"] [" + iCount.ToString() + "]";
				txtWSCIsOK.ForeColor = Color.Navy;
				txtError.Text = "";
				
//				// Connexion à la base
//				SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnStr"]);
//				myConnection.Open();
//
//				// Rechercher le compteur
//				string counterid = "4EA29A24-CFD0-4079-898B-39EA49555857";
//				String selectCmd = "SELECT idcompteur FROM pv_compteur WHERE idcompteur='" + counterid +"'";
//				SqlCommand myCommand = new SqlCommand(selectCmd, myConnection);
//				SqlDataReader myReader = myCommand.ExecuteReader();
//
//				// S'il n'existe pas, erreur
//				if ( !myReader.Read() )
//				{
//					// Affichage
//					myReader.Close();
//					myConnection.Close();
//					txtWSCIsOK.Text = "OK, [Pas de compteur]";
//				}
//				else
//				{
//					// Création d'un visiteur en base
//					myReader.Close();
//					Guid guid = Guid.NewGuid();
//					String insertCmd = "INSERT INTO pv_visiteur (idvisiteur, idcompteur, derniere_visite, nbre_visite) VALUES ('" + guid.ToString() + "','" + counterid + "','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 1)";
//					myCommand = new SqlCommand(insertCmd, myConnection);
//					myCommand.ExecuteNonQuery();
//					txtError.Text = insertCmd;
//
//					// Fermer la connexion
//					myConnection.Close();
//
//					// Affichage
//					txtWSCIsOK.Text = "OK, ["+guid.ToString()+"]";
//				}
//	
//				txtWSCIsOK.ForeColor = Color.Navy;
//				txtError.Text = "";
			}
			catch (System.Net.WebException e)
			{
				// MAJ Affichage
				txtWSCIsOK.Text = "KO";
				txtWSCIsOK.ForeColor = Color.Red;
				txtError.Text = e.Message + " " + e.StackTrace;
			}		
		} 
	}
}
