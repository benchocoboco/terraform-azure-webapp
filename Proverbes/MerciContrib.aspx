<%@ Page language="c#" Codebehind="MerciContrib.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.MerciContrib" %>
<%@ Register TagPrefix="uc1" TagName="Bandeau" Src="Controles/Bandeau.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Controles/Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Compteur" Src="Controles/Compteur.ascx" %>
<%@ Register TagPrefix="uc1" TagName="DetailProverbe" Src="Controles/DetailProverbe.ascx" %>
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
			<!-- Entête --><uc1:bandeau id="Bandeau1" runat="server" background="images/carreaux_petit.jpg" Titre="Ma grand mère disait..."></uc1:bandeau><uc1:menu id="Menu1" runat="server"></uc1:menu>
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
								<td align="middle"><uc1:compteur id="Compteur1" runat="server" guid="4EA29A24-CFD0-4079-898B-39EA49555857" urlprefix="../images/nmbr"></uc1:compteur><br>
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
							<STRONG>Merci de votre contribution</STRONG>, vous retrouverez peut-être 
							prochainement votre proverbe sur le site.</P>
						<a href="Contribuer.aspx">Nouvelle contribution</a>&nbsp;&nbsp;&nbsp; <a href="Accueil.aspx">
							Retour à l'accueil</a>
						<P>&nbsp;</P>
					</td>
				</tr>
			</table>
			</TD></TR></TABLE></form>
	</body>
</HTML>
