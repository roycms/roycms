<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Class.Insert" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="ClassInsertForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script> 
  <script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
  <div id="rotate"> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> <a href='/administrator/class/index.aspx?Classkind=<%=Request["ClassKind"] %>'><img align="absmiddle" src="/administrator/images/nv9.png" />返回频道</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>基本选项</li>
        <li>模板/SEO选项</li>
        <li>频道内容</li>
        <%if (ROYcms.Common.Request.GetQueryInt("Id") != 0)
          { %>
        <li>频道数据模型配置</li>
        <li>频道访问权限配置</li>
       
        <%} %>
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">
        <table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 频道名称 </strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF">
              <input name="Id" type="hidden" id="Id" value='<%=ROYcms.Common.Request.GetQueryInt("Id")%>' />
              <input type="hidden" name="ClassId" id="ClassId" value='<%=ROYcms.Common.Request.GetQueryString("ClassId")%>' />
              <input type="hidden" name="classkind" id="classkind" value='<%=ROYcms.Common.Request.GetQueryInt("classkind")%>' />
              <input type="hidden" name="classPre" id="classPre" value='<%=ROYcms.Common.Request.GetQueryString("classPre")%>' />
              <input name="ClassName" type="text" class="txtInput" id="ClassName" size="30" />
              </td>
          </tr>
        <!--
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"> 内容模型 </td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF">
            <label><input type='radio' name='ListType' value='1' class='np' checked='1' /> 文章</label>
            <label><input type='radio' name='ListType' value='0' class='np'/>图片</label> 
            <a> 更多...</a></td>
          </tr> 
          -->
           <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 频道列表选项</strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF">
              <label><input type='radio' name='GoType' value='1' class='np' checked='1' style="vertical-align:middle;" /> 链接到默认页</label>
              <label><input type='radio' name='GoType' value='0' class='np' style="vertical-align:middle;" /> 链接到列表第一页</label>
              <label><input type='radio' name='GoType' value='-1' class='np' style="vertical-align:middle;" /> 使用动态页</label> 
              </td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 文件保存目录 </strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF">
            <input name="FilePath" type="text" class="txtInput" id="FilePath" size="30" />
            <a href="javascript:" id="ClassName_PinYin">使用拼音</a> 
            <script>
                 $("#ClassName_PinYin").click(function(){
                     $("#FilePath").val("{cmspath}/" + $("#ClassName").toPinyin() + "/"); 
					 })      
                 </script></td>
          </tr>
         
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 默认页面 </strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input type="text" name="DefaultFile" id="DefaultFile" class="txtInput" /></td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 频道类型</strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"> 
             <label>
                <input name="ColumnsType" type="radio" id="ColumnsType_0" value="0" checked="checked" style="vertical-align:middle;" />
                频道封面（允许在本频道发布文章）</label>
              <br />
              <label>
                <input type="radio" name="ColumnsType" value="1" id="ColumnsType_1" style="vertical-align:middle;" />
                最终列表频道（允许在本频道发布文章，并生成文章列表）</label>
              <br />
              <label>
                <input type="radio" name="ColumnsType" value="2" id="ColumnsType_2" style="vertical-align:middle;" />
                外部连接（在"文件保存目录"处填写网址,频道本身不允许发布文章）</label></td>
          </tr>
         
        </table>
      </div>
      <div class="layout">
        <table cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">

          <tr>
            <td height="12" align="right" nowrap bgcolor="#F4FBFF"><strong>绑定地址/域名 </strong></td>
            <td width="91%" height="12" align="left" bgcolor="#F4FBFF"><input name="WebsiteUrl" type="text" class="txtInput" id="WebsiteUrl" size="40" />
              (例：w.roycms.cn 不包含 http://，一级或二级域名的根网址) </td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 封面模板 </strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input name="TemplateIndex" type="text" class="txtInput" id="TemplateIndex" size="40" />
             <a rel="facebox" class="btnSearch" style="padding:2px;" title="选择封面模板文件" href='../iframe.aspx?width=640&height=400&url=/administrator/FileManager/template_Default.aspx?id=1'>选择模板</a>
              <a id="JCTemplateIndex" class="btnSearch" style="padding:2px; display:none" href='' target="_blank">检测模板</a>
             </td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong>列表模板</strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input name="TemplateList" type="text" class="txtInput" id="TemplateList" size="40" />
              <a rel="facebox" class="btnSearch" style="padding:2px;" title="选择封面模板文件" href='../iframe.aspx?width=640&height=400&url=/administrator/FileManager/template_Default.aspx?id=2' >选择模板</a>
              <a id="JCTemplateList" class="btnSearch" style="padding:2px; display:none" href='' target="_blank">检测模板</a>
             </td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 文章模板 </strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input name="TemplateShow" type="text" class="txtInput" id="TemplateShow" size="40" />
            <a rel="facebox" class="btnSearch" style="padding:2px;" title="选择封面模板文件" href='../iframe.aspx?width=640&height=400&url=/administrator/FileManager/template_Default.aspx?id=3' >选择模板</a>
            <a id="JCTemplateShow" class="btnSearch" style="padding:2px; display:none" href='' target="_blank">检测模板</a>
            </td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 列表命名规则 </strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input name="ListeRules" type="text" class="txtInput" id="ListeRules" size="40" />
              <a href="#help1"  rel="facebox" title="列表命名规则"><img src="/administrator/images/layers.png" alt="" name="" width="16" height="16" border="0" /> Help?</a>
            <div id="help1" style="display:none">列表命名规则 请慎重修改 {class} 代表频道的标识ID {page}代表列表分页的页码</div></td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 文章命名规则 </strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><input name="ShowRules" type="text" class="txtInput" id="ShowRules" size="40" />
              <a href="#help2"  rel="facebox" title="文章命名规则"><img src="/administrator/images/layers.png" alt="" name="" width="16" height="16" border="0" /> Help?</a>
            <div id="help2" style="display:none">命名规则 请慎重修改 {yyyy}/{MM}/{dd}/{id} 代表时间格式 {id}代表内容的标识ID </div></td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 关键字</strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><label for="keyword"></label>
            <textarea name="keyword" id="keyword" cols="45" rows="2"></textarea></td>
          </tr>
          <tr>
            <td width="9%" height="25" align="right" nowrap bgcolor="#F4FBFF"><strong> 频道描述</strong></td>
            <td width="91%" height="25" align="left" bgcolor="#F4FBFF"><label for="Description"></label>
            <textarea name="Description" id="Description" cols="55" rows="3"></textarea></td>
          </tr>
        </table>
      </div>
      <div class="layout"> 
        <script>
                        var editor;
                        KindEditor.ready(function(K) {
                                editor = K.create('#contents',{				
                                cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=ClassFile,<%=Request["ClassKind"] %>',
				                fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=ClassFile,<%=Request["ClassKind"] %>',
				                autoHeightMode : true,
				                allowFileManager : true 
				                });
                        });
              </script>
        <textarea class='REditor' id="contents" name="contents" style="width:100%;height:360px;">
         <%  = new ROYcms.Sys.BLL.ROYcms_class().GetClassField(Convert.ToInt32(Request["Id"] == null ? "0" : Request["Id"]), "contents")%>
        </textarea>
      </div>
    
    <%if (ROYcms.Common.Request.GetQueryInt("Id") != 0)
      { %>
      
      <div class="layout">
        <div class="Tools2">
         <a class="btnSearch" href="/administrator/model/adminmodel.aspx" style=" padding:4px;">管理数据模型</a>
         <a>当前频道数据扩展模型：
          <%
              string ModelName =null;
              string Modelid = new ROYcms.Sys.BLL.ROYcms_Class_Model().CidGetP("Mid", "Cid=" + Request["Id"]);
              if (Modelid != null)
              { ModelName = new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Modelid)) == null ? "" : new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Modelid)).Name;        
          %> 
          [<%=ModelName  %>]
           <a href="javascript:" id='<%=Request["Id"]%>' class="Class_ModelDelBT btnSearch" style=" padding:4px;">取消关联</a>
          <%}else {%>无关联的扩展模型<%}%>
          </a>
         </div>

           <asp:Repeater ID="Repeater_admin" runat="server">
            <HeaderTemplate>
            <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
            <tr id="tiao_center">
              <td width="38" nowrap><span class="line">编号</span></td>
              <td width="139" ><span class="line">自定义模型名称</span></td>
              <td width="139" ><span class="line">表格名称</span></td>
              <td width="322"><span class="line">自定义模型描述</span></td>
              <td width="139" ><span class="line">初始化状态</span></td>
              <td width="139" ><span class="line"></span></td>
            </tr>
            </HeaderTemplate>
              <ItemTemplate>
                <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
                  <td nowrap="nowrap"><%#Eval("Name")%></td>
                  <td nowrap="nowrap"><%#Eval("TableName")%></td>
                  <td nowrap="nowrap"><%#Eval("ModelDescription")%></td>
                  <td nowrap="nowrap"><%# new ROYcms.Sys.BLL.CMS().Exists(Eval("TableName").ToString())==true?"成功":"未初始化"%></td>
                  <td>
                  <a href="javascript:" id='<%#Eval("Id")%>,<%=Request["Id"]%>' class="Class_ModelBT btnSearch" style=" padding:4px;">应用关联</a>
                  </td> 
                </tr>
              </ItemTemplate>
              <FooterTemplate>
                <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"6\">暂无记录</td></tr>" : ""%>
              </table>
              </FooterTemplate>
            </asp:Repeater>
      </div>

      <div class="layout">
        <div class="Tools2">
        <label class="btnSearch" style="padding:4px;">
         <input type="radio" name="Authority" value="单选" id="Authority0" checked="checked" style="vertical-align:middle;" /> 开放浏览（不要登录信息）</label>
        <label class="btnSearch" style="padding:4px;">
         <input type="radio" name="Authority" value="单选" id="Authority1" style="vertical-align:middle;" /> 指定特定工作组内会员浏览</label>
        <label class="btnSearch" style="padding:4px;">
         <input type="radio" name="Authority" value="单选" id="Authority2" style="vertical-align:middle;" /> 指定特定会员浏览</label>
      </div>
      </div>

          <%} %>
    </div> 
     <div style="margin-left:150px; margin-top:10px;">  
        <input type="button" name="ClassInsertBT" id="ClassInsertBT" value="确认提交"  class="btnSubmit" />
        <input type="reset" name="button2" id="button2" value="重置" class="btnSubmit" />
      </div>
  </div>
</form>
<!--编辑模式下给默认的表单赋值-->  
    
    
           <% 
              ROYcms.Sys.Model.ROYcms_class Model = new ROYcms.Sys.Model.ROYcms_class();
              ROYcms.Sys.BLL.ROYcms_class BLL = new ROYcms.Sys.BLL.ROYcms_class();
               if (Request["Id"] != null)
               {
                   Model = BLL._GetModel(Request["Id"]);
               }
               if (Model != null && Request["Id"] != null)
               {
           %>
               <script type="text/javascript">
                           
                      $("#ClassName").val('<%=Model.ClassName%>'); 
					  $("#FilePath").val('<%=Model.FilePath%>'); 
					  $("#DefaultFile").val('<%=Model.DefaultFile%>'); 
					  $("#WebsiteUrl").val('<%=Model.WebsiteUrl%>');  
					  $("#TemplateIndex").val('<%=Model.TemplateIndex%>'); 
					  $("#TemplateList").val('<%=Model.TemplateList%>'); 
					  $("#TemplateShow").val('<%=Model.TemplateShow%>'); 
					  $("#ListeRules").val('<%=Model.ListeRules%>'); 
					  $("#ShowRules").val('<%=Model.ShowRules%>'); 
					  $("#keyword").val('<%=Model.keyword%>'); 
					  $("#Description").val('<%=Model.Description%>'); 
					  
					  //检测模板
					  $("#JCTemplateIndex").show(); 
					  $("#JCTemplateList").show(); 
					  $("#JCTemplateShow").show(); 
                      $("#JCTemplateIndex").attr("href",'<%=Model.TemplateIndex%>?Type=<%=Request["Id"]%>'); 
					  $("#JCTemplateList").attr("href",'<%=Model.TemplateList%>?Type=<%=Request["Id"]%>&page=1'); 
					  $("#JCTemplateShow").attr("href",'<%=Model.TemplateShow%>?Type=<%=Request["Id"]%>&Id=3'); 
                               
               </script>
    
          <%}
		  else{ %>
			  <script  type="text/javascript">                       
                          $("#FilePath").val('{cmspath}/'); 
                          $("#DefaultFile").val('index.html');

                          $("#TemplateIndex").val('/APP_templet/default/Channel.aspx');
                          $("#TemplateList").val('/APP_templet/default/ChannelList.aspx');
                          $("#TemplateShow").val('/APP_templet/default/Article.aspx');
                          $("#ListeRules").val('{cmspath}/ChannelList-{class}-{page}.html');
                          $("#ShowRules").val('{cmspath}/{Channel}/Article-{id}.html'); 
						  
				      
                                   
                   </script>
           <%}
		  %>
          
          
</body>
</html>
