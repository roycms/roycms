<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.Tools.Ads._Default" Codebehind="Default.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="addAd.aspx" target="_blank">添加广告</a> --  <a href="AdDemo.aspx" target="_blank">动态调用展示</a>  --  <a href="htmldemo.html" target="_blank">静态调用展示</a>
    <asp:DataList ID="DataListAdSort" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
    <ItemTemplate>
    <a href="?id=<%#DataBinder.Eval(Container.DataItem, "id")%>"><%#DataBinder.Eval(Container.DataItem, "sortname")%></a>&nbsp;&nbsp;
    </ItemTemplate>
    </asp:DataList>
    <br />
    <asp:Repeater ID="RepAdList" runat="server">
    <ItemTemplate>
    <%#DataBinder.Eval(Container.DataItem, "adname")%>&nbsp;&nbsp;&nbsp;<a href="addAd.aspx?action=edit&id=<%#DataBinder.Eval(Container.DataItem, "id")%>">[修改]</a>
    </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
