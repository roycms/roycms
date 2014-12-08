<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Objet.Insert" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
       window.onbeforeunload = function(){
	   return "是否关闭当前窗口"
    }
    </script>
</head>
<body>
<form enctype="multipart/form-data" id="InsertForm" runat="server">
    <Resources:Resources ID="Resources1" runat="server" />
        <script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script>
        <script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
    
    <!--工具栏开始-->
  <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> 
        <a href='#' class="InsertBT" ><img align="absmiddle" src="/administrator/images/nv7.png" />确认提交</a> 
        <a href='/administrator/class/index.aspx?Classkind=<%=Request["ClassKind"] %>'><img align="absmiddle" src="/administrator/images/nv2.png" />返回栏目</a> 
        <a href="/administrator/objet/admin.aspx?Classkind=<%=Request["ClassKind"] %>&Class=<%=Request["Class"] %>"><img align="absmiddle" src="/administrator/images/nv1.png" />返回信息列表</a> 
       
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
   <!--工具栏结束-->
   <div class="tagMenu">
          <ul class="menu1">
            <li>主体信息录入</li>
            <li>高级属性设置</li>
            <li>设置阅读权限</li>
            <li>设置关联相册</li>
            <li>设置附件</li>
           
          </ul>
        </div>
<div class="content1" style="padding:0px; margin-top:2px;">
    <div class="layout">
 
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td align="left" valign="top" width="100%">
        
        
         <!--隐藏字段值--> 
          <span style="display:none">
          <input type=input name="Title_color" id="Title_color" value="" />
            <input type=input name="Class" id="Class" value="<%=Request["Class"] %>" />
            <input type=input name="ClassKind" id="ClassKind" value='<%=Request["ClassKind"] %>' />
            <% if (Request["Id"] != null)
               { %>
               <input type=input name="Id" id="Id" value="<%=Request["Id"] %>" />
            <% } %>
          </span>

          <!--智能表单输出开始--> 
          <table  width="100%" border="0" align="center" cellpadding="5" cellspacing="1" bgcolor="#DFDFDF">
          <tr>
          <td align="right" nowrap bgcolor="#F4FBFF"><strong>频道</strong></td>
          <td bgcolor="#F4FBFF">
          <asp:DropDownList CssClass="select" ID="DdClass" runat="server" Width="200"></asp:DropDownList>
          <a href='/administrator/class/index.aspx?Classkind=<%=Request["ClassKind"] %>' class="btnSearch">设置频道</a>
          </td>
          </tr>
              <asp:Panel ID="PostPanel" Visible="false" runat="server">
              
               <tr>
                <td align="right" nowrap bgcolor="#F4FBFF"><strong>标题</strong></td>
                <td valign="bottom" nowrap bgcolor="#F4FBFF">
                <input type="text" style="width:400px;" maxlength="50" value="" name="ROYcms__RTitle" id="ROYcms__RTitle" class="txtInput" />
                 <a href="#"><img id="colorpicker" align="absmiddle" src="/administrator/images/nv8.png" /></a>
                   <label><input type='radio' name='switchs' value='1' id='switchs_0' checked='checked' style="vertical-align:middle;" /> 发布</label>
                   <label><input type='radio' name='switchs' value='2' id='switchs_1' style="vertical-align:middle" /> 草稿箱</label>
                   <label><input type='radio' name='switchs' value='0' id='switchs_2' style="vertical-align:middle" /> 回收站</label>
                </td>
               </tr>
               <tr>
                <td align="right" nowrap bgcolor="#F4FBFF"><strong>内容</strong></td>
                <td nowrap bgcolor="#F4FBFF">
              <script>
                        var editor;
                        KindEditor.ready(function(K) {
                                editor = K.create('#ROYcms__RContent',{				
                                cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=News,Content',
				                fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=News,Content',
				                autoHeightMode : true,
				                allowFileManager : true 
				                });
                        });
              </script>
                <textarea class'REditor' id="ROYcms__RContent" name="ROYcms__RContent" style="width:100%;height:360px;">
                <%  = new ROYcms.Sys.BLL.ROYcms_news().GetField(Convert.ToInt32(Request["Id"] == null ? "0" : Request["Id"]), "contents")%>
                </textarea>
                
                </td>
               </tr>
              </asp:Panel>
          
             <asp:Repeater ID="Repeater_Form_Put" runat="server">
               <ItemTemplate>           
                <tr>
                <td align="right" nowrap bgcolor="#F4FBFF"><strong><%#Eval("Lable")%></strong></td>
                <td width="100%" bgcolor="#F4FBFF"><%#ROYcms.Templet.ResponseForm.FormPut(Request["Id"],Request["Class"],Eval("Name").ToString(), Eval("Lable").ToString(), Eval("Len").ToString(), Eval("FieldType").ToString(), Eval("IsNull").ToString(), Eval("DefaultVal").ToString(), Eval("Display").ToString(), Eval("InputType").ToString(), Eval("InputLen").ToString())%>
                
                <%#Eval("Name").ToString() == "_RTitle"?@"<a href='#'><img id='colorpicker' align='absmiddle' src='/administrator/images/nv8.png' /></a>
                  <label><input type='radio' name='switchs' value='1' id='switchs_0'  checked='checked' />发布</label>
                  <label><input type='radio' name='switchs' value='2' id='switchs_1' />草稿箱</label>
                  <label><input type='radio' name='switchs' value='0' id='switchs_2' />回收站</label>" : ""%>
                
                  </td>
                </tr>
               </ItemTemplate>
            </asp:Repeater> 
             
          </table> 
          <!--智能表单输出结束-->
        </td>
       
      </tr>
    </table>
    
   </div>
    <div class="layout">
    
    <table width="100%" border="0" align="center" cellpadding="4" cellspacing="1" bgcolor="#DFDFDF">
      <tr>
        <td width="8%" align="right" bgcolor="#F4FBFF"><strong>属性</strong></td>
        <td width="92%" bgcolor="#F4FBFF">
          <span id="StatesHtml"></span>

          <a href="#" rel="SysHelp" style="margin-left:10px;">?</a> 
          
          <a href="#SetsT"  rel="facebox" title="设置文章状态信息">设置</a>
          <div id="SetsT" style=" width:200px;display:none;">
          <textarea name="SetsTVal" id="SetsTVal" cols="15" rows="6">置顶,1
推荐,2
首页,3
头条,4</textarea>
          <input type="submit" name="button" id="button" value="提交" />
          </div>
          </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>出处</strong></td>
        <td bgcolor="#F4FBFF"><input name="infor" type="text" id="infor" size="25" maxlength="50" class="txtInput" >
          
  <a href="#Gets_infor"  rel="facebox" title="选择出处" >选择</a>
          
          <div id="Gets_infor" style=" width:360px;display:none;">
          <div><a href="#Sets_infor" rel="facebox" title="设置出处信息" style="float:right">设置出处信息</a></div>
          <div id="inforHtml">
          </div>
          </div>
          
          <div id="Sets_infor" style=" width:200px;display:none;">
          <textarea name="Sets_inforVal" cols="15" rows="6">新京报
人民网
ROYcms官网
</textarea>
          <input type="submit" name="button" id="button" value="提交" />
          </div>
          
          </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>作者</strong></td>
        <td bgcolor="#F4FBFF"><input name="author" type="text" id="author" size="25" maxlength="50" class="txtInput" >
          
          
          <a href="#Gets_author"  rel="facebox" title="选择作者">选择</a>
          
          <div id="Gets_author" style=" width:360px;display:none;">
          <div><a href="#Sets_author" rel="facebox" title="设置作者信息" style="float:right">设置作者信息</a></div>
          <div>
          <a href="#">Admin管理员</a> 
          <a href="#">管理员</a> 
          </div>
          </div>
          
          <div id="Sets_author" style=" width:200px;display:none;">
          <textarea name="Sets_authorVal" cols="15" rows="6">Admin管理员
管理员
</textarea>
          <input type="submit" name="button" id="button" value="提交" />
          </div>
          
          
          </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>权重</strong></td>
        <td bgcolor="#F4FBFF"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="6%" nowrap>
            <input name="orders" type="text" id="orders" value="1" size="8" maxlength="10" class="txtInput" ></td>
            <td width="94%">
			
			<script>
			      $(function() {        
								  $( "#slide_orders" ).slider(
								  {Max:100},
								  {Min:1},
								  { slide: function(event, ui) {$("#orders").val(ui.value); } }
			  
			      );    
			  });    
              </script>
            <div id="slide_orders" style="width:420px; margin-left:20px;"><span style="margin-left:30px;font-size:11px; color:#CCC">值越大权重越高</span></div>
             </td>
          </tr>
      </table>
        
        </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>踩次数</strong></td>
        <td bgcolor="#F4FBFF"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
              <td width="6%" nowrap><input name="dig" type="text" id="dig" value="1" size="8" class="txtInput" ></td>
              <td width="94%">
              
              <script>
			      $(function() {        
								  $( "#slide_dig" ).slider(
								  {Max:100},
								  {Min:1},
								  { slide: function(event, ui) {$("#dig").val(ui.value); } }
			  
			      );    
			  });    
              </script>
            <div id="slide_dig" style=" width:420px; margin-left:20px;"></div>
              </td>
            </tr>
        </table></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>浏览数 </strong></td>
        <td bgcolor="#F4FBFF">
        
        
        
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
              <td width="6%" nowrap><input name="hits" type="text" id="hits" value="1" size="8" maxlength="10" class="txtInput" ></td>
              <td width="94%">
              
            <script>
			      $(function() {        
								  $( "#slide_hits" ).slider(
								  {Max:100},
								  {Min:1},
								  { slide: function(event, ui) {$("#hits").val(ui.value); } }
			  
			      );    
			  });    
              </script>
            <div id="slide_hits" style=" width:420px; margin-left:20px;"></div>
              </td>
            </tr>
        </table>
        
        
        </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>形象图</strong></td>
        <td bgcolor="#F4FBFF">
        
      <input name="pic" type="text" id="pic" size="45" maxlength="100" class="txtInput" >
      <a id="pic_click" class="btnSearch" style=" padding:3px; margin-left:5px;">选择文件</a>
                
                
                <script>
			                       			KindEditor.ready(function(K) {
				                            var editor = K.editor({
					                              cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                                    uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=News,Pic',
				                                    fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=News,Pic',
				                                    allowFileManager : true 
				                            });
				                                K('#pic_click').click(function () {
					                            editor.loadPlugin('image', function() {
						                            editor.plugin.imageDialog({
							                            imageUrl : K('#pic').val(),
							                            clickFn : function(url, title, width, height, border, align) {
							                                K('#pic').val(url);
                                                            //相册代码开始
							                                InsertPic(url)//添加到列表
							                                var Rid = $('#Id').val();
							                                AJAXInsertGalleryUpload(url, title, 0, Rid); //添加入数据库//调用Admin.js内AJAXInsertGalleryUpload()方法
							                                //相册代码结束
								                            editor.hideDialog();
							                            }
						                            });
					                            });
				                            });
                                        });
		                        </script>
        
        </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>关键词</strong></td>
        <td bgcolor="#F4FBFF"><input name="keyword" type="text" id="keyword" size="60" maxlength="100" class="txtInput" >
          
          <label for="checkbox"><input name="checkbox" type="checkbox" id="checkbox" value="1" checked>自动生成</label></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>描述</strong></td>
        <td bgcolor="#F4FBFF"><textarea name="zhaiyao" cols="50" rows="3" id="zhaiyao" ></textarea>
          <label for="checkbox2">
          <input name="checkbox2" type="checkbox" id="checkbox2" value="1" checked>自动生成</label></td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>链接</strong></td>
        <td bgcolor="#F4FBFF"><input name="link" type="text" id="link" size="50" class="txtInput" > </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>跳转地址</strong></td>
        <td bgcolor="#F4FBFF"><input name="jumpurl" type="text" id="jumpurl" size="50" class="txtInput" >
          </td>
      </tr>
      <tr>
        <td align="right" bgcolor="#F4FBFF"><strong>标签</strong></td>
        <td bgcolor="#F4FBFF"><input name="tag" type="text" id="tag" size="50" maxlength="100" class="txtInput" >
          
           <a href="#Gets_tag"  rel="facebox" title="选择标签">选择</a>
          
          <div id="Gets_tag" style=" width:360px;display:none;">
          <div>
          <a href="#">CMS</a> 
          <a href="#">百度</a> 
          <a href="#">搜狐</a> 
          <a href="#">张朝阳</a> 
          <a href="#">李开复</a> 
          <a href="#">新网</a> 
          <a href="#">开源</a> 
          <a href="#">企业上市</a> 
          <a href="#">新技术</a> 
          <a href="#">手机</a> 
          <a href="#">平板</a> 
          <a href="#">Ipad</a> 
          </div>
          </div>
          
          </td>
      </tr>
      <tr>
        <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>自定义URL地址</strong></td>
        <td bgcolor="#F4FBFF"><input name="urls" type="text" id="urls" size="50" class="txtInput" >
          <a name="pinyin" id="pinyin"></a>
          <a href="#pinyin" id="Title_PinYin">使用标题的拼音</a>
          <script>
                 $("#Title_PinYin").click(function(){
					 $("#urls").val("/"+$("#ROYcms__RTitle").toPinyin()+".html"); 
					 })      
          </script>
          
          </td>
      </tr>
           <tr>
        <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>文章发布时间</strong></td>
        <td bgcolor="#F4FBFF"><input name="Times" type="text" id="Times" size="50" class="txtInput" value="<%=DateTime.Now.ToString() %>" >
             <script>
                 $(document).ready(function () {
                     $("#Times").datepicker();
                 });
              </script>
          </td>
      </tr>
    </table>
          
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
    <div class="layout">
       <table width="610" height="304" cellSpacing="1" cellPadding="5" border="0" bgcolor="#CCCCCC">
              <tr>
                <td width="525" height="29" bgcolor="#F0F0F0">
                <a href="javascript:;" class="btnSearch" style=" padding:4px;" id="GalleryUpload"> 选择添加文件到相册 </a>
                
                 <script>
                     KindEditor.ready(function (K) {
                         var editor = K.editor({
                             cssPath: '/Administrator/Editor/plugins/code/prettify.css',
                             uploadJson: '/Administrator/Editor/C/upload_json.ashx?root=Gallery,Article',
                             fileManagerJson: '/Administrator/Editor/C/file_manager_json.ashx?root=Gallery,Article',
                             allowFileManager: true
                         });
                         K('#GalleryUpload').click(function () {
                             editor.loadPlugin('image', function () {
                                 editor.plugin.imageDialog({
                                     imageUrl: K('#pic').val(),
                                     clickFn: function (url, title, width, height, border, align) {
                                         //K('#pic').val(url);
                                         InsertPic(url); //添加到列表
                                         var Rid = $('#Id').val();
                                         AJAXInsertGalleryUpload(url, title, 0, Rid); //添加入数据库//调用Admin.js内AJAXInsertGalleryUpload()方法
                                         editor.hideDialog();
                                     }
                                 });
                             });
                         });
                     });
                     /*页面加载类*/
                     $(document).ready(function () {
                         $("#goods_thumb,#goods_img,#original_img").val($("#pic_show>img").attr("src"));
                         $("#pic_show>img").attr("src", $('#pic_scroll>ul>li:first').find("img").attr("src"));
                     });
									
		       </script>
                </td>
                </tr>
              <tr>
                <td bgcolor="#F4FBFF">
                  <!--幻灯片开始-->
                  <div class="slide_box">
                    <div id="pic_box" class="pic_box"  style="width:800px;height:360px;">
                    <div id="pic_del" style="color:#CCC; clear:both; height:30px">
                    <a id="GalleryDelPic" href="#" style="float:right" title="删除图片"> <img src="/administrator/images/PicDel.png" /> </a>
                    <a href="#LinkGalleryPic" rel="facebox" style="float:right; margin-right:10px;"  title="查看图片链接信息"> <img src="/administrator/images/WebLink.png" /> </a>
                    <div id="LinkGalleryPic" style="display:none; width:360px;">
                    缩略图链接： <input name="goods_thumb" id="goods_thumb" type="text" class="txtInput" size="40" /><br />
                    大图片链接： <input name="goods_img" id="goods_img" type="text" class="txtInput"  size="40" /><br />
                    原始图链接： <input name="original_img" id="original_img" type="text" class="txtInput"  size="40" /><br />
                    </div>
                    </div>
                      <!--<a class="big_prev"></a><a class="big_next"></a>-->
                      <div id="pic_show">
                      <img bimg="" src="" />
                      </div>
                    </div>
                    <div class="scroll_box">
                     <!-- <a class="small_prev"></a><a class="small_next"></a>-->
                      <div id="pic_scroll" class="items" style="width:800px;">
                        <ul>
                         <asp:Repeater ID="Repeater_Gallery" runat="server">
                         <ItemTemplate> 
                          <li>
                          <a href="javascript:;"><img bimg="<%#Eval("thumb_url")%>" src="<%#Eval("URL")%>" /></a>
                          </li>
                         </ItemTemplate>
                         </asp:Repeater>
                        </ul>
                       </div>
                    </div>
                    <div class="clear"></div>
                  </div>
                  <div class="line10"></div>
                  <!--幻灯片结束-->
                
                </td>
              </tr>
            </table>
    </div>
    <div class="layout">
    
     <table width="100%"  cellSpacing="1" cellPadding="5" border="0" bgcolor="#CCCCCC">
              <tr>
                <td height="29" bgcolor="#F0F0F0">
                <a href="javascript:;" class="btnSearch" style=" padding:4px;" id="AppendixUpload"> 选择添加文件到附件列表 </a>
                
                 <script>
                     KindEditor.ready(function (K) {
                         var editor = K.editor({
                             cssPath: '/Administrator/Editor/plugins/code/prettify.css',
                             uploadJson: '/Administrator/Editor/C/upload_json.ashx?root=Appendix,Root',
                             fileManagerJson: '/Administrator/Editor/C/file_manager_json.ashx?root=Appendix,Root',
                             allowFileManager: true
                         });

                         K('#AppendixUpload').click(function () {
                             editor.loadPlugin('insertfile', function () {
                                 editor.plugin.fileDialog({
                                     fileUrl: K('#AppendixUpload').val(),
                                     clickFn: function (url, title) {
                                         InsertFile(url, title); //添加到列表
                                         var Rid = $('#Id').val();
                                         AJAXInsertAppendixUpload(url, title, 0, Rid); //添加入数据库//调用Admin.js内AJAXInsertGalleryUpload()方法
                                         editor.hideDialog();
                                     }
                                 });
                             });
                         });
                     });
                   			
		            </script>
                </td>
                </tr>
                <tr>
                <td bgcolor="#F4FBFF" id="AppendixList">
                 <asp:Repeater ID="Repeater_Appendix" runat="server">
                         <ItemTemplate> 
                          <div>
                                附件类型：
                                附件名称：<%#Eval("Title")%>
                                附件地址：<%#Eval("URL")%>
                                <a href="javascript:;" Rid="<%#Eval("Rid")%>" URL="<%#Eval("URL")%>">删除</a>
                          </div>
                         </ItemTemplate>
                 </asp:Repeater>
               
                </td>
                </tr>
                
             
            </table>
    
    
    
    
    </div>
  </div> 
<div style="margin-left:100px; margin-top:10px;">  
    <input type=button name="InsertBT" id="InsertBT" value="确认提交"  class="btnSubmit" /> 
    <input type="reset" name="noBT" id="noBT" value="重置"  class="btnSubmit" />
</div>
    
       <!--同步所有编辑器的值回去，提交表单时用到-->
    
       <% 
           
                    ROYcms.Sys.BLL.ROYcms_Custom CustomBLL = new ROYcms.Sys.BLL.ROYcms_Custom();
                    int Class = Convert.ToInt32(Request["Class"]);
           
                    string StrSync = null;
                    if (new ROYcms.Sys.BLL.ROYcms_Class_Model().CidExists(Class))
                    {
                        string[] Fields = CustomBLL.GetTableList(Class);   //得到字段
                        string[] InputType = CustomBLL.GetInputTypeList(Class);   //得到类型

                        if (Fields != null && InputType != null)
                        {
                            if (Fields.Length == InputType.Length && Fields.Length + InputType.Length > 2)
                            {

                                for (int i = 0; i < Fields.Length; i++)
                                {
                                    if (InputType[i] == "6")
                                    {
                                        StrSync += "Editor" + Fields[i] + ".sync();";
                                    }
                                }
                            }
                        }
                    }
         %>  
                        <script  type="text/javascript">
                           function EditorSync(){
                              <%=StrSync %> // Editor.sync();//同步编辑器数据
                           }
                        </script>
                         

    
<!--编辑模式下给默认的表单赋值-->  
    
    
           <% 
               ROYcms.Sys.BLL.ROYcms_news ROYcms_newsBLL = new ROYcms.Sys.BLL.ROYcms_news();
               ROYcms.Sys.Model.ROYcms_news ROYcms_newsModel = new ROYcms.Sys.Model.ROYcms_news();
               if (Request["Id"] != null)
               {
                   int Id = Convert.ToInt32(Request["Id"]);
                   string DStr = null;
                   ROYcms_newsModel = ROYcms_newsBLL.GetModel(Id);
               }
               if (ROYcms_newsModel != null && Request["Id"] != null)
               {
           %>
               <script  type="text/javascript">
                              $("#ROYcms__RTitle").val('<% = ROYcms_newsModel.title %>');
                              $("#infor").val('<% = ROYcms_newsModel.infor %>');
                              $("#author").val('<% = ROYcms_newsModel.author %>');
                              $("#orders").val('<% = ROYcms_newsModel.orders %>');
                              $("#hits").val('<% = ROYcms_newsModel.hits %>');
                              $("#dig").val('<% = ROYcms_newsModel.dig %>');
                              $("#keyword").val('<% = ROYcms_newsModel.keyword %>');
                              $("#zhaiyao").val('<% = ROYcms_newsModel.zhaiyao %>');
                              $("#link").val('<% = ROYcms_newsModel.link %>');
                              $("#jumpurl").val('<% = ROYcms_newsModel.jumpurl %>');
                              $("#tag").val('<% = ROYcms_newsModel.tag %>');
                              $("#urls").val('<% = ROYcms_newsModel.url %>');
                               $("#pic").val('<% = ROYcms_newsModel.pic %>');
                               $("#Times").val('<% = ROYcms_newsModel.time %>');
                   
                                     
                              $("#ding").attr('checked', <% = ROYcms_newsModel.ding==1?"true":"false" %>);
                              $("#tuijian").attr('checked', <% = ROYcms_newsModel.tuijian==1?"true":"false" %>);
                              $("#switchs").attr('checked', <% = ROYcms_newsModel.switchs==1?"true":"false" %>);
                               
               </script>
    
          <%} %>
          
            <script  type="text/javascript">
			//取色器
			KindEditor.ready(function(K) {
				var colorpicker;
				K('#colorpicker').bind('click', function(e) {
					e.stopPropagation();
					if (colorpicker) {
						colorpicker.remove();
						colorpicker = null;
						return;
					}
					var colorpickerPos = K('#colorpicker').pos();
					colorpicker = K.colorpicker({
						x : colorpickerPos.x,
						y : colorpickerPos.y + K('#colorpicker').height(),
						z : 19811214,
						selectedColor : 'default',
						noColor : '无颜色',
						click : function(color) {
							K('#Title_color').val(color);
							$("#ROYcms__RTitle").css({color: color});
							
							colorpicker.remove();
							colorpicker = null;
						}
					});
				});
				K(document).click(function() {
					if (colorpicker) {
						colorpicker.remove();
						colorpicker = null;
					}
				});
			});
		</script>
        
        
                  <script type="text/javascript">
				  /*输出文章状态*/
						 var StatesHtml = " <label><input type='checkbox' name='ding' value='1' id='ding' style='vertical-align:middle;'  /> 置顶</label>";
						 StatesHtml+=" <label><input type='checkbox' name='tuijian' value='1' id='tuijian' style='vertical-align:middle;' /> 推荐</label>";

						 var StatesS = $("#SetsTVal").val().split("\n");
						 for(var i=0;i<StatesS.length;i++){
                         StatesHtml+=" <label><input type='checkbox' name='dingV' value='"+StatesS[i].split(",")[1]+"' id='dingV"+i+"' style='vertical-align:middle;'  /> "+StatesS[i].split(",")[0]+"</label>";
						 }
						  $("#StatesHtml").html(StatesHtml);
                 </script>

    </form>
</body>
</html>
