<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>新闻列表</h3>
        <CMS:WebRepeater ID="WebRepeater1" Class="12"  runat="server">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate>

        <a href='<%#Eval("ShowLink") %>'>【栏目：<%#Eval("ClassName") %>】<%#Eval("title") %></a>
        <br />

        </ItemTemplate>
        <FooterTemplate></FooterTemplate>
        </CMS:WebRepeater>
    </div>
    </form>
</body>
</html>
