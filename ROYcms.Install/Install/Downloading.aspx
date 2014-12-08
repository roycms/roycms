<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Downloading.aspx.cs" Inherits="ROYcms.Install.Install.Downloading" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>下载压缩包</title>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server">
    <div style=" margin-top:100px; font-family:微软雅黑; ">
    <h3>
        自动下载安装系统]&nbsp; 
        <asp:Button ID="Button_ZIP" runat="server" Text="下载文件并释放到本地" onclick="Button_ZIP_Click" OnClientClick="return window.confirm('确定要这样操作吗？');" />
        </h3>
    <p>来自 <a href='<%=ROYcms.Common.GetUrlText.GetText("http://www.roycms.cn/api/Update.ashx?i=Install_ROYcms_Path","utf-8")%>'><%=ROYcms.Common.GetUrlText.GetText("http://www.roycms.cn/api/Update.ashx?i=Install_ROYcms_Path","utf-8")%></a></p>
    </div>
    </form>
</body>
</html>
