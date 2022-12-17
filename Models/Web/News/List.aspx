<%@ Page Title="News" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.News.List" %>
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
                            
		<asp:BoundField DataField="AddDateTime" HeaderText="文章添加时间" SortExpression="AddDateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Author" HeaderText="作者" SortExpression="Author" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Content" HeaderText="内容" SortExpression="Content" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Description" HeaderText="描述" SortExpression="Description" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FileURL" HeaderText="FileURL" SortExpression="FileURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FromWhere" HeaderText="来源" SortExpression="FromWhere" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Info" HeaderText="Info" SortExpression="Info" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsDelete" HeaderText="IsDelete" SortExpression="IsDelete" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsLock" HeaderText="IsLock" SortExpression="IsLock" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsTJ" HeaderText="IsTJ" SortExpression="IsTJ" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsHot" HeaderText="是否热点" SortExpression="IsHot" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsTop" HeaderText="是否置顶" SortExpression="IsTop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="KeyWord" HeaderText="关键字" SortExpression="KeyWord" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PicURL" HeaderText="主图地址" SortExpression="PicURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReadCount" HeaderText="阅读量" SortExpression="ReadCount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SortID" HeaderText="分类ID" SortExpression="SortID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tag" HeaderText="标签" SortExpression="Tag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title" HeaderText="标题" SortExpression="Title" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="URL" HeaderText="URL" SortExpression="URL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="VideoURL" HeaderText="视频地址" SortExpression="VideoURL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Weight" HeaderText="权重" SortExpression="Weight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SiteID" HeaderText="站点" SortExpression="SiteID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UninoID" HeaderText="UninoID" SortExpression="UninoID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsPic" HeaderText="是否是写真" SortExpression="IsPic" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsStore" HeaderText="IsStore" SortExpression="IsStore" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DingNum" HeaderText="DingNum" SortExpression="DingNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZhuangNum" HeaderText="ZhuangNum" SortExpression="ZhuangNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZhiChiNum" HeaderText="ZhiChiNum" SortExpression="ZhiChiNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SCNum" HeaderText="SCNum" SortExpression="SCNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HasAddress" HeaderText="HasAddress" SortExpression="HasAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddressName" HeaderText="AddressName" SortExpression="AddressName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="地址" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddressX" HeaderText="AddressX" SortExpression="AddressX" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddressY" HeaderText="AddressY" SortExpression="AddressY" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShopMenberID" HeaderText="ShopMenberID" SortExpression="ShopMenberID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShareTxt" HeaderText="ShareTxt" SortExpression="ShareTxt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SharePicID" HeaderText="SharePicID" SortExpression="SharePicID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShareMainPicUrl" HeaderText="ShareMainPicUrl" SortExpression="ShareMainPicUrl" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EditDateTime" HeaderText="EditDateTime" SortExpression="EditDateTime" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
