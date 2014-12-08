<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="s带分页列表示例.aspx.cs" Inherits="ROYcms.Demo.带分页列表示例" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>带分页列表示例.aspx</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <CMS:WebPageRepeater  Class="49" runat="server">
       
      <ItemTemplate>
      <%#Container.ItemIndex%1==0 ? "<hr />" :String.Empty%>
      分类ID:[ <%#Eval("classname") %> ] 标题:<%#Eval("title") %>
      </ItemTemplate>
    </CMS:WebPageRepeater>
       
    </div>
    </form>
</body>
</html>
