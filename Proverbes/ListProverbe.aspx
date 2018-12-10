<%@ Register TagPrefix="uc1" TagName="DetailProverbe" Src="Controles/DetailProverbe.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Compteur" Src="Controles/Compteur.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="Controles/Menu.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Bandeau" Src="Controles/Bandeau.ascx" %>
<%@ Page language="c#" Codebehind="ListProverbe.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.ListProverbe" %>
<%@ Register TagPrefix="uc1" TagName="Themes" Src="Controles/Themes.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Ma grand-mère disait...</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" href="proverbes_styles.css" type="text/css">
	</HEAD>
	<body>
		<form id="Accueil" method="post" runat="server">
			<!-- Entête -->
			<uc1:Bandeau id="Bandeau1" runat="server" Titre="Ma grand mère disait..." background="images/carreaux_petit.jpg"></uc1:Bandeau>
			<uc1:Menu id="Menu1" runat="server"></uc1:Menu>
			<!-- Contenu -->
			<table border="0" cellpadding="0" style="BORDER-COLLAPSE: collapse" width="100%">
				<tr>
					<td class="Gauche" width="120" height="495" valign="top">
						<!-- Gauche -->
						<table height="100%" width="100%">
							<tr valign="top">
								<td>
									<br>
									<uc1:Themes id="Themes1" runat="server"></uc1:Themes>
								</td>
							</tr>
							<tr valign="bottom">
								<td align="center">
									<uc1:Compteur id="Compteur1" runat="server" urlprefix="../images/nmbr" guid="4EA29A24-CFD0-4079-898B-39EA49555857"></uc1:Compteur>
									<br>
									<br>
								</td>
							</tr>
						</table>
					</td>
					<!-- Marge -->
					<td width="20">
					</td>
					<!-- Droite -->
					<td valign="top">
						<br>
						<asp:PlaceHolder ID="holder" Runat="server" />
					</td>
				</tr>
			</table>
			</TD></TR></TABLE>
		</form>
	</body>
</HTML>
