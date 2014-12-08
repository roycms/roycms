<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="step1.aspx.cs" Inherits="ROYcms.Install.Install.step1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<HEAD>
<title>安装 ROYcms!NT 2.0 (.NET Framework 2.0/3.x)</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<LINK rev="stylesheet" media="all" href="images/styles.css" type="text/css" rel="stylesheet">
</HEAD>
<body>
<form id="form1" runat="server">
  <table width="700" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#666666">
    <tr>
      <td bgcolor="#ffffff"><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td colspan="2" bgcolor="#333333"><table width="100%" border="0" cellspacing="0" cellpadding="8">
                <tr>
                  <td><font color="#ffffff">欢迎安装 ROYcms!NT 2.0 (.NET Framework 2.0/3.x) </font></td>
                </tr>
              </table></td>
          </tr>
          <tr>
            <td width="180" valign="top"><img src="images/logo.jpg" width="180" height="300"></td>
            <td width="520" valign="top"><br>
              <br>
              <table id="Table2" cellspacing="1" cellpadding="5" width="90%" align="center" border="0">
                <tr>
                  <td height="51" colspan="2" align="left"><h2  style="font-family:微软雅黑;"> 欢迎您安装 ROYcms!NT 2.0 <span style="font-size:12px; color:#999">(.NET Framework 2.0/3.x)</span> </h2></td>
                </tr>
                <tr>
                  <td height="19" colspan="2"><strong>运行环境进行检测</strong></td>
                </tr>
                <tr>
                  <td height="53" colspan="2"> 主要检 web.config, APP_DATE, App_Config, App_Templet, App_Appendix和APP_pic文件夹 的可写权限 <br />                    权限设置请参照：《设置NTFS磁盘文件夹的可写权限》</td>
                </tr>
                <tr>
                  <td height="79" colspan="2"><ul class="detection">
                  

                  
                              <li class="Error" runat="server" id="WebConfigLi">
                                <asp:Literal runat="server" ID="WebConfigExamine"></asp:Literal>
                              </li>
                              <li class="Error" runat="server" id="APP_DATELi">
                                <asp:Literal runat="server" ID="APP_DATEExamine"></asp:Literal>
                              </li>
                              <li class="Error" runat="server" id="App_ConfigLi">
                                <asp:Literal runat="server" ID="App_ConfigExamine"></asp:Literal>
                              </li>
                               
                                  <li class="Error" runat="server" id="App_TempletLi">
                                <asp:Literal runat="server" ID="App_TempletExamine"></asp:Literal>
                              </li>
                              
                                 <li class="Error" runat="server" id="App_AppendixLi">
                                <asp:Literal runat="server" ID="App_AppendixExamine"></asp:Literal>
                              </li>
                              
                                 <li class="Error" runat="server" id="APP_picLi">
                                <asp:Literal runat="server" ID="APP_picExamine"></asp:Literal>
                              </li>

                              
                            </ul></td>
                </tr>
                <tr>
                  <td width="44%" height="33" nowrap="nowrap">&nbsp;</td>
                  <td width="56%" nowrap="nowrap"><span class="stepButtonCenter">
                    <asp:LinkButton runat="server" ID="NextStep">转到下一步</asp:LinkButton>
                    <asp:LinkButton runat="server" ID="ReExamine">重新检测</asp:LinkButton>
                  </span></td>
                </tr>
              </table></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </table></td>
    </tr>
  </table>
  <table width="700" border="0" align="center" cellpadding="0" cellspacing="0" ID="Table1">
    <tr>
      <td align="center"><div align="center" style="position:relative ; padding-top:60px;font-size:14px; font-family: Arial">
          <hr style="height:1; width:600; height:1; color:#CCCCCC" />
          Powered by ROYcms!NT 1.0 (.NET Framework 2.0/3.x)         &nbsp;<br />
          &copy; 2001-2008 ROYcms Inc.</div></td>
    </tr>
  </table>
</form>
</body>
</html>
</body>
</html>
