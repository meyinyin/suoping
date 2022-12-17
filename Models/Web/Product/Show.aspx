<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.Product.Show" Title="显示页" %>
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
		产品主图
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PicURL1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PicURL2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PicURL3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PicURL4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PicURL5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		产品标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		产品描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDescription" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		产品标签
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Info
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsHot
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsHot" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsTop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsTop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsTJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsTJ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		KeyWord
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblKeyWord" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SortID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSortID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VideoURL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVideoURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Weight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWeight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReadCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadCount" runat="server"></asp:Label>
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
		IsDelete
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsDelete" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblavg1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblavg2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblavg3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddDateTime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




