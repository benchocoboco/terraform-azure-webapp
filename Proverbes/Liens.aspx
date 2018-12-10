<%@ Register TagPrefix="uc1" TagName="DetailProverbe" Src="Controles/DetailProverbe.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Compteur" Src="Controles/Compteur.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Controles/Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Bandeau" Src="Controles/Bandeau.ascx" %>
<%@ Page language="c#" Codebehind="Liens.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.Liens" %>
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
							Voici quelques liens utiles ou amusants. N'hésitez pas à
							<asp:HyperLink id="urlContact" runat="server">me contacter</asp:HyperLink>&nbsp;pour 
							me suggérer d'autres adresses.</P>
						<hr>
						<p><a href="http://www.francparler.com" target="_blank"><IMG border="0" src="images/francparler.gif" alt="FrancParler"></a></p>
						<P>
							<font class="DerniereMAJ">FrancParler</font>
						est un site référençant plusieurs centaines d'expressions du monde entier. Au 
						delà de la signification et de&nbsp;l'aspect ludique d'une expression, les 
						rédacteurs effectuent des recherches afin de déterminer leur origine. Je ne 
						publie pas un seul proverbe sans faire un tour sur cet excellent site.
						<P></P>
						<br>
						<br>
						<p><a href="http://www.poivronsjaunes.com" target="_blank"><IMG border="0" src="images/poivrons jaunes.gif" alt="Poivrons Jaunes"></a></p>
						<P>
							<font class="DerniereMAJ">Poivrons Jaunes</font> est un portail référençant des 
							sites originaux ou incontournables dans le domaine de la culture. Un vrai point 
							d'entrée vers le monde des arts, juste&nbsp;pour le plaisir.
						</P>
						<br>
						<br>
						<p>
							<OBJECT codeBase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,29,0"
								height="60" width="234" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" VIEWASTEXT>
								<PARAM NAME="_cx" VALUE="4953">
								<PARAM NAME="_cy" VALUE="1270">
								<PARAM NAME="FlashVars" VALUE="">
								<PARAM NAME="Movie" VALUE="http://www.prizee.com/images/pub/new/prizee-234x60-v1.swf?url=http://www.prizee.com/?refer=Jenproov">
								<PARAM NAME="Src" VALUE="http://www.prizee.com/images/pub/new/prizee-234x60-v1.swf?url=http://www.prizee.com/?refer=Jenproov">
								<PARAM NAME="WMode" VALUE="Window">
								<PARAM NAME="Play" VALUE="-1">
								<PARAM NAME="Loop" VALUE="-1">
								<PARAM NAME="Quality" VALUE="High">
								<PARAM NAME="SAlign" VALUE="">
								<PARAM NAME="Menu" VALUE="-1">
								<PARAM NAME="Base" VALUE="">
								<PARAM NAME="AllowScriptAccess" VALUE="always">
								<PARAM NAME="Scale" VALUE="ShowAll">
								<PARAM NAME="DeviceFont" VALUE="0">
								<PARAM NAME="EmbedMovie" VALUE="0">
								<PARAM NAME="BGColor" VALUE="">
								<PARAM NAME="SWRemote" VALUE="">
								<PARAM NAME="MovieData" VALUE="">
								<PARAM NAME="SeamlessTabbing" VALUE="1">
								<embed src="http://www.prizee.com/images/pub/new/prizee-234x60-v1.swf?url=http://www.prizee.com/?refer=Jenproov"
									quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash"
									width="234" height="60"> </embed>
							</OBJECT>
						</p>
						<P>
							Pour se détendre sur le net&nbsp;rien de tel que <font class="DerniereMAJ">Prizee</font>
							! Le site propose toute une liste de jeux de hasard, de réflexion ou d'adresse. 
							C'est gratuit, c'est bien fait, il y a un minimum de pub&nbsp;et en plus, avec 
							un peu de persévérance, on peut gagner des cadeaux !
						</P>
						<br>
						<hr>
						<P align="right" class="DerniereMAJ">Dernière mise à jour:&nbsp; 01/10/2004</P>
					</td>
				</tr>
			</table>
			</TD></TR></TABLE></form>
	</body>
</HTML>
