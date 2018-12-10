<%@ Page language="c#" Codebehind="Default.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.DefaultPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Proverbes</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" href="proverbes_styles.css" type="text/css">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblBientot" style="Z-INDEX: 101; LEFT: 259px; POSITION: absolute; TOP: 138px"
				runat="server" Width="333px" Height="27px" Font-Names="Verdana" Font-Size="Medium" Font-Bold="True"
				ForeColor="Navy">Ce n'est pas demain la veille !</asp:Label>
			<asp:Label id="lblDemain" style="Z-INDEX: 102; LEFT: 248px; POSITION: absolute; TOP: 167px"
				runat="server" Width="329px" Height="21px" Font-Names="Arial" Font-Size="X-Small">Bientôt, ici d'autres vérités toujours bonnes à entendre...</asp:Label>
			<asp:Label id="txtPath" runat="server" Font-Size="XX-Small">Label</asp:Label>
		</form>
	</body>
</HTML>
