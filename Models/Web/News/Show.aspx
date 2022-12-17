<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.News.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		文章添加时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddDateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		作者
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAuthor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		内容
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblContent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDescription" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FileURL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFileURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		来源
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFromWhere" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
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
		IsDelete
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsDelete" runat="server"></asp:Label>
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
		IsTJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsTJ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否热点
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsHot" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否置顶
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsTop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		关键字
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblKeyWord" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		主图地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		阅读量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分类ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSortID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标签
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		URL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		视频地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVideoURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		权重
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWeight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		站点
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSiteID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UninoID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUninoID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否是写真
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsPic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStore
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsStore" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DingNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDingNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZhuangNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZhuangNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZhiChiNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZhiChiNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SCNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSCNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HasAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHasAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddressName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddressName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddressX
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddressX" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddressY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddressY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShopMenberID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShopMenberID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShareTxt
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShareTxt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SharePicID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSharePicID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShareMainPicUrl
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShareMainPicUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EditDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEditDateTime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




