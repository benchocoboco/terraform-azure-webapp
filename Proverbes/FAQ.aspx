<%@ Register TagPrefix="uc1" TagName="DetailProverbe" Src="Controles/DetailProverbe.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Compteur" Src="Controles/Compteur.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Controles/Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Bandeau" Src="Controles/Bandeau.ascx" %>
<%@ Page language="c#" Codebehind="FAQ.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.Faq" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Ma grand-m�re disait...</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="proverbes_styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Accueil" method="post" runat="server">
			<!-- Ent�te --><uc1:bandeau id="Bandeau1" runat="server" Titre="Ma grand m�re disait..." background="images/carreaux_petit.jpg"></uc1:bandeau><uc1:menu id="Menu1" runat="server"></uc1:menu>
			<!-- Contenu -->
			<table style="BORDER-COLLAPSE: collapse" cellPadding="0" width="100%" border="0">
				<tr>
					<td class="Gauche" width="120" height="495" valign="top">
						<!-- Gauche -->
						<table height="100%" width="100%">
							<tr vAlign="top">
								<td><br>
								</td>
							</tr>
							<tr vAlign="bottom">
								<td align="center"><uc1:compteur id="Compteur1" runat="server" urlprefix="../images/nmbr" guid="4EA29A24-CFD0-4079-898B-39EA49555857"></uc1:compteur><br>
									<br>
								</td>
							</tr>
						</table>
					</td>
					<!-- Marge -->
					<td width="20"></td>
					<!-- Droite -->
					<td vAlign="top">
						<P><br>
							Cette page est l� pour r�pondre � toutes les questions que vous pouvez vous 
							poser sur ce site. N'h�sitez pas �
							<asp:HyperLink id="urlContact" runat="server">me contacter</asp:HyperLink>
							&nbsp;pour en savoir plus.</P>
						<P align="right" class="DerniereMAJ">Derni�re mise � jour:&nbsp; 07/10/2004</P>
						<h3>Pourquoi ?</h3>
						<UL>
							<li>
								<A href="#Q7">Pourquoi ma contribution n'est pas publi�e&nbsp;?</A>
							<LI>
								<a href="#Q1">Pourquoi avoir fait un site internet sur les proverbes&nbsp;?</a>
							</LI>
						</UL>
						<br>
						<h3>Comment ?</h3>
						<ul>
							<li>
								<a href="#Q2">Comment est d�velopp� le site&nbsp;?</a>
							<li>
								<A href="#Q4">Est-il possible de r�cup�rer le code source du&nbsp;site&nbsp;?</A>
							<li>
								<A href="#Q9">Comment �tre inform� des mises � jour&nbsp;?</A></li>
						</ul>
						<br>
						<h3>Qui ?</h3>
						<ul>
							<li>
								<A href="#Q8">Quelle est l'origine de mon proverbe&nbsp;?</A>
							<LI>
								<a href="#Q5">Qui est l'auteur du site&nbsp;?</a>
							<LI>
								<A href="#Q6">Qui&nbsp;peut contribuer au site&nbsp;?</A>&nbsp;</LI>
						</ul>
						<hr>
						<h3>R�ponses</h3>
						<a name="Q7"><b>Pourquoi ma contribution n'est pas publi�e&nbsp;?</b></a>
						<p>
							Vous avez fait une contribution et elle n'est pas sur le site: pourquoi ? Deux 
							possibilit�s: 1) Je n'ai pas encore eut le temps de la publier. La publication 
							n'est pas automatique, je me charge de la mise en forme et de l'illustration 
							des proverbes et je ne fais pas que �a dans la vie, cela peut donc prendre du 
							temps... 2) Elle n'est pas compl�tement dans l'esprit du site. C'est assez 
							subjectif mais mes crit�res de choix sont&nbsp;qu'il faut que le proverbe soit 
							dr�le, original et imag�. C'est �videmment discutable mais c'est mon choix !</p>
						<P>Quoi qu'il en soit, laissez-moi votre e-mail lorsque vous faites une 
							contribution, cela me permet de vous faire un retour chaque fois que c'est 
							possible.</P>
						<br>
						<a name="Q8"><b>Quelle est l'origine de mon proverbe&nbsp;?</b></a>
						<p>
							En fait, n'�tant pas linguiste ou �tymologiste, je n'ai pas vraiment les 
							comp�tences pour analyser la provenance des proverbes que l'on me soumet. Je 
							pr�f�re de toute mani�re privil�gier le c�t� ludique au c�t� historique. 
							J'essaye malgr� tout de faire quelques recherches simples � l'occasion. Pour en 
							savoir plus, je vous recommande l'excellent site <a href="http://www.francparler.com" target="_blank">
								FrancParler</a> dont les auteurs font de vraies recherches sur l'origine de 
							nos expressions quotidiennes.</p>
						<br>
						<a name="Q1"><b>Pourquoi avoir fait un site internet sur les proverbes&nbsp;?</b></a>
						<p>
							Il me tenait � coeur de r�unir les proverbes que j'avais entendus toute mon 
							enfance et de les conserver quelque part afin qu'ils ne se perdent pas. J'ai 
							pens� � les envoyer � des sites existant mais s'il existe bien des sites 
							traitant des proverbes,&nbsp;ils sont un peu trop "acad�miques" pour le genre 
							de proverbe dont je disposais.&nbsp;Alors je me suis dit: pourquoi ne 
							pas&nbsp;cr�er un nouveau site&nbsp;? En plus, l'id�e de cr�er un site avait un 
							c�t� ludique qui ne me d�plaisait pas.</p>
						<br>
						<a name="Q2"><b>Comment est d�velopp� ce site ?</b></a>
						<p>Le site est enti�rement d�velopp� en utilisant&nbsp;la technologie ASP.NET de 
							Microsoft. Autant que cela est possible, le code du site s�pare les traitements 
							d'acc�s aux donn�es (via des Web Services), de restitution (via Web Server 
							Control) et de charte graphique (dans les pages HTML et la feuille CSS). Les 
							proverbes sont stock�s dans un fichier XML et les autres donn�es manipul�es (le 
							compteur par exemple) dans une base de donn�es SQL Server. Bref, c'est 
							technique quoi !</p>
						<br>
						<p>
							<a name="Q4"><b>Est-il possible de r�cup�rer le code source&nbsp;du site ?</b></a></p>
						<p>Oui, c'est possible: tout le code ASP.NET de ce site est <a href="DownloadRequest.aspx">
								t�l�chargeable</a>. L'ensemble du code est plac� sous licence <a href="http://www.gnu.org/licenses/gpl.html" target="_blank">
								GNU</a> ce qui signifie que vous pouvez librement le copier, l'utiliser 
							et&nbsp;le modifier.&nbsp;C'est enti�rement gratuit, votre seule obligation, si 
							vous&nbsp;diffusez un logiciel ou un site&nbsp;utilisant ce code, est de 
							permettre l'acc�s au code source dans les m�mes conditions.</p>
						<br>
						<p>
							<a name="Q9"><b>Comment �tre inform� des mises � jour du site ?</b></a></p>
						<p>Le site conserve la date du dernier acc�s des visiteurs. Il propose 
							automatiquement sur la page d'accueil les nouveaux proverbes publi�s depuis la 
							derni�re visite. Il existe �galement un <A href="Rss.aspx">Flux RSS</A> utilisable 
							depuis un logiciel appropri�.</p>
						<br>
						<a name="Q5"><b>Qui est l'auteur du site ?</b></a>
						<p>Un informaticien passionn� de d�veloppement (�a se voit tant que �a ?) dont le 
							m�tier n'est pas de cr�er des sites&nbsp;internet mais qui s'est laiss� tenter 
							par l'exp�rience. Je fais �a b�n�volement: soyez donc indulgents :-)</p>
						<br>
						<a name="Q6"><b>Qui peut contribuer au site ?</b></a>
						<p>
							Tout le monde ! Si vous connaissez des proverbes amusants, n'h�sitez pas � me 
							les <a href="Contribuer.aspx">faire parvenir</a> .&nbsp;Si vous ne connaissez 
							pas de proverbe mais que vous avez du talent comme illustrateur, je suis 
							preneur aussi, histoire d'�gayer les images actuelles. Enfin, si vous avez des 
							remarques sur l'ergonomie, l'orthographe (!), le fond ou la forme du site, je 
							suis ouvert.</p>
						<br>
						<br>
					</td>
				</tr>
			</table>
			</TD></TR></TABLE></form>
	</body>
</HTML>
