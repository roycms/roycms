<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_all.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.UCenter.User_all" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="InsertObjetForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div id="rotate"> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> 
        <a href=' /administrator/ucenter/User.aspx'><img align="absmiddle" src="/administrator/images/nv9.png" />返回用户管理</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>会员基本信息</li>
        <li>会员扩展信息</li>
       
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">
      <table   cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
      <tr>
        <td width="111" align="right" bgcolor="#F4FBFF"><strong>注册名</strong></td>
        <td width="1020" bgcolor="#F4FBFF"><%=Model.name%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>昵称</strong></td>
        <td bgcolor="#F4FBFF"><%=Model.username%></td>
      </tr>
           <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>密码</strong></td>
        <td bgcolor="#F4FBFF"><%=Model.password%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>QQ</strong></td>
        <td bgcolor="#F4FBFF"><%=Model.qq%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>年龄</strong></td>
        <td bgcolor="#F4FBFF">
      <%=Model.age%>
      </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>性别</strong></td>
        <td bgcolor="#F4FBFF"><%=Model.sex%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>头像</strong></td>
        <td bgcolor="#F4FBFF"><%=Model.pic%></td>
      </tr>

       <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>注册时间</strong></td>
        <td bgcolor="#F4FBFF"><%=Model.login_time%></td>
      </tr>
    </table>
  

      </div>
      <div class="layout">
<%if (Model1!=null){ %>
<table   cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
      <tr>
        <td width="111" align="right" bgcolor="#F4FBFF"><strong>账户余额</strong></td>
        <td width="1020" bgcolor="#F4FBFF"><%=Model1.AccountBalance%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>可用余额</strong></td>
        <td bgcolor="#F4FBFF"><%=Model1.AvilableBalance%></td>
      </tr>
           <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>已消费金额</strong></td>
        <td bgcolor="#F4FBFF"><%=Model1.ConsumedAmount%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>积分</strong></td>
        <td bgcolor="#F4FBFF"><%=Model1.Money%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>用户等级</strong></td>
        <td bgcolor="#F4FBFF"><%=Model1.GradeID%>
      
        </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>有效状态</strong></td>
        <td bgcolor="#F4FBFF"><%=Model1.State%></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>联系人姓名</strong></td>
        <td bgcolor="#F4FBFF"><%=Model1.RealName%></td>
      </tr>

       <tr>
         <td align="right" bgcolor="#F4FBFF"><strong>联系人手机</strong></td>
         <td bgcolor="#F4FBFF"><%=Model1.Mobil%></td>
       </tr>
       <tr>
         <td align="right" bgcolor="#F4FBFF"><strong>电话</strong></td>
         <td bgcolor="#F4FBFF"><%=Model1.Tel%></td>
       </tr>
       <tr>
         <td align="right" bgcolor="#F4FBFF"><strong>地址</strong></td>
         <td bgcolor="#F4FBFF"><%=Model1.Address%></td>
       </tr>
       <tr>
         <td align="right" bgcolor="#F4FBFF"><strong>邮编</strong></td>
         <td bgcolor="#F4FBFF"><%=Model1.Postcode%></td>
       </tr>
       <tr>
         <td align="right" bgcolor="#F4FBFF"><strong>网站</strong></td>
         <td bgcolor="#F4FBFF"><%=Model1.Website%></td>
       </tr>
       <tr>
         <td align="right" bgcolor="#F4FBFF"><strong>身份证号</strong></td>
         <td bgcolor="#F4FBFF"><%=Model1.IDcardNum%></td>
       </tr>
       <tr>
         <td align="right" bgcolor="#F4FBFF"><strong>账户类型</strong></td>
         <td bgcolor="#F4FBFF"><%=Model1.AccountType%></td>
       </tr>
       <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>站点ID</strong></td>
        <td bgcolor="#F4FBFF"><%=Model1.SiteID%></td>
      </tr>
    </table>
<%} else{%>
          暂无数据

        <%} %>
      </div>
    
    </div> 

  </div>
</form>        
</body>
</html>


