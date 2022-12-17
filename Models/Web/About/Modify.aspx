<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.About.Modify" Title="修改页" %>
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
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Description
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDescription" runat="server" Width="200px"></asp:TextBox>
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
		关于我们图片
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtavg1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg2
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkavg2" Text="avg2" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtavg3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL11" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL12" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPicURL13" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WAdress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWAdress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Adress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAdress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PostNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPostNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		联系我们图片
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAPicURL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtavg4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtavg5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg6
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkavg6" Text="avg6" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片一描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		微信二维码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWXURL1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WXURL2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWXURL2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WXURL3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWXURL3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt8
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt8" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt9
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt9" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt10
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJDtxt10" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标题1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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

