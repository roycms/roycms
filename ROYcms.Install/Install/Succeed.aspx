<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Succeed.aspx.cs" Inherits="ROYcms.Install.Install.Succeed" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<HEAD>
<title>安装 ROYcms!NT 2.0 (.NET Framework 2.0/3.x)</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<LINK rev="stylesheet" media="all" href="images/styles.css" type="text/css" rel="stylesheet">
        <style type="text/css">
            .style1
            {
                width: 54%;
            }
            .style2
            {
                width: 69%;
            }
        </style>
</HEAD>
<body>
<form id="form1" runat="server">
  <table width="700" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#666666">
    <tr>
      <td bgcolor="#ffffff"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td colspan="2" bgcolor="#333333"><table width="100%" border="0" cellspacing="0" cellpadding="8">
                <tr>
                  <td><font color="#ffffff">欢迎安装
                    ROYcms!NT 2.0 (.NET Framework 2.0/3.x) </font></td>
                </tr>
              </table></td>
          </tr>
          <tr>
            <td width="180" valign="top"><img src="images/logo.jpg" width="180" height="300"></td>
            <td width="520" valign="top"><br>
              <br>
              <table id="Table2" cellspacing="1" cellpadding="1" width="90%" align="center" border="0">
                <tr>
                  <td height="36" align="center" class="style2">
 
                      <h4>安装ROYcms!NT 2.0 成功！</h4></td>
                  <td width="18%" align="center">&nbsp;</td>
                </tr>
                <tr>
                  <td height="180" align="center" class="style2"><img src="images/succeed.jpg" width="120" height="120" /></td>
                  <td height="180" align="center">&nbsp;</td>
                </tr>
              </table>
              <p>
            </p></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td><table width="90%" border="0" cellspacing="0" cellpadding="8">
                <tr>
                  <td align="right" class="style1"><asp:CheckBox ID="CheckBox_Del" runat="server" 
                          Text="删除安装目录" Checked="True" /></td>
                  <td width="41%" align="right"><asp:Button ID="Button_Succeed" runat="server"   
                          Text="转到首页" Height="30px"   Width="88px" onclick="Button_Succeed_Click" /> &nbsp;<asp:Button 
                          ID="Button_Succeed_admin" runat="server"   
                          Text="转到后台管理" Height="30px"   Width="88px" 
                          onclick="Button_Succeed_admin_Click" /></td>
                </tr>
              </table></td>
          </tr>
        </table></td>
    </tr>
  </table>
  <br />
  <br />
  <table width="700" border="0" align="center" cellpadding="0" cellspacing="0" ID="Table1">
    <tr>
      <td align="center"><div align="center" style="position:relative ; padding-top:60px;font-size:14px; font-family: Arial">
          <hr style="height:1; width:600; height:1; color:#CCCCCC" />
          Powered by ROYcms!NT 2.0 (.NET Framework 2.0/3.x)         &nbsp;<br />
          &copy; 2001-2008 ROYcms Inc.</div></td>
    </tr>
  </table>
</form>
</body>
</html>
