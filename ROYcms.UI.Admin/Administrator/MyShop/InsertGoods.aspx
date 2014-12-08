<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertGoods.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.MyShop.InsertGoods" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title></title>
    <script type="text/javascript">
        window.onbeforeunload = function () {
            return "是否关闭当前窗口"
        }
    </script>
</head>
<body>
<form id="InsertGoodsForm" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script> 
  <script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
  <div id="rotate"> 
    <!--工具栏开始-->
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con"> 
        <a href='/administrator/myshop/AdminGoods.aspx?ClassKind=<%=ROYcms.Common.Request.GetQueryInt("ClassKind")%>'>
        <img align="absmiddle" src="/administrator/images/nv9.png" />返回商品列表</a> </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <!--工具栏结束-->
    <div class="tagMenu">
      <ul class="menu1">
        <li>商品基本属性</li>
        <li>商品图片相册</li>
        <li>商品描述商</li>
      </ul>
    </div>
    <div class="content1" style="padding:0px; margin-top:3px;">
      <div class="layout">
        <table  cellSpacing="1" cellPadding="5" width="100%" border="0" bgcolor="#CCCCCC">
          <tr>
            <td width="11%" align="right" bgcolor="#F4FBFF"><strong>商品分类 </strong></td>
            <td width="33%" bgcolor="#F4FBFF" nowrap>
            <asp:DropDownList CssClass="select" ID="goods_type" runat="server" Width="120"></asp:DropDownList>
            <a href="/administrator/class/index.aspx?Classkind=<%=ROYcms.Common.Request.GetQueryInt("ClassKind")%>" class="btnSearch">设置</a>
            <strong style="margin-left:4px;">品牌</strong>
             <asp:DropDownList CssClass="select" ID="brand_id" runat="server" Width="120"></asp:DropDownList>
            <a href="AdminBrand.aspx" class="btnSearch">设置</a>
            </td>
            <td width="56%" rowspan="5" valign="top" bgcolor="#F4FBFF"><table width="100%" border="0" cellspacing="0" cellpadding="3">
                <tr>
                  <td>
                  <input name="Id" type="hidden" id="Id" value="<%=Model.Id %>" />
                  <input name="ClassKind" type="hidden" id="ClassKind" value="<%=ROYcms.Common.Request.GetQueryInt("ClassKind")%>" />
                  <label>
                    <input name="is_on_sale" type="checkbox" id="is_on_sale" value="1" checked="checked" />
                  该商品是否开放销售</label></td>
                </tr>
                <tr>
                  <td><label>
                    <input name="is_real" type="checkbox" id="is_real" value="1" checked="checked" />
                  是否是实物</label></td>
                </tr>
                <tr>
                  <td><label>
                    <input name="is_alone_sale" type="checkbox" id="is_alone_sale" value="1" checked="checked" />
                  是否能单独销售</label></td>
                </tr>
                <tr>
                  <td><label>
                    <input name="is_delete" type="checkbox" id="is_delete" value="1" />
                  商品是否已经删除</label></td>
                </tr>
                <tr>
                  <td><label>
                    <input name="is_best" type="checkbox" id="is_best" value="1" />
                  是否是精品</label></td>
                </tr>
                <tr>
                  <td><label>
                    <input name="is_hot" type="checkbox" id="is_hot" value="1" />
                  是否热销</label></td>
                </tr>
                <tr>
                  <td><label>
                    <input name="is_promote" type="checkbox" id="is_promote" value="1" />
                  是否特价促销</label></td>
                </tr>
              </table>
            </td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>商品的唯一货号</strong></td>
            <td bgcolor="#F4FBFF">
            <input name="goods_sn" type="text" class="txtInput" id="goods_sn" value="<%= Request["Id"]!=null?Model.goods_sn:"C"+ ROYcms.Common.StringPlus.GetRamCode() %>" size="26" />
            </td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>商品的名称</strong></td>
            <td bgcolor="#F4FBFF"><input name="goods_name" type="text" class="txtInput" id="goods_name" size="40"  value="<%=Model.goods_name %>" />
            <input name="goods_name_style" type="text" class="txtInput" id="goods_name_style" size="7"  value="#000000" />
            

            <script>

                //取色器
                KindEditor.ready(function (K) {
                    var colorpicker;
                    K('#goods_name_style').bind('click', function (e) {
                        e.stopPropagation();
                        if (colorpicker) {
                            colorpicker.remove();
                            colorpicker = null;
                            return;
                        }
                        var colorpickerPos = K('#goods_name_style').pos();
                        colorpicker = K.colorpicker({
                            x: colorpickerPos.x,
                            y: colorpickerPos.y + K('#goods_name_style').height(),
                            z: 19811214,
                            selectedColor: 'default',
                            noColor: '无颜色',
                            click: function (color) {
                                K('#goods_name_style').val(color);
                                $("#goods_name").css({ color: color });

                                colorpicker.remove();
                                colorpicker = null;
                            }
                        });
                    });
                    K(document).click(function () {
                        if (colorpicker) {
                            colorpicker.remove();
                            colorpicker = null;
                        }
                    });
                });
		
            </script>
            
            </td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>本店售价</strong></td>
            <td bgcolor="#F4FBFF"><input name="shop_price" type="text" class="txtInput" id="shop_price" size="10"  value="<%=Model.shop_price %>" />
              实际销售的价格</td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>市场售价</strong></td>
            <td bgcolor="#F4FBFF"><input name="market_price" type="text" class="txtInput" id="market_price" size="10" value="<%=Model.market_price %>" />
              市场参考价格</td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>库存数量</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input name="goods_number" type="text" class="txtInput" id="goods_number" size="10"  value="<%=Model.goods_number %>" /></td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>参与促销价格</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input name="promote_price" type="text" class="txtInput" id="promote_price"  size="10"  value="<%=Model.promote_price %>" />
             促销日期从 
               <input name="promote_start_date" type="text" class="txtInput" id="promote_start_date" size="15"  value="<%=Model.promote_start_date %>" /> 
               到 
             <input name="promote_end_date" type="text" class="txtInput" id="promote_end_date"  size="15" value="<%=Model.promote_end_date %>"  />
             结束
              <script>
                  $(document).ready(function () {
                      $("#promote_start_date,#promote_end_date").datepicker();
                  });
              </script>
            </td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>商品的重量</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input type="text" name="goods_weight" id="goods_weight" class="txtInput" value="<%=Model.goods_weight %>"  />
            以千克为单位</td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>商品关键字</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input name="keywords" type="text" class="txtInput" id="keywords" size="60" value="<%=Model.keywords %>"  />
搜索引擎SEO备用</td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>商品简短描述 </strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><textarea name="goods_brief" cols="100" rows="3" id="goods_brief"><%=Model.goods_brief %></textarea></td>
          </tr>
         
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>供货人姓名</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input type="text" name="provider_name" id="provider_name" class="txtInput" value="<%=Model.provider_name %>"  />
备注该商品的供货商信息</td>
          </tr>
          <tr>
            <td align="right" nowrap="nowrap" bgcolor="#F4FBFF"><strong>商品的扩展属性</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input name="extension_code" type="text" class="txtInput" id="extension_code" value="<%=Model.extension_code %>"  /></td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>商品报警数量</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input name="warn_number" type="text" class="txtInput" id="warn_number"  value="<%=Model.warn_number %>"  size="10" />
              低于该值产品库存发出警告</td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>可用积分数量</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input name="integral" type="text" class="txtInput" id="integral"  value="<%=Model.integral %>"  size="10" />
            购买该商品可使用的积分数量</td>
          </tr>
          <tr>
            <td align="right" bgcolor="#F4FBFF"><strong>赠送积分数量</strong></td>
            <td colspan="2" bgcolor="#F4FBFF"><input name="give_integral" type="text" class="txtInput" id="give_integral" value="<%=Model.give_integral %>"  size="10" />
            购买该商品时每笔成功交易赠送的积分数量 </td>
          </tr>
        </table>
      </div>
      <div class="layout">

            
            <table width="610" height="304"   cellSpacing="1" cellPadding="5" border="0" bgcolor="#CCCCCC">
              <tr>
                <td width="525" height="29" bgcolor="#F0F0F0">
                <a href="#" class="btnSearch" style=" padding:4px;" id="GalleryUpload"> 选择添加文件到相册 </a>
                <a href="#" class="btnSearch" style=" padding:4px; margin-left:5px;"  id="GalleryListUpload"> 单独设置商品列表图片 </a>
                 <script>
			                       			KindEditor.ready(function(K) {
				                            var editor = K.editor({
					                              cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                                    uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=Gallery,Goods',
				                                    fileManagerJson: '/Administrator/Editor/C/file_manager_json.ashx?root=Gallery,Goods',
				                                    allowFileManager : true 
				                            });
				                            K('#GalleryUpload').click(function() {
					                            editor.loadPlugin('image', function() {
						                            editor.plugin.imageDialog({
							                            imageUrl : K('#pic').val(),
							                            clickFn : function(url, title, width, height, border, align) {
								                            //K('#pic').val(url);
															InsertPic(url)//添加到列表
															var Rid = $('#Id').val();
															AJAXInsertGalleryUpload(url, title, 0,Rid); //添加入数据库//调用Admin.js内方法
															editor.hideDialog();
							                            }
						                            });
					                            });
				                            });
                                        });
										/*页面加载类*/
										$(document).ready(function() {
											$("#goods_thumb,#goods_img,#original_img").val($("#pic_show>img").attr("src"));
											$("#pic_show>img").attr("src",$('#pic_scroll>ul>li:first').find("img").attr("src"));
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
                    <a href="#LinkGalleryPic" rel="facebox" style="float:right; margin-right:10px;"  title="查看图片链接信息"> 
                    <img src="/administrator/images/WebLink.png" /> </a>
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
                                         AJAXInsertAppendixUpload(url, title, 1, Rid); //添加入数据库//调用Admin.js内AJAXInsertGalleryUpload()方法
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

      <div class="layout"><script>
                        var editor;
                        KindEditor.ready(function(K) {
                                editor = K.create('#goods_desc',{				
                                cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=Goods,<%=Request["ClassKind"] %>',
				                fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=Goods,<%=Request["ClassKind"] %>',
				                autoHeightMode : true,
				                allowFileManager : true 
				                });
                        });
              </script>
        <textarea class='REditor' id="goods_desc" name="goods_desc" style="width:100%;height:360px;">
        <%=Model.goods_desc %>
        </textarea>
      
      </div>
    </div>
    <div style="margin-left:100px; margin-top:10px;">
      <input type="button" name="InsertGoodsBT" id="InsertGoodsBT" value="确认提交"  class="btnSubmit" />
      <input type="reset" name="button2" id="button2" value="重置" class="btnSubmit" />
    </div>
  </div>
</form>
</body>
</html>
