<%@ Page Title="About" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.About.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Info" HeaderText="Info" SortExpression="Info" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL" HeaderText="关于我们图片" SortExpression="PicURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg1" HeaderText="avg1" SortExpression="avg1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg2" HeaderText="avg2" SortExpression="avg2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg3" HeaderText="avg3" SortExpression="avg3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL1" HeaderText="基地展示图片1" SortExpression="PicURL1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL2" HeaderText="基地展示图片2" SortExpression="PicURL2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL3" HeaderText="基地展示图片3" SortExpression="PicURL3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL4" HeaderText="基地展示图片4" SortExpression="PicURL4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL5" HeaderText="基地展示图片5" SortExpression="PicURL5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL6" HeaderText="荣誉资质1" SortExpression="PicURL6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL7" HeaderText="荣誉资质2" SortExpression="PicURL7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL8" HeaderText="荣誉资质3" SortExpression="PicURL8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL9" HeaderText="荣誉资质4" SortExpression="PicURL9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL10" HeaderText="荣誉资质5" SortExpression="PicURL10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL11" HeaderText="荣誉资质6" SortExpression="PicURL11" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL12" HeaderText="荣誉资质7" SortExpression="PicURL12" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL13" HeaderText="荣誉资质8" SortExpression="PicURL13" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WAdress" HeaderText="WAdress" SortExpression="WAdress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Adress" HeaderText="Adress" SortExpression="Adress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CPhone" HeaderText="CPhone" SortExpression="CPhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PostNum" HeaderText="PostNum" SortExpression="PostNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="APicURL" HeaderText="联系我们图片" SortExpression="APicURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg4" HeaderText="avg4" SortExpression="avg4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg5" HeaderText="avg5" SortExpression="avg5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg6" HeaderText="avg6" SortExpression="avg6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt1" HeaderText="基地展示图片一描述" SortExpression="JDtxt1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt2" HeaderText="基地展示图片描述" SortExpression="JDtxt2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt3" HeaderText="基地展示图片描述" SortExpression="JDtxt3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt4" HeaderText="基地展示图片描述" SortExpression="JDtxt4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt5" HeaderText="基地展示图片描述" SortExpression="JDtxt5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WXURL1" HeaderText="微信二维码" SortExpression="WXURL1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WXURL2" HeaderText="WXURL2" SortExpression="WXURL2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WXURL3" HeaderText="WXURL3" SortExpression="WXURL3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt6" HeaderText="JDtxt6" SortExpression="JDtxt6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt7" HeaderText="JDtxt7" SortExpression="JDtxt7" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt8" HeaderText="JDtxt8" SortExpression="JDtxt8" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt9" HeaderText="JDtxt9" SortExpression="JDtxt9" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JDtxt10" HeaderText="JDtxt10" SortExpression="JDtxt10" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title1" HeaderText="标题1" SortExpression="Title1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title2" HeaderText="Title2" SortExpression="Title2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title3" HeaderText="Title3" SortExpression="Title3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title4" HeaderText="Title4" SortExpression="Title4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title5" HeaderText="Title5" SortExpression="Title5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title7" HeaderText="Title7" SortExpression="Title7" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
