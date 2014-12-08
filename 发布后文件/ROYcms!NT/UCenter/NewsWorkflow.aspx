<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsWorkflow.aspx.cs" Inherits="ROYcms.UCenter.NewsWorkflow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<asp:Repeater ID="Repeater_list" runat="server">
<ItemTemplate>
<li>
<a href='?keyId=<%#Eval("bh")%>' target=_blank ><%#Eval("title")%></a> <%#Eval("time")%>
<asp:CheckBox ID="CheckBox1" runat="server" />
</li>
</ItemTemplate>
</asp:Repeater>
<div class="butt">
<asp:Button ID="Button1" runat="server" Text="批量审核通过" />
<asp:CheckBox ID="CheckBox2" runat="server" Text="全选" />
</div>
    </div>
    </form>
</body>
</html>
