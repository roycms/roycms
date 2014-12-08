<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ROYcms.Update._Default" %>
<%@ Register src="_header.ascx" tagname="_header" tagprefix="uc1" %>
<%@ Register src="_foot.ascx" tagname="_foot" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>ROYcms!NT 共享平台</title>
<link href="css/css.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
  <div id="wrap">
   <uc1:_header ID="_header1" runat="server" />  
    <div id="list-selected"><img src="Images/page_white_csharp.png" /> 每日一句：</div>
    <h1 class="biaoti">
      <div class="code_name">今日讨论主题</div>
    </h1>
    <div class="main">
      <div class="left">
        <asp:AdRotator ID="AdRotator1" runat="server"  DataSourceID="XmlDataSource_ads" />
        <asp:XmlDataSource ID="XmlDataSource_ads" runat="server" DataFile="~/App_Data/ads/ads.xml"></asp:XmlDataSource>
        <br />
        更新记录
        版本浏览
        加入团队
        贡献排行
        资源认领
        授权查询
        我的贡献
        三步走开始贡献
        我没有技术可以贡献意见
        我有技术要贡献源码
        
        受益者统计
        
        
        推荐平面设计团队
        推荐程序设计团队  
          
        </div>
      <div class="right"></div>
    </div>
<uc2:_foot ID="_foot1" runat="server" />
  </div>
</form>
</body>
</html>
