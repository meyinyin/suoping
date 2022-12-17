<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.News.Modify" Title="修改页" %>
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
		<asp:TextBox ID="txtAddDateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		作者
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAuthor" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		内容
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtContent" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDescription" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FileURL
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFileURL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		来源
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFromWhere" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Info
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInfo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDelete
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsDelete" Text="IsDelete" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsLock
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsLock" Text="IsLock" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsTJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsTJ" Text="IsTJ" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否热点
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsHot" Text="是否热点" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否置顶
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsTop" Text="是否置顶" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		关键字
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtKeyWord" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		主图地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		阅读量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtReadCount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分类ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSortID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标签
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		URL
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtURL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		视频地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVideoURL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		权重
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWeight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		站点
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSiteID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UninoID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUninoID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否是写真
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsPic" Text="是否是写真" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStore
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsStore" Text="IsStore" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DingNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDingNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZhuangNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZhuangNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZhiChiNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZhiChiNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SCNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSCNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HasAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkHasAddress" Text="HasAddress" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddressName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddressName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddressX
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddressX" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddressY
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddressY" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShopMenberID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtShopMenberID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShareTxt
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtShareTxt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SharePicID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSharePicID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShareMainPicUrl
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtShareMainPicUrl" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EditDateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtEditDateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

