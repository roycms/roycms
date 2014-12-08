<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="信息列表示例.aspx.cs" Inherits="ROYcms.Demo.信息列表示例" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>信息列表示例.aspx</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <CMS:WebRepeater ID="WebRepeater1" Class=48  TuiJian="0" Switchs="0" runat="server">
         <ItemTemplate>
         <CMS:Link Rid=<%#Eval("bh") %> runat=server />
         
      <%#Container.ItemIndex%1==0 ? "<hr />" :String.Empty%>
    分类ID:[ <%#Eval("classname") %> ] 标题:<%#Eval("title") %>
      </ItemTemplate>
        </CMS:WebRepeater>
        
        
    </div>
    </form>
</body>
</html>
