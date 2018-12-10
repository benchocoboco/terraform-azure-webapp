<%@ Register TagPrefix="uc1" TagName="DetailProverbe" Src="Controles/DetailProverbe.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Controles/Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Compteur" Src="Controles/Compteur.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Bandeau" Src="Controles/Bandeau.ascx" %>
<%@ Page language="c#" Codebehind="Accueil.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.Accueil" %>
<%@ Register TagPrefix="uc1" TagName="Themes" Src="Controles/Themes.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Ma grand-mère disait... - Proverbes</title>
		<meta content="Proverbes et expressions de la sagesse populaire. Des expressions originales, imagées et amusantes."
			name="description">
		<meta content="proverbes grand-mère disait expressions sagesse populaire humour amusant"
			name="keywords">
		<meta content="fr" name="language">
		<meta content="30 days" name="revist-after">
		<meta content="global" name="distribution">
		<meta content="ALL" name="robots">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="proverbes_styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Accueil" method="post" runat="server">
			<!-- Entête --><uc1:bandeau id="Bandeau1" runat="server" background="images/carreaux_petit.jpg" Titre="Ma grand mère disait..."></uc1:bandeau><uc1:menu id="Menu1" runat="server"></uc1:menu>
			<!-- Contenu -->
			<table style="BORDER-COLLAPSE: collapse" cellPadding="0" width="100%" border="0">
				<tr>
					<td class="Gauche" width="120" height="495" valign="top">
						<!-- Gauche -->
						<table height="100%" width="100%">
							<tr vAlign="top">
								<td><br>
									<uc1:themes id="Themes1" runat="server"></uc1:themes></td>
							</tr>
							<tr vAlign="bottom">
								<td align="center"><uc1:compteur id="Compteur1" runat="server" guid="4EA29A24-CFD0-4079-898B-39EA49555857" urlprefix="../images/nmbr"></uc1:compteur><br>
									<br>
								</td>
							</tr>
						</table>
					</td>
					<!-- Marge -->
					<td width="20"></td>
					<!-- Droite -->
					<td vAlign="top"><br>
						Nous avons tous dans notre enfance entendu ces proverbes de grand-mère. Ils 
						nous ont amusés, agacés, parfois vexés. Pourtant, les réentendre 
						est&nbsp;toujours&nbsp;un plaisir tellement ils ont le parfum de notre 
						jeunesse, du temps passé, de chez nous. Ces proverbes, pleins de bon sens et 
						d'images populaires, j'ai eu envie de les regrouper pour ne pas les perdre. Ce 
						site web est donc pour eux, pour les proverbes de ma grand-mère et ceux de la 
						vôtre, si vous voulez bien les partager avec moi.
						<p>Voici le <b>proverbe du jour</b>, cliquez sur les thèmes à gauche pour voir la 
							liste complète:</p>
						<P><uc1:detailproverbe id="DetailProverbe1" runat="server"></uc1:detailproverbe></P>
						<P>&nbsp;</P>
						<P align="center"><asp:hyperlink id="urlNouveautes" runat="server" NavigateUrl="ListProverbe.aspx">99 nouveaux proverbes depuis votre dernière visite</asp:hyperlink><br>
						</P>
						<table width="100%">
							<tr>
								<td align="left">
									<P class="DerniereMAJ">Dernière mise à jour:
										<asp:label id="txtLastMAJ" runat="server">99/99/9999</asp:label></P>
								</td>
								<td align="center"><A href="Rss.aspx" target="_blank"><IMG alt="Flux RSS 2.0" src="images/xml.gif" border="0"></A>
								</td>
								<td align="right">
									<P class="DerniereMAJ">Nb de proverbes:
										<asp:label id="txtNbProv" runat="server">99</asp:label></P>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			</TD></TR></TABLE></form>
	</body>
</HTML>
