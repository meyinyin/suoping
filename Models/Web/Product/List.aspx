<%@ Page Title="Product" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.Product.List" %>
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
                            
		<asp:BoundField DataField="PicURL" HeaderText="产品主图" SortExpression="PicURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL1" HeaderText="PicURL1" SortExpression="PicURL1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL2" HeaderText="PicURL2" SortExpression="PicURL2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL3" HeaderText="PicURL3" SortExpression="PicURL3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL4" HeaderText="PicURL4" SortExpression="PicURL4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL5" HeaderText="PicURL5" SortExpression="PicURL5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title" HeaderText="产品标题" SortExpression="Title" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Description" HeaderText="产品描述" SortExpression="Description" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tag" HeaderText="产品标签" SortExpression="Tag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Info" HeaderText="Info" SortExpression="Info" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsHot" HeaderText="IsHot" SortExpression="IsHot" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsTop" HeaderText="IsTop" SortExpression="IsTop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsTJ" HeaderText="IsTJ" SortExpression="IsTJ" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="KeyWord" HeaderText="KeyWord" SortExpression="KeyWord" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SortID" HeaderText="SortID" SortExpression="SortID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="VideoURL" HeaderText="VideoURL" SortExpression="VideoURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReadCount" HeaderText="ReadCount" SortExpression="ReadCount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsLock" HeaderText="IsLock" SortExpression="IsLock" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsDelete" HeaderText="IsDelete" SortExpression="IsDelete" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title2" HeaderText="Title2" SortExpression="Title2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg1" HeaderText="avg1" SortExpression="avg1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg2" HeaderText="avg2" SortExpression="avg2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg3" HeaderText="avg3" SortExpression="avg3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddDateTime" HeaderText="AddDateTime" SortExpression="AddDateTime" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
