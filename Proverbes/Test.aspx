<%@ Page language="c#" Codebehind="Test.aspx.cs" AutoEventWireup="false" Inherits="Proverbes.net.TestDotNet" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TestDotNet</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="txtFwk" style="Z-INDEX: 100; LEFT: 16px; POSITION: absolute; TOP: 21px" runat="server"
				Font-Size="X-Small" ForeColor="Navy" Font-Names="Arial" Width="144px">.NET Framework...</asp:label>
			<asp:button id="bTestWSC" style="Z-INDEX: 113; LEFT: 304px; POSITION: absolute; TOP: 112px"
				runat="server" Height="24px" Text="Test"></asp:button>
			<asp:label id="txtWSCIsOK" style="Z-INDEX: 109; LEFT: 224px; POSITION: absolute; TOP: 120px"
				runat="server" Width="32px" Font-Names="Arial" ForeColor="Navy" Font-Size="X-Small"></asp:label>
			<asp:label id="txtWSCompteur" style="Z-INDEX: 107; LEFT: 16px; POSITION: absolute; TOP: 120px"
				runat="server" Width="192px" Font-Names="Arial" ForeColor="Navy" Font-Size="X-Small">Web Service Compteur...</asp:label><asp:button id="bTestWSP" style="Z-INDEX: 110; LEFT: 304px; POSITION: absolute; TOP: 80px" runat="server"
				Text="Test" Height="24px"></asp:button><asp:label id="txtWSPIsOK" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 88px"
				runat="server" Font-Size="X-Small" ForeColor="Navy" Font-Names="Arial" Width="32px"></asp:label><asp:label id="txtWSProv" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 88px" runat="server"
				Font-Size="X-Small" ForeColor="Navy" Font-Names="Arial" Width="192px">Web Service Proverbes...</asp:label><asp:button id="bTestFwk" style="Z-INDEX: 105; LEFT: 304px; POSITION: absolute; TOP: 16px" runat="server"
				Enabled="False" Text="Test" Height="24px"></asp:button><asp:label id="txtDbIsOK" style="Z-INDEX: 103; LEFT: 224px; POSITION: absolute; TOP: 56px"
				runat="server" Font-Size="X-Small" ForeColor="Navy" Font-Names="Arial" Width="32px"></asp:label><asp:label id="txtFwkIsOK" style="Z-INDEX: 102; LEFT: 224px; POSITION: absolute; TOP: 21px"
				runat="server" Font-Size="X-Small" ForeColor="Navy" Font-Names="Arial" Width="32px">OK</asp:label><asp:label id="txtDb" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 56px" runat="server"
				Font-Size="X-Small" ForeColor="Navy" Font-Names="Arial" Width="144px">Base de données...</asp:label>&nbsp;
			<asp:button id="bTestDb" style="Z-INDEX: 104; LEFT: 304px; POSITION: absolute; TOP: 48px" runat="server"
				Text="Test" Height="24px"></asp:button>
			<asp:Label id="txtError" style="Z-INDEX: 112; LEFT: 24px; POSITION: absolute; TOP: 168px" runat="server"
				Font-Size="X-Small" ForeColor="Red" Font-Names="Arial" Width="912px" Height="344px"></asp:Label></form>
	</body>
</HTML>
