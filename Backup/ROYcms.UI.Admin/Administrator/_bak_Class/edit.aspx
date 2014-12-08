<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.class_edit"  ValidateRequest="false" EnableEventValidation="false"  %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>    
<html>
<head id="Head1" runat="server">
<title></title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
            <script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script>
        <script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
        
  <!--工具栏开始-->
  <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> 
        <a href='/administrator/class/index.aspx?Classkind=<%=Request["ClassKind"] %>'><img align="absmiddle" src="/administrator/images/nv9.png" />返回栏目</a> 
       
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
   <!--工具栏结束-->

    <div class="tagMenu">
          <ul class="menu1">

            <li>基本选项</li>
            <li>高级选项</li>
            <li>栏目内容</li>
            <li>栏目扩展信息</li>
           
          </ul>
        </div>
    <div class="content1" style="padding:0px;">
          <div class="layout">

<table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
	<tr>
	  <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
	    栏目名称
	    </td>
	  <td width="91%" height="25" align="left" bgcolor="#F4FBFF">
	    <asp:TextBox CssClass="input" id="txtClassName" name="txtClassName" runat="server" Width="200px" ></asp:TextBox>
	    </td></tr>
	<tr>
	  <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
	    内容模型
	    </td>
	  <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input type='radio' name='txtListType' value='1' class='np' checked='1' />
文章
<input type='radio' name='txtListType' value='0' class='np'/>
图片</td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		文件路径
	</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtFilePath" name="txtFilePath" runat="server" Width="326px"></asp:TextBox>
	&nbsp;
	
	<a href="javascript:" id="ClassName_PinYin">使用拼音</a>
                
                <script>
                 $("#ClassName_PinYin").click(function(){
					 $("#txtFilePath").val("{cmspath}/" +MyPinYin($("#txtClassName").val()+"/")); 
					 })      
                 </script>
	
	</td></tr>
	<tr>
	  <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
	    栏目列表选项</td>
	  <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input type='radio' name='txtGoType' value='1' class='np' checked='1' />
	    链接到默认页
  <input type='radio' name='txtGoType' value='0' class='np'/>
	    链接到列表第一页
  <input type='radio' name='txtGoType' value='-1' class='np'/>
	    使用动态页 </td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		默认页面地址
	</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtDefaultFile" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		栏目类型</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
          <asp:RadioButtonList ID="txtColumnsType" runat="server">
            <asp:ListItem Value="0" Selected="True">最终列表栏目（允许在本栏目发布文档，并生成文档列表）</asp:ListItem>
            <asp:ListItem Value="1">频道封面（栏目本身不允许发布文档）</asp:ListItem>
            <asp:ListItem Value="2">外部连接（在&quot;文件保存目录&quot;处填写网址）</asp:ListItem>
        </asp:RadioButtonList>
                      </td></tr>
	<tr>
	  <td height="25" bgcolor="#F4FBFF"></td>
	  <td height="25" bgcolor="#F4FBFF"><asp:Button CssClass="bt" ID="Button_btnEdit1" 
              runat="server" Text=" 确认编辑 " OnClick="btnEdit_Click" ></asp:Button>&nbsp;
          <asp:Button CssClass="bt" ID="Button1" runat="server" PostBackUrl="index.aspx" Text=" 返回 "></asp:Button>
        </td>
	  </tr>
</table>

 
	<tr>
	<td height="25" colspan="2"><div align="center"></div></td></tr>
</table>

    
          </div>
          <div class="layout">
              <table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
	<td width="9%" height="12" align="right" bgcolor="#F4FBFF">&nbsp;</td>
	<td width="91%" height="12" align="left" bgcolor="#F4FBFF">说明：绑名绑定仅需要在顶级栏目设定，子级栏目更改无效。</td></tr>
	<tr>
	  <td height="12" align="right" nowrap bgcolor="#F4FBFF">绑定地址/域名 </td>
	  <td width="91%" height="12" align="left" bgcolor="#F4FBFF"><asp:TextBox CssClass="input" ID="txtWebsiteUrl" runat="server" Width="320px"></asp:TextBox>
(例：w.roycms.cn 不包含 http://，一级或二级域名的根网址) </td>
	  </tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		封面模板
	</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtTemplateIndex" runat="server" Width="360px"></asp:TextBox>
		<span class="bt"> &nbsp;
		
		 <a rel="facebox" title="选择封面模板文件" href='../iframe.aspx?width=640&height=400&url=/administrator/FileManager/template_Default.aspx?id=1'><img src="/administrator/images/eye.png" alt="" name="" width="16" height="16" border="0" /> 浏览...&nbsp;</a>
        </span></td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">列表模板</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtTemplateList" runat="server" Width="360px"></asp:TextBox>
		<span class="bt"> &nbsp;
		 <a rel="facebox" title="选择封面模板文件" href='../iframe.aspx?width=640&height=400&url=/administrator/FileManager/template_Default.aspx?id=1'><img src="/administrator/images/eye.png" alt="" name="" width="16" height="16" border="0" /> 浏览...&nbsp;</a>
		</span></td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		文章模板
	</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtTemplateShow" runat="server" Width="360px"></asp:TextBox>
		<span class="bt"> &nbsp;
		 <a rel="facebox" title="选择封面模板文件" href='../iframe.aspx?width=640&height=400&url=/administrator/FileManager/template_Default.aspx?id=1'><img src="/administrator/images/eye.png" alt="" name="" width="16" height="16" border="0" /> 浏览...&nbsp;</a>
		</span></td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		列表命名规则
	</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtListeRules" runat="server" Width="320px"></asp:TextBox>
		<a href="#help1"  rel="facebox" title="列表命名规则"><img src="/administrator/images/layers.png" alt="" name="" width="16" height="16" border="0" /> Help?</a>
        <div id="help1" style="display:none">列表命名规则 请慎重修改 {class} 代表栏目的标识ID {page}代表列表分页的页码</div>
        
        </td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		文章命名规则
	</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" id="txtShowRules" runat="server" Width="320px"></asp:TextBox>
		
        <a href="#help2"  rel="facebox"  title="文章命名规则"><img src="/administrator/images/layers.png" alt="" name="" width="16" height="16" border="0" /> Help?</a>
        <div id="help2" style="display:none">命名规则 请慎重修改 {yyyy}/{MM}/{dd}/{id} 代表时间格式 {id}代表内容的标识ID </div>
        
        </td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		关键字</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" Height="48px" id="txtkeyword" runat="server" TextMode="MultiLine" 
            Width="500px"></asp:TextBox>
	</td></tr>
	<tr>
	<td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF">
		栏目描述</td>
	<td width="91%" height="25" align="left" bgcolor="#F4FBFF">
		<asp:TextBox CssClass="input" Height="72px" id="txtDescription" runat="server" 
            TextMode="MultiLine" Width="500px"></asp:TextBox>
	</td></tr>
	<tr>
	  <td height="25" bgcolor="#F4FBFF"></td>
	  <td height="25" bgcolor="#F4FBFF"><asp:Button CssClass="bt" ID="Button_btnEdit2" runat="server" Text=" 确认编辑 " OnClick="btnEdit_Click" ></asp:Button>&nbsp;
	  <asp:Button CssClass="bt" ID="Button2" runat="server" PostBackUrl="index.aspx" Text=" 返回 "></asp:Button></td>
	  </tr>
</table>
          
          </div>
          <div class="layout">
        <script>
                        var editor;
                        KindEditor.ready(function(K) {
                                editor = K.create('#Content',{				
                                cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=ClassFile,<%=Request["ClassKind"] %>',
				                fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=ClassFile,<%=Request["ClassKind"] %>',
				                autoHeightMode : true,
				                allowFileManager : true 
				                });
                        });
              </script>
                <textarea class'REditor' id="Content" name="Content" style="width:100%;height:360px;"></textarea>
          
          <br>
          <asp:Button CssClass="bt" ID="Button_btnEdit3"  runat="server" Text=" 确认编辑 " OnClick="btnEdit_Click" >    
          </asp:Button>&nbsp;<asp:Button CssClass="bt" ID="Button5" runat="server" PostBackUrl="index.aspx" Text=" 返回 "></asp:Button>
   
        
          </div>  
          
          <div class="layout">
          
       

      
          </div>
          </div>


</form>
</body>
</html>

