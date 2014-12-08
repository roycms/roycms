<%@ Page Title="主机业务表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="DNSABC.Web.DNSABC_Cdn.List" %>
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
                            
		<asp:BoundField DataField="ProductID" HeaderText="产品ID" SortExpression="ProductID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserID" HeaderText="用户ID" SortExpression="UserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Domain" HeaderText="域名 域名是唯一的" SortExpression="Domain" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PASSWORD" HeaderText="域名密码 随机生成w3e4r2r6r6t4" SortExpression="PASSWORD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StarTime" HeaderText="注册时间" SortExpression="StarTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EndTime" HeaderText="到期时间" SortExpression="EndTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isHost" HeaderText="主机个数 0表示主机个数不限制" SortExpression="isHost" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isConnection" HeaderText="允许连接数 0表示连接数不限制" SortExpression="isConnection" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isBandwidth" HeaderText="带宽 0表示带宽不限制" SortExpression="isBandwidth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="State" HeaderText="解析状态 0为停用" SortExpression="State" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="备注" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpdateTime" HeaderText="更新时间" SortExpression="UpdateTime" ItemStyle-HorizontalAlign="Center"  /> 
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
