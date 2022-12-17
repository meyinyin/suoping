<%@ Page Title="GMile" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.GMile.List" %>
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
                            
		<asp:BoundField DataField="GName" HeaderText="GName" SortExpression="GName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GContent" HeaderText="GContent" SortExpression="GContent" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GDate" HeaderText="GDate" SortExpression="GDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GChannel" HeaderText="GChannel" SortExpression="GChannel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GState" HeaderText="GState" SortExpression="GState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="avg5" HeaderText="avg5" SortExpression="avg5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FaceURL" HeaderText="FaceURL" SortExpression="FaceURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsLock" HeaderText="IsLock" SortExpression="IsLock" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicUrl" HeaderText="PicUrl" SortExpression="PicUrl" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RouteUrl" HeaderText="RouteUrl" SortExpression="RouteUrl" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MsgType" HeaderText="MsgType" SortExpression="MsgType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MsgSortID" HeaderText="MsgSortID" SortExpression="MsgSortID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TargetID" HeaderText="TargetID" SortExpression="TargetID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MsgParentID" HeaderText="MsgParentID" SortExpression="MsgParentID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Level" HeaderText="Level" SortExpression="Level" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IP" HeaderText="IP" SortExpression="IP" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
