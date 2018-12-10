<%@ Register TagPrefix="uc1" TagName="DetailProverbe" Src="Controles/DetailProverbe.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Compteur" Src="Controles/Compteur.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Controles/Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Bandeau" Src="Controles/Bandeau.ascx" %>
<%@ Page language="c#" Codebehind="FAQ.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.Faq" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Ma grand-mère disait...</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="proverbes_styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Accueil" method="post" runat="server">
			<!-- Entête --><uc1:bandeau id="Bandeau1" runat="server" Titre="Ma grand mère disait..." background="images/carreaux_petit.jpg"></uc1:bandeau><uc1:menu id="Menu1" runat="server"></uc1:menu>
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
							Cette page est là pour répondre à toutes les questions que vous pouvez vous 
							poser sur ce site. N'hésitez pas à
							<asp:HyperLink id="urlContact" runat="server">me contacter</asp:HyperLink>
							&nbsp;pour en savoir plus.</P>
						<P align="right" class="DerniereMAJ">Dernière mise à jour:&nbsp; 07/10/2004</P>
						<h3>Pourquoi ?</h3>
						<UL>
							<li>
								<A href="#Q7">Pourquoi ma contribution n'est pas publiée&nbsp;?</A>
							<LI>
								<a href="#Q1">Pourquoi avoir fait un site internet sur les proverbes&nbsp;?</a>
							</LI>
						</UL>
						<br>
						<h3>Comment ?</h3>
						<ul>
							<li>
								<a href="#Q2">Comment est développé le site&nbsp;?</a>
							<li>
								<A href="#Q4">Est-il possible de récupérer le code source du&nbsp;site&nbsp;?</A>
							<li>
								<A href="#Q9">Comment être informé des mises à jour&nbsp;?</A></li>
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
						<h3>Réponses</h3>
						<a name="Q7"><b>Pourquoi ma contribution n'est pas publiée&nbsp;?</b></a>
						<p>
							Vous avez fait une contribution et elle n'est pas sur le site: pourquoi ? Deux 
							possibilités: 1) Je n'ai pas encore eut le temps de la publier. La publication 
							n'est pas automatique, je me charge de la mise en forme et de l'illustration 
							des proverbes et je ne fais pas que ça dans la vie, cela peut donc prendre du 
							temps... 2) Elle n'est pas complètement dans l'esprit du site. C'est assez 
							subjectif mais mes critères de choix sont&nbsp;qu'il faut que le proverbe soit 
							drôle, original et imagé. C'est évidemment discutable mais c'est mon choix !</p>
						<P>Quoi qu'il en soit, laissez-moi votre e-mail lorsque vous faites une 
							contribution, cela me permet de vous faire un retour chaque fois que c'est 
							possible.</P>
						<br>
						<a name="Q8"><b>Quelle est l'origine de mon proverbe&nbsp;?</b></a>
						<p>
							En fait, n'étant pas linguiste ou étymologiste, je n'ai pas vraiment les 
							compétences pour analyser la provenance des proverbes que l'on me soumet. Je 
							préfère de toute manière privilégier le côté ludique au côté historique. 
							J'essaye malgré tout de faire quelques recherches simples à l'occasion. Pour en 
							savoir plus, je vous recommande l'excellent site <a href="http://www.francparler.com" target="_blank">
								FrancParler</a> dont les auteurs font de vraies recherches sur l'origine de 
							nos expressions quotidiennes.</p>
						<br>
						<a name="Q1"><b>Pourquoi avoir fait un site internet sur les proverbes&nbsp;?</b></a>
						<p>
							Il me tenait à coeur de réunir les proverbes que j'avais entendus toute mon 
							enfance et de les conserver quelque part afin qu'ils ne se perdent pas. J'ai 
							pensé à les envoyer à des sites existant mais s'il existe bien des sites 
							traitant des proverbes,&nbsp;ils sont un peu trop "académiques" pour le genre 
							de proverbe dont je disposais.&nbsp;Alors je me suis dit: pourquoi ne 
							pas&nbsp;créer un nouveau site&nbsp;? En plus, l'idée de créer un site avait un 
							côté ludique qui ne me déplaisait pas.</p>
						<br>
						<a name="Q2"><b>Comment est développé ce site ?</b></a>
						<p>Le site est entièrement développé en utilisant&nbsp;la technologie ASP.NET de 
							Microsoft. Autant que cela est possible, le code du site sépare les traitements 
							d'accès aux données (via des Web Services), de restitution (via Web Server 
							Control) et de charte graphique (dans les pages HTML et la feuille CSS). Les 
							proverbes sont stockés dans un fichier XML et les autres données manipulées (le 
							compteur par exemple) dans une base de données SQL Server. Bref, c'est 
							technique quoi !</p>
						<br>
						<p>
							<a name="Q4"><b>Est-il possible de récupérer le code source&nbsp;du site ?</b></a></p>
						<p>Oui, c'est possible: tout le code ASP.NET de ce site est <a href="DownloadRequest.aspx">
								téléchargeable</a>. L'ensemble du code est placé sous licence <a href="http://www.gnu.org/licenses/gpl.html" target="_blank">
								GNU</a> ce qui signifie que vous pouvez librement le copier, l'utiliser 
							et&nbsp;le modifier.&nbsp;C'est entièrement gratuit, votre seule obligation, si 
							vous&nbsp;diffusez un logiciel ou un site&nbsp;utilisant ce code, est de 
							permettre l'accès au code source dans les mêmes conditions.</p>
						<br>
						<p>
							<a name="Q9"><b>Comment être informé des mises à jour du site ?</b></a></p>
						<p>Le site conserve la date du dernier accès des visiteurs. Il propose 
							automatiquement sur la page d'accueil les nouveaux proverbes publiés depuis la 
							dernière visite. Il existe également un <A href="Rss.aspx">Flux RSS</A> utilisable 
							depuis un logiciel approprié.</p>
						<br>
						<a name="Q5"><b>Qui est l'auteur du site ?</b></a>
						<p>Un informaticien passionné de développement (ça se voit tant que ça ?) dont le 
							métier n'est pas de créer des sites&nbsp;internet mais qui s'est laissé tenter 
							par l'expérience. Je fais ça bénévolement: soyez donc indulgents :-)</p>
						<br>
						<a name="Q6"><b>Qui peut contribuer au site ?</b></a>
						<p>
							Tout le monde ! Si vous connaissez des proverbes amusants, n'hésitez pas à me 
							les <a href="Contribuer.aspx">faire parvenir</a> .&nbsp;Si vous ne connaissez 
							pas de proverbe mais que vous avez du talent comme illustrateur, je suis 
							preneur aussi, histoire d'égayer les images actuelles. Enfin, si vous avez des 
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
