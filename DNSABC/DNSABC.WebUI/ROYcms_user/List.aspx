<%@ Page Title="用户信息 用户表 R" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="DNSABC.Web.ROYcms_user.List" %>
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
                    BorderWidth="1px" DataKeyNames="bh" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="RoleID" HeaderText="权限ID" SortExpression="RoleID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UgroupID" HeaderText="用户组ID" SortExpression="UgroupID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Name" HeaderText="用户名" SortExpression="Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PASSWORD" HeaderText="密码" SortExpression="PASSWORD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="money" HeaderText="积分" SortExpression="money" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Qq" HeaderText="QQ" SortExpression="Qq" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Email" HeaderText="邮件" SortExpression="Email" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Age" HeaderText="年龄" SortExpression="Age" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sex" HeaderText="性别" SortExpression="sex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Pic" HeaderText="头像" SortExpression="Pic" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Quanxian" HeaderText="权限" SortExpression="Quanxian" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Username" HeaderText="昵称" SortExpression="Username" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Guid" HeaderText="全局ID" SortExpression="Guid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ip" HeaderText="IP" SortExpression="Ip" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LoginTime" HeaderText="注册时间" SortExpression="LoginTime" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="bh" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="bh" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
