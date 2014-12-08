<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CMS_config.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.config.CMS_config"  ValidateRequest="false" EnableEventValidation="false" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<head runat="server">
<title></title>
</head>
<body>
<Resources:Resources ID="Resources1" runat="server" />
<link rel="stylesheet" href="/administrator/editor/themes/default/default.css" />
<script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script>
<script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td><a name="1" id="1"></a>
      <table width="100%" border="0" class="tiao_top" >
        <tr>
          <td width="77%" nowrap><div class="tiao_con"> <a href="/administrator/_center.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />系统全局总览</a> <a href="/administrator/config/adminpassword.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />管理员账户配置 </a> <a href="/administrator/config/cms_config.aspx"><img align="absmiddle" src="/administrator/images/nv9.png" />站点配置</a> </div></td>
          <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
        </tr>
      </table>
      <div class="tagMenu">
        <ul class="menu1">
          <li>站点全局设置</li>
          <li>会员中心设置</li>
          <li>支付方式设置</li>
          <li>邮件发送设置</li>
          <li>第三方登录设置</li>
          <li>短信设置</li>
        </ul>
      </div>
      <div class="content1" style="padding:0px; margin-top:2px;">
        <div class="layout">
          <form id="ConfigIndexForm">
            <table   cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
              <tr>
                <td width="16%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 站点域名</strong></td>
                <td width="84%" bgcolor="#F4FBFF"><input name="web_host" type="text" id="web_host"  value='<CMS:WebConfig Name="web_host" runat=server />' />
                  <span style="color:inherit" >例:标准格式 http://www.xx.com/</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 站点名称</strong></td>
                <td bgcolor="#F4FBFF"><input name="web_name" type="text" id="web_name" value='<CMS:WebConfig Name="web_name" runat=server />' /></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 站点首页标题</strong></td>
                <td bgcolor="#F4FBFF"><input type="text" name="title" id="title" value='<CMS:WebConfig Name="title" runat=server />' /></td>
              </tr>
                <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 站点LOGO</strong></td>
                <td bgcolor="#F4FBFF"><input type="text" name="logo" id="logo" value='<CMS:WebConfig Name="logo" runat=server />' />
                  <a id="logoClick" href="#" class="btnSearch" style="padding:3px;">选择文件</a>
                  </td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 站点首页关键字</strong></td>
                <td bgcolor="#F4FBFF"><input type="text" name="keyword" id="keyword" value='<CMS:WebConfig Name="keyword" runat=server />' />
                  多个以分号隔开</td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 站点首页描述</strong></td>
                <td bgcolor="#F4FBFF">
                <textarea name="description" id="description" cols="65" rows="3"><CMS:WebConfig Name="description" runat=server /></textarea></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 网站版权信息<br />
                </strong></td>
                <td bgcolor="#F4FBFF">
                <textarea name="copyright" id="copyright" cols="65" rows="3"><CMS:WebConfig Name="copyright" runat=server /></textarea></td>
              </tr>
            </table>
            <h3 style=" margin-top:5px; margin-bottom:5px;">高级选项 </h3>
            <table  cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 模版编码</strong></td>
                <td bgcolor="#F4FBFF"><select name="templet_language" id="templet_language">
                    <option value="UTF-8">UTF-8 统一编码集</option>
                    <option value="GB2312">GB2312 中文编码</option>
                  </select>
                  <span style="color:inherit" >例:默认utf-8请慎重修改</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 模版主目录</strong></td>
                <td bgcolor="#F4FBFF"><input name="templet_root" type="text" id="templet_root" value='<CMS:WebConfig Name="templet_root" runat=server />' />
                  <span style="color:inherit" >例:模板的存放目录默认/app_templet/请慎重修改</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 当前模版组文件夹</strong></td>
                <td bgcolor="#F4FBFF"><input name="templet_file" type="text" id="templet_file" value='<CMS:WebConfig Name="templet_file" runat=server />' /></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 数据库类型</strong></td>
                <td bgcolor="#F4FBFF"><select name="date_type" id="date_type">
                    <option value="Sql">SQL Server 数据库</option>
                    <option value="SQLite">SQLite 小型数据库</option>
                    <option value="MySqL">MySqL 数据库</option>
                  </select></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>数据库连接加密</strong></td>
                <td bgcolor="#F4FBFF"><select name="constringencrypt" id="constringencrypt">
                    <option value="true">是</option>
                    <option value="false">否</option>
                  </select></td>
              </tr>
              <tr>
                <td width="16%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>数据库前缀</strong></td>
                <td width="84%" bgcolor="#F4FBFF"><input name="date_prefix" type="text" id="date_prefix" value='<CMS:WebConfig Name="date_prefix" runat=server />' />
                  <span style="color:inherit" >例:默认ROYcms_</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>是否启用静态浏览 </strong></td>
                <td bgcolor="#F4FBFF"><select name="html" id="html">
                    <option value="true">是</option>
                    <option value="false">否</option>
                  </select>
               
                  <span style="color:inherit" >例:默认否请慎重操作</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>页面是否执行ZIP压缩</strong></td>
                <td bgcolor="#F4FBFF"><select name="html_zip" id="html_zip">
                    <option value="true">是</option>
                    <option value="false">否</option>
                  </select>
                  <span style="color:inherit" >例:默认网页输出不进行压缩</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 静态生成文件扩展名</strong></td>
                <td bgcolor="#F4FBFF"><input name="web_forge" type="text" id="web_forge"  value='<CMS:WebConfig Name="web_forge" runat=server />' />
                  <span style="color:inherit" >例:标准格式 .html 或 htm</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 页面URL重写模式</strong></td>
                <td bgcolor="#F4FBFF"><input name="new_url_model" type="text" id="new_url_model"  value='<CMS:WebConfig Name="new_url_model" runat=server />' />
                  <span style="color:inherit" >例:/show_123.html这里指的就是"show"</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong> 上传文件目录</strong></td>
                <td bgcolor="#F4FBFF"><input name="upload_path" type="text" id="upload_path"  value='<CMS:WebConfig Name="upload_path" runat=server />' />
                  <span style="color:inherit" >例:标准格式 /app_pic/ 默认请慎重修改</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>文件管理器默认主目录</strong></td>
                <td bgcolor="#F4FBFF"><input name="filemanager_root" type="text" id="filemanager_root" value='<CMS:WebConfig Name="filemanager_root" runat=server />' /></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>扩展名文件</strong></td>
                <td bgcolor="#F4FBFF"><input name="filemanager_file_type" type="text" id="filemanager_file_type" value='<CMS:WebConfig Name="filemanager_file_type" runat=server />' />
                  <span style="color:inherit" >例:管理器允许在线编辑的允许编辑的文件用逗号隔开</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>站点唯一标识GUID</strong></td>
                <td bgcolor="#F4FBFF"><input name="guid" type="text" id="guid" value='<CMS:WebConfig Name="guid" runat=server />' readonly="readonly" />
                  <span style="color:inherit" >例:站群对接作为站点唯一标识</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>站点物理路径</strong></td>
                <td bgcolor="#F4FBFF"><input name="root" type="text" id="root" value='<CMS:WebConfig Name="root" runat=server />' />
                  <span style="color:inherit" >例:默认读取系统路径</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>系统版本</strong></td>
                <td bgcolor="#F4FBFF"><input name="version" type="text" id="version" value='<CMS:WebConfig Name="version" runat=server />' readonly="readonly" />
                  <span style="color:inherit" >例:自动读取dll版本</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>更新升级服务器地址</strong></td>
                <td bgcolor="#F4FBFF"><select name="update_server" id="update_server">
                    <option value="http://www.roycms.cn/" selected>http://www.roycms.cn[服务器1]</option>
                    <option value="http://update.roycms.cn/">http://update.roycms.cn[服务器2]</option>
                  </select></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>是否开启全局错误</strong></td>
                <td bgcolor="#F4FBFF"><select name="err_k" id="err_k">
                    <option value="true">是</option>
                    <option value="false">否</option>
                  </select>
                  <span style="color:inherit" >例:默认开启</span></td>
              </tr>
              <tr>
                <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>是否记录错误报告</strong></td>
                <td bgcolor="#F4FBFF"><select name="error" id="error">
                    <option value="true">是</option>
                    <option value="false">否</option>
                  </select>
                  <span style="color:inherit" >例:默认开启</span></td>
              </tr>
            </table>
            <div style="margin-top:5px;">
              <input name="config" type="hidden" id="config1" value="Index.config">
              <input type="button" name="ConfigIndexBT" id="ConfigIndexBT" value="确认保存"  style="width:100px;" class="btnSubmit" >
              <input type="reset" name="btNO" id="button21" value="重置"  style="width:100px;" class="btnSubmit" >
            </div>
          </form>
        </div>
        <div class="layout">
        
          <form id="ConfigUcenterForm">
          <table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
            <tr>
              <td width="16%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>登录成功后转到的地址</strong></td>
              <td width="84%" bgcolor="#F4FBFF"><input name="login_success_url" type="text" id="login_success_url" value='<CMS:WebConfig Name="login_success_url" Config="Ucenter.config" runat=server />' />
                <span style="color:inherit" >例:默认/为根目录</span></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>主站点用户中心站地址</strong></td>
              <td bgcolor="#F4FBFF"><input name="ucenter_webserver" type="text" id="ucenter_webserver" value='<CMS:WebConfig Name="ucenter_webserver" Config="Ucenter.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>用户中心LOGO</strong></td>
              <td bgcolor="#F4FBFF"><input type="text" name="ucenter_logo" id="ucenter_logo" value='<CMS:WebConfig Name="ucenter_logo" Config="Ucenter.config" runat=server />' />
              <a id="ucenter_logoClick" href="#" class="btnSearch" style="padding:3px;">选择文件</a>
                <span style="color:inherit" >例:默认尺寸 220*80</span></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>用户中心菜单扩展</strong></td>
              <td bgcolor="#F4FBFF"><textarea name="ucenter_menu" id="ucenter_menu" cols="60" rows="5"><CMS:WebConfig Name="ucenter_menu" Config="Ucenter.config" runat=server />
</textarea></td>
            </tr>
          </table>
          <div style="margin-top:5px;">
              <input name="config" type="hidden" id="config2" value="Ucenter.config">
              <input type="button" name="ConfigUcenterBT" id="ConfigUcenterBT" value="确认保存"  style="width:100px;" class="btnSubmit" >
              <input type="reset" name="button2" id="button211" value="重置"  style="width:100px;" class="btnSubmit" >
          </div>
          
          </form>
          
        </div>
        <div class="layout">
        <form id="ConfigPayForm">
          <table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
            <tr>
              <td width="20%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>快钱支付网关账号(MerchantAcctID)</strong></td>
              <td width="80%" bgcolor="#F4FBFF"><input name="merchantacct_id" type="text" id="Text1" value='<CMS:WebConfig Name="merchantacct_id" Config="pay.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>快钱支付人民币网关密钥</strong></td>
              <td bgcolor="#F4FBFF"><input name="merchantacct_key" type="text" id="Text2" value='<CMS:WebConfig Name="merchantacct_key" Config="pay.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>支付宝账户</strong></td>
              <td bgcolor="#F4FBFF"><input name="zhifubao_id" type="text" id="zhifubao_id" value='<CMS:WebConfig Name="zhifubao_id" Config="pay.config" runat=server />' /></td>
            </tr>
               <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>支付宝Pid</strong></td>
              <td bgcolor="#F4FBFF"><input name="zhifubao_pid" type="text" id="zhifubao_Pid" value='<CMS:WebConfig Name="zhifubao_pid" Config="pay.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>支付宝Key</strong></td>
              <td bgcolor="#F4FBFF"><input name="zhifubao_key" type="text" id="zhifubao_key" value='<CMS:WebConfig Name="zhifubao_key" Config="pay.config" runat=server />' /></td>
            </tr>
          </table>
          <div style="margin-top:5px;">
              <input name="config" type="hidden" id="config3" value="Pay.config">
              <input type="button" name="ConfigPayBT" id="ConfigPayBT" value="确认保存"  style="width:100px;" class="btnSubmit" >
              <input type="reset" name="button2" id="button2" value="重置"  style="width:100px;" class="btnSubmit" >
          </div>
          </form>
        </div>
        <div class="layout">
         <form id="ConfigEmailForm">
          <table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
            <tr>
              <td width="14%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>发送邮件地址</strong></td>
              <td width="86%" bgcolor="#F4FBFF"><input type="text" name="sendmail_path" id="sendmail_path" value='<CMS:WebConfig Name="sendmail_path" Config="email.config" runat=server />' />
                <span style="color:inherit" >例:邮件服务器地址支持POP3</span></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>邮件密码</strong></td>
              <td bgcolor="#F4FBFF"><input type="text" name="sendmail_password" id="sendmail_password" value='<CMS:WebConfig Name="sendmail_password" Config="email.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>发邮件服务器地址</strong></td>
              <td bgcolor="#F4FBFF"><input name="sendmail_host" type="text" id="sendmail_host" value='<CMS:WebConfig Name="sendmail_host" Config="email.config" runat=server />' /></td>
            </tr>
          </table>
          <div style="margin-top:5px;">
              <input name="config" type="hidden" id="config4" value="Email.config">
              <input type="button" name="ConfigEmailBT" id="ConfigEmailBT" value="确认保存"  style="width:100px;" class="btnSubmit" >
              <input type="reset" name="button2" id="button2" value="重置"  style="width:100px;" class="btnSubmit" >
          </div>
          </form>
        </div>
        <div class="layout">
        
          <form id="ConfigOAuthForm">
          <table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
            <tr>
              <td width="14%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>QQ登录api</strong></td>
              <td width="86%" bgcolor="#F4FBFF"><input name="qq_api" type="text" id="qq_api" value='<CMS:WebConfig Name="qq_api" Config="OAuth.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>QQ登录密钥</strong></td>
              <td bgcolor="#F4FBFF"><input name="qq_key" type="text" id="qq_key" value='<CMS:WebConfig Name="qq_key" Config="OAuth.config" runat=server />' /></td>
            </tr>
             <tr>
              <td width="14%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>新浪微博api</strong></td>
              <td width="86%" bgcolor="#F4FBFF"><input name="qq_api" type="text" id="qq_api" value='<CMS:WebConfig Name="qq_api" Config="OAuth.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>新浪微博密钥</strong></td>
              <td bgcolor="#F4FBFF"><input name="qq_key" type="text" id="qq_key" value='<CMS:WebConfig Name="qq_key" Config="OAuth.config" runat=server />' /></td>
            </tr>
             <tr>
              <td width="14%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>人人网登录api</strong></td>
              <td width="86%" bgcolor="#F4FBFF"><input name="qq_api" type="text" id="qq_api" value='<CMS:WebConfig Name="qq_api" Config="OAuth.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>人人网登录密钥</strong></td>
              <td bgcolor="#F4FBFF"><input name="qq_key" type="text" id="qq_key" value='<CMS:WebConfig Name="qq_key" Config="OAuth.config" runat=server />' /></td>
            </tr>
             <tr>
              <td width="14%" align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>开心网登录api</strong></td>
              <td width="86%" bgcolor="#F4FBFF"><input name="qq_api" type="text" id="qq_api" value='<CMS:WebConfig Name="qq_api" Config="OAuth.config" runat=server />' /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>开心网登录密钥</strong></td>
              <td bgcolor="#F4FBFF"><input name="qq_key" type="text" id="qq_key" value='<CMS:WebConfig Name="qq_key" Config="OAuth.config" runat=server />' /></td>
            </tr>
          </table>
          <div style="margin-top:5px;">
              <input name="config" type="hidden" id="config2" value="OAuth.config">
              <input type="button" name="ConfigOAuthBT" id="ConfigOAuthBT" value="确认保存"  style="width:100px;" class="btnSubmit" >
              <input type="reset" name="button2" id="button2" value="重置"  style="width:100px;" class="btnSubmit" >
          </div>
          
          </form>
        </div>
        <div class="layout">短信设置 </div>
      </div></td>
  </tr>
</table>
<script language="JavaScript">

<!--
    $("input").addClass("txtInput");
    $("input").width(280);
    $("select").addClass("select");
    $("select").width(160);


for (i=0;i<$("#templet_language option").length;i++)
{ 
     if($("#templet_language option").eq(i).val()=="<CMS:WebConfig Name='templet_language' runat=server />")
     {
		 $("#templet_language option").eq(i).attr('selected','selected');break;
     }
}
for (i=0;i<$("#date_type option").length;i++)
{ 
     if($("#date_type option").eq(i).val()=="<CMS:WebConfig Name='date_type' runat=server />")
     {
		 $("#date_type option").eq(i).attr('selected','selected');break;
     }
}

for (i=0;i<$("#constringencrypt option").length;i++)
{ 
     if($("#constringencrypt option").eq(i).val()=="<CMS:WebConfig Name='constringencrypt' runat=server />")
     {
		 $("#constringencrypt option").eq(i).attr('selected','selected');break;
     }
}
for (i=0;i<$("#html_zip option").length;i++)
{ 
     if($("#html_zip option").eq(i).val()=="<CMS:WebConfig Name='html_zip' runat=server />")
     {
		 $("#html_zip option").eq(i).attr('selected','selected');break;
     }
}
for (i=0;i<$("#html option").length;i++)
{ 
     if($("#html option").eq(i).val()=="<CMS:WebConfig Name='html' runat=server />")
     {
		 $("#html option").eq(i).attr('selected','selected');break;
     }
}
for (i=0;i<$("#error option").length;i++)
{ 
     if($("#error option").eq(i).val()=="<CMS:WebConfig Name='error' runat=server />")
     {
		 $("#error option").eq(i).attr('selected','selected');break;
     }
}
for (i=0;i<$("#err_k option").length;i++)
{ 
     if($("#err_k option").eq(i).val()=="<CMS:WebConfig Name='err_k' runat=server />")
     {
		 $("#err_k option").eq(i).attr('selected','selected');break;
     }
}
//-->
</script> 

     <script>
			                       			KindEditor.ready(function(K) {
				                            var editor = K.editor({
					                              cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                                    uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=Config,All',
				                                    fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=Config,All',
				                                    allowFileManager : true 
				                            });
											
				                            K('#logoClick').click(function() {
					                            editor.loadPlugin('image', function() {
						                            editor.plugin.imageDialog({
							                            imageUrl : K('#logo').val(),
							                            clickFn : function(url, title, width, height, border, align) {
								                            K('#logo').val(url);
								                            editor.hideDialog();
							                            }
						                            });
					                            });
				                            });
											
											 K('#ucenter_logoClick').click(function() {
					                            editor.loadPlugin('image', function() {
						                            editor.plugin.imageDialog({
							                            imageUrl : K('#ucenter_logo').val(),
							                            clickFn : function(url, title, width, height, border, align) {
								                            K('#ucenter_logo').val(url);
								                            editor.hideDialog();
							                            }
						                            });
					                            });
				                            });
											
											
											
                                        });
		                        </script>
</body>
</html>
