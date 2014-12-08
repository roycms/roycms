<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ROYcms.Update.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>会员登录页</title>
<link href="css/Ucenter.css" rel="stylesheet" type="text/css" />

</head>

<body>
<table height='100%' align="center"   valign="center"><tr><td>
<div class="ucenter">
<div id="logo">
  <img src="Images/logo.png" width="221" height="59" /></div>
<div class="neirong">
<p>欢迎您使用共享平台，交流，分享，协作！</p>
  <div>
   <div class="left">
    <h1>注册</h1>
    <p>您可以使用 SiteShare ID 访问各种 SiteShare 服务，包括 资源共享、程序协作 等等。</p>
    <p>没有 SiteShare ID？</p>
    
        <input type="submit" name="button" id="button" value="注册" />
      
    <p>有关 SiteShare ID 的详细信息<br />
      <a href="#">隐私策略</a></p>
   </div>
   <div class="right">
    <h1>登录</h1>
    <form action="" method="get">
     <p>SiteShare ID：
       <label>
         <input class="text" type="text" name="textfield" id="textfield" />
       </label>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;如：admin@anan360.cn
       
     </p>
     <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;密 码：
       <label>
         <input class="text" type="text" name="textfield2" id="textfield2" />
       </label>
     </p>
     <p>
       <label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="checkbox" name="checkbox" id="checkbox" />在此计算机上保留我的信息 (?)
       </label><br />
       <label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="checkbox" name="checkbox2" id="checkbox2" />记住我的密码 (?)
       </label>
     </p>
     <p>
       <label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <input type="submit" name="button2" id="button2" value="提交" />
       </label>
     </p>
    </form>
   </div>
  </div>
 </div>
</div>
<div id="copyright" class="en"> &copy; 2009 SiteShare</div>
</td></tr></table>
</body>
</html>
