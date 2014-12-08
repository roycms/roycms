<%@ Page Title="发票记录表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="DNSABC.Web.DNSABC_Invoice.List" %>
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
                    BorderWidth="1px" DataKeyNames="Id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="UserID" HeaderText="申领人" SortExpression="UserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceName" HeaderText="发票抬头" SortExpression="InvoiceName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="申领金额" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PostType" HeaderText="邮寄方式" SortExpression="PostType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RealName" HeaderText="联系人" SortExpression="RealName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tel" HeaderText="电话" SortExpression="Tel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mobil" HeaderText="手机" SortExpression="Mobil" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="邮寄地址" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PostCode" HeaderText="邮编" SortExpression="PostCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="备注 用户申请发票时的备注信息" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="State" HeaderText="管理员处理状态 0为未处理" SortExpression="State" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AdminRemark" HeaderText="管理员备注 备注发票邮寄方式信" SortExpression="AdminRemark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CreateTime" HeaderText="创建时间" SortExpression="CreateTime" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
