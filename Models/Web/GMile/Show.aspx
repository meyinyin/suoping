<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.GMile.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GContent
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGContent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GChannel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGChannel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblavg5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FaceURL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFaceURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsLock
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsLock" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PicUrl
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RouteUrl
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRouteUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MsgType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMsgType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MsgSortID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMsgSortID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TargetID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTargetID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MsgParentID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMsgParentID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Level
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIP" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




