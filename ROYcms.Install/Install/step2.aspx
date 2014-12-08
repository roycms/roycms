<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.Install.Install_step2" Codebehind="step2.aspx.cs" %>
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
                  <td><font color="#ffffff">欢迎安装
                    ROYcms!NT 2.0 (.NET Framework 2.0/3.x) </font></td>
                </tr>
              </table></td>
          </tr>
          <tr>
            <td width="180" valign="top"><img src="images/logo.jpg" width="180" height="300"></td>
            <td width="520" valign="top">
              <table id="Table2" cellspacing="1" cellpadding="1" width="90%" align="center" border="0">
                <tr>
                  <td height="51" align="center"><h2  style="font-family:微软雅黑;"> 欢迎您安装 ROYcms!NT 2.0 <span style="font-size:12px; color:#999">(.NET Framework 2.0/3.x)</span> </h2></td>
                </tr> 
                <tr>
                  <td height="79"><table width="100%" border="0" cellspacing="0" cellpadding="5">
                     
                      <tr>
                        <td width="17%" nowrap="nowrap"><span class="rowName">数据库类型</span></td>
                        <td width="83%" nowrap="nowrap"><span class="row">SQL2000或者SQL2005 
                           
                            </span></td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap"><span class="rowName">服务器</span></td>
                        <td nowrap="nowrap"><span class="row">
                          <asp:TextBox runat="server" CssClass="textBox" ID="DBServerIP"></asp:TextBox>
                          <span class="rowName">是否创建数据库</span>
                          <asp:RadioButton runat="server" GroupName="DBCreate" ID="NotCreated" />
                          是
                          <asp:RadioButton runat="server" GroupName="DBCreate" ID="DBCreated" />
                          否</span></td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap"><span class="rowName">数据库名称</span></td>
                        <td nowrap="nowrap"><span class="row">
                          <asp:TextBox runat="server" CssClass="textBox" ID="DBName"></asp:TextBox>
                          <span>
                          <img src="images/ok.gif" width="20" height="20" />
                          <asp:RequiredFieldValidator ID="RequiredDBName" runat="server" validationgroup="InstallGroup"
                                CssClass="errorHint" ControlToValidate="DBName" ErrorMessage="请填写数据库名称"></asp:RequiredFieldValidator>
                          </span></span></td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap"><span class="rowName">数据库用户帐号</span></td>
                        <td nowrap="nowrap"><span class="row">
                          <asp:TextBox runat="server" CssClass="textBox" ID="DBOwner"></asp:TextBox>
                          <img src="images/ok.gif" width="20" height="20" /><span>
                          <asp:RequiredFieldValidator ID="RequiredDBOwner" runat="server" validationgroup="InstallGroup"
                                CssClass="errorHint" ControlToValidate="DBOwner" ErrorMessage="请填写数据库用户帐号"></asp:RequiredFieldValidator>
                          </span></span></td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap"><span class="rowName">数据库用户密码</span></td>
                        <td nowrap="nowrap"><span class="row">
                          <asp:TextBox runat="server" CssClass="textBox" ID="DBOwenerPassWord"></asp:TextBox>
                          <img src="images/ok.gif" width="20" height="20" /><span>
                          <asp:RequiredFieldValidator ID="RequiredDBOwenerPassWord" runat="server" validationgroup="InstallGroup"
                                CssClass="errorHint" ControlToValidate="DBOwenerPassWord" ErrorMessage="请填写数据帐户密码"></asp:RequiredFieldValidator>
                          </span></span></td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap"><span class="rowName">站点管理员账号</span></td>
                        <td nowrap="nowrap">admin</td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap"><span class="rowName">站点管理员密码</span></td>
                        <td nowrap="nowrap"><span class="row">
                          <asp:TextBox runat="server" CssClass="textBox" ToolTip="此帐号用户将成为创建站点的最高管理员" ID="SiteAdminPassword"></asp:TextBox>
                          <span>
                          <img src="images/ok.gif" width="20" height="20" /> 
                          <asp:RequiredFieldValidator ID="RequiredSiteAdminPassword" runat="server" ControlToValidate="SiteAdminPassword"
                                CssClass="errorHint" validationgroup="InstallGroup" ErrorMessage="请填写管理员密码"></asp:RequiredFieldValidator>
                          </span></span></td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap">&nbsp;</td>
                        <td nowrap="nowrap">此步骤需要时间较长，请耐心等待！执行成功后将自动跳转</td>
                      </tr>
                      <tr>
                        <td nowrap="nowrap">&nbsp;</td>
                        <td nowrap="nowrap"><span class="error">
                          <asp:Literal runat="server" ID="Errors"></asp:Literal>
                          </span></td>
                      </tr>
                    </table>
                    <div id="commonDoc">
                      <div id="commonContent">
                        <div class="slider third">
                          <div class="sliderLeft"></div>
                          <div class="sliderArrow"></div>
                          <div class="sliderRight"></div>
                        </div>
                        <div class="stepButton">
                          <div class="stepButtonWrap">
                            <div class="stepButtonLeft"></div>
                            <div class="stepButtonCenter"></div>
                            <div class="stepButtonRight"></div>
                          </div>
                        </div>
                      </div>
                    </div></td>
                </tr>
              </table>
              <p>
              </p></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td><table width="90%" border="0" cellspacing="0" cellpadding="8">
                <tr>
                  <td width="59%" align="right">&nbsp;</td>
                  <td width="41%" align="right"><asp:LinkButton runat="server" validationgroup="InstallGroup" ID="InstallNow">开始安装</asp:LinkButton>
                    <asp:Button ID="Button1" runat="server" Text="转到网站" Height="30px" Visible="False"  Width="88px" /></td>
                </tr>
              </table></td>
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
<!--$.ajax({
  url: "step3.aspx",
  cache: false,
  success: function(html){
    $("#success").append(html);
  }
}); -->