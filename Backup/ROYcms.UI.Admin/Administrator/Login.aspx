<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_login_index"  %>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title><CMS:WebConfig Name="web_name" runat=server /> 网站后台协作平台 - ROYcms!NT</title>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body scroll="no">
<script language="JavaScript"  src="/administrator/js/alt.js"></script>
<table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
  <form name="form1" method="post" runat="server">
    <tr>
      <td align="center" valign="middle"><table width="400" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFFFFF">
          <tr>
            <td height="28" align="center" background="/administrator/images/login-1.gif"><table width="96%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td class="enfont"><font color="#FFFFFF">ROYcms <font color="#FFFF00">ver<CMS:WebConfig Name="version" runat=server /></font></font></td>
                  <td align="right" class="enfont"><a href="javascript:window.opener=null;window.close()"><img src="/administrator/images/login-quit.gif" width="7" height="6" border="0"></a></td>
                </tr>
              </table></td>
          </tr>
          <tr>
            <td height="92"><img src="/administrator/images/login-g.gif" width="450" height="109" border="0" usemap="#Map"></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0" >
                <tr>
                  <td width="17" background="/administrator/images/login-2.gif">&nbsp;</td>
                  <td height="80" align="center"><table border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td width="60" height="30"  style=" font-size:12px;">管理帐号： <br></td>
                        <td><table border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="3"><img src="/administrator/images/in1.gif" width="3" height="19"></td>
                              <td width="100">
                              <asp:TextBox ID="username" runat="server" CssClass="input2"></asp:TextBox>
                              </td>
                              <td width="3"><img src="/administrator/images/in2.gif" width="3" height="19"></td>
                            </tr>
                          </table></td>
                        <td style=" font-size:12px; padding-left:4px;">
                       <label><input name="cooks" type="checkbox" id="cooks" checked style=" vertical-align:middle;">记住身份</label></td>
                      </tr>
                      <tr>
                        <td height="30" style=" font-size:12px;">管理密码：</td>
                        <td><table border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="3"><img src="/administrator/images/in1.gif" width="3" height="19"></td>
                              <td width="100">
                                  <asp:TextBox ID="password" TextMode="Password" CssClass="input2" runat="server"></asp:TextBox>
                              </td>
                              <td width="3"><img src="/administrator/images/in2.gif" width="3" height="19"></td>
                            </tr>
                          </table></td>
                        <td align="right"><table width="52" border="0" align="center" cellpadding="0" cellspacing="0">
                            <tr>
                              <td align="right">
                                  <asp:ImageButton ID="AdminLogin" ImageUrl="/administrator/images/login-bt.gif" 
                                      runat="server" onclick="AdminLogin_Click" />
                                 </td>
                            </tr>
                          </table></td>
                      </tr>
                    </table></td>
                  <td width="17" background="/administrator/images/login-3.gif">&nbsp;</td>
                </tr>
                <tr>
                  <td height="22" background="/administrator/images/login-4.gif">&nbsp;</td>
                  <td background="/administrator/images/login-6.gif">&nbsp;</td>
                  <td background="/administrator/images/login-5.gif">&nbsp;</td>
                </tr>
              </table></td>
          </tr>
        </table></td>
    </tr>
  </form>
</table>

<map name="Map">
  <area shape="rect" coords="279,71,403,86" href="http://www.roycms.cn" target="_blank" alt="http://www.roycms.cn">
  <area shape="rect" coords="102,34,111,42" alt="杜耀辉">
</map>
</body>
</html>
