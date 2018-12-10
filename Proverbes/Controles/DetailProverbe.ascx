<%@ Control Language="c#" AutoEventWireup="false" Codebehind="DetailProverbe.ascx.cs" Inherits="Proverbes.net.DetailProverbe" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<br>
<br>
<table width="80%" align="center" border="1" bordercolor="#111111" style="BORDER-COLLAPSE: collapse" class="<% Response.Write((DuJour)?"ProvFondJour":"ProvFondNormal"); %>">
	<tr>
		<td>
			<table width="100%" align="center">
				<TBODY>
					<tr>
						<td colspan="2" valign="center" class="ProvTitre">
							<asp:Label id="lblTitre" runat="server">Il vaut mieux entendre ça que d'être sourd</asp:Label></td>
					</tr>
					<tr>
						<td width="10%" align="middle" valign="center">
							<asp:Image id="imgImage" runat="server" width="60" height="60" ImageUrl="images/sourd.gif"></asp:Image></td>
						<td width="90%" valign="top" class="<% Response.Write((DuJour)?"ProvDescriptionJour":"ProvDescriptionNormal"); %>">
							<asp:Label id="lblDescription" runat="server">						
						Évidemment, il vaut toujours 
							mieux entendre que d'être sourd. L'idée est donc de montrer le peu d'intérêt de 
							ce qui vient d'être dit. A employer lorsque quelqu'un vous adresse des paroles 
							désobligeantes.</asp:Label></td>
					</tr>
					<tr>
						<td colspan="2" class="<% Response.Write((DuJour)?"ProvContribJour":"ProvContribNormal"); %>" align="right">
							<asp:HyperLink id="lblContrib" runat="server" NavigateUrl="#">JenProv</asp:HyperLink>
							le
							<asp:Label id="lblDate" runat="server">02/02/2003</asp:Label></td>
					</tr>
		</td>
	</tr>
</table>
</TD></TR></TBODY></TABLE>
