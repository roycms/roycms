<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="go_class.aspx.cs" Inherits="ROYcms.UI.Admin.go_class" %>
<!DOCTYPE HTML>
<html >
<body>
<form id="form1" runat="server" style="padding:5px;">

    <table width="100"  cellpadding="2" cellspacing="2">

      <tr>
        <td nowrap="nowrap"><strong>从下列所选频道的内容转移到→</strong></td>
        <td nowrap="nowrap"><strong>转移到的频道</strong></td>
      </tr>
      <tr>
        <td nowrap="nowrap">
        <asp:ListBox ID="ListBox_go" CssClass="select" runat="server" datasourceid="go_class_ObjectDataSource" DataTextField="ClassName" DataValueField="Id" Width="150px" Height="160px"></asp:ListBox></td>
        <td nowrap="nowrap">
        <asp:ListBox ID="ListBox_to"  CssClass="select"  runat="server" datasourceid="go_class_ObjectDataSource" DataTextField="ClassName" DataValueField="Id"  Width="150px" Height="160px"></asp:ListBox></td>
      </tr>
      <tr>
        <td colspan="2" nowrap="nowrap"><asp:Button ID="Button_yd" runat="server" Text="确认转移信息" OnClick="Button_yd_Click" CssClass="btnSearch" /></td>
      </tr>
    </table>

    <asp:ObjectDataSource ID="go_class_ObjectDataSource" runat="server" SelectMethod="GetClassList" TypeName="ROYcms.Sys.BLL.ROYcms_class">
      <SelectParameters>
        <asp:QueryStringParameter Name="ClassKind" QueryStringField="ClassKind" Type="Int32" />
      </SelectParameters>
    </asp:ObjectDataSource>

</form>
</body>
</html>
