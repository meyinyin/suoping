<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.About.Show" Title="显示页" %>
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
		Description
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDescription" runat="server"></asp:Label>
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
		关于我们图片
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL" runat="server"></asp:Label>
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
		基地展示图片1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL11" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL12" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		荣誉资质8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPicURL13" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WAdress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWAdress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Adress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAdress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PostNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPostNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		联系我们图片
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAPicURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		avg4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblavg4" runat="server"></asp:Label>
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
		avg6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblavg6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片一描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		基地展示图片描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		微信二维码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWXURL1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WXURL2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWXURL2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WXURL3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWXURL3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt7" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt8
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt8" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt9
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt9" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JDtxt10
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJDtxt10" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标题1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle1" runat="server"></asp:Label>
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
		Title3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle7" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




