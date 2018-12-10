<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Bandeau.ascx.cs" Inherits="Proverbes.net.Bandeau" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<table width="100%" cellpadding="0" cellspacing="0" border="0" background="<% Response.Write(background); %>">
	<tr height="56">
		<td align="middle" class="BandeauTitre"><asp:Label id="lblTitre" runat="server">Le Titre</asp:Label></td>
	</tr>
</table>
