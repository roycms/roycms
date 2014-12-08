<%@ Page Title="用户信息扩展表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="DNSABC.Web.DNSABC_UserInfo.List" %>
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
                            
		<asp:BoundField DataField="UserId" HeaderText="用户ID" SortExpression="UserId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AccountBalance" HeaderText="账户余额" SortExpression="AccountBalance" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AvilableBalance" HeaderText="可用余额" SortExpression="AvilableBalance" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ConsumedAmount" HeaderText="已经消费金额" SortExpression="ConsumedAmount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Money" HeaderText="积分" SortExpression="Money" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GradeID" HeaderText="用户等级ID 默认值1" SortExpression="GradeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="State" HeaderText="有效状态 0为停用" SortExpression="State" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RealName" HeaderText="联系人姓名" SortExpression="RealName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Qq" HeaderText="QQ号码" SortExpression="Qq" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mobil" HeaderText="联系人手机" SortExpression="Mobil" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tel" HeaderText="电话" SortExpression="Tel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="地址" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Postcode" HeaderText="邮编" SortExpression="Postcode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Website" HeaderText="网站" SortExpression="Website" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IDcardNum" HeaderText="身份证号码" SortExpression="IDcardNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AccountType" HeaderText="账户类型 企业则对应企业信息表" SortExpression="AccountType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SiteID" HeaderText="站点ID 0为主站 大于0为站" SortExpression="SiteID" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
