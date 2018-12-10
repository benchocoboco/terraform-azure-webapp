<%@ Page language="c#" Codebehind="DownloadRequest.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.DownloadRequest" %>
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
								<td align="middle"><uc1:compteur id="Compteur1" runat="server" urlprefix="../images/nmbr" guid="4EA29A24-CFD0-4079-898B-39EA49555857"></uc1:compteur><br>
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
							Pour recevoir automatiquement l'URL vous permettant de <STRONG>télécharger le code 
								source</STRONG> de ce site, merci de renseigner votre adresse e-mail.</P>
						<table border="0">
							<tr>
								<td align="right" colSpan="2"><asp:requiredfieldvalidator id="emailRequired" runat="server" Display="None" ErrorMessage="Merci de renseigner l'adresse e-mail." ControlToValidate="email"></asp:requiredfieldvalidator><asp:regularexpressionvalidator id="emailIsValid" runat="server" Display="None" ErrorMessage="Adresse e-mail invalide." ControlToValidate="email" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator><FONT class="Obligatoire">(*) 
										Saisie obligatoire</FONT></td>
							</tr>
							<tr>
								<td vAlign="center">Votre e-mail</td>
								<td><asp:textbox id="email" runat="server" Width="219px"></asp:textbox></td>
							</tr>
						</table>
						<P><asp:validationsummary id="summaryError" runat="server" HeaderText="Erreur:"></asp:validationsummary></P>
						<P><asp:button id="bValider" runat="server" Text="Valider"></asp:button>
						</P>
					</td>
				</tr>
			</table>
			</TD></TR></TABLE></form>
	</body>
</HTML>
