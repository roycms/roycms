/*===========================Roy==========================================*/
//全局消息框定位
function MessageBox(X, Message) {
    XMessageBox(); //定位
    $(".MessageBox").html(Message); //消息框HTML输出到页面
    $(".MessageBox").show();
    if (X == true) { $(".MessageBox").css({ background: "#f9f9f9" }); } else { $(".MessageBox").css({ background: "#ffcfcf" }); }
    $(".MessageBox").oneTime('2s', 'D', //五秒钟后隐藏
         function () {
             $(".MessageBox").hide(200);
         })
}
//全局消息框方法 
function XMessageBox() {
    var w = $(window).width();
    var h = $(window).height();
    var popW = $(".MessageBox").width();
    var popH = $(".MessageBox").height();
    $(".MessageBox").css({ left: (w - 50 - popW) / 2, top: (h - 50 - popH) / 2 });
}
//选择模板后赋值方法 class/add.aspx 和 edit.aspx
function GetClassTemplate(path,type){
        if(type==1){$("#TemplateIndex").val(path);}
		if(type==2){$("#TemplateList").val(path);}
		if(type==3){$("#TemplateShow").val(path);}
		//else{alert("操作异常！");}
		Boxy.get("#Myframe").unload(); //关闭窗口
		return;
	}
//向附件数据库添加一张图片数据
function AJAXInsertGalleryUpload(url,title,type,Rid){
    $.ajax({
        type: 'get',
        url: "/administrator/Gallery/AJAXInsert.aspx?URL=" + url + "&Title=" + title + "&TYPE=" + type + "&Rid=" + Rid,
        //beforeSend:function(xmlhttp){},
        success: function (date) {
            if (date > 0) {
                //alert("成功");
                MessageBox(true,"添加到相册成功！");
            } else {
                //alert("失败");
                MessageBox(false, "添加到相册失败！");
            }
        }
    })
}
//向相册数据库添加一张图片数据
function AJAXInsertAppendixUpload(url, title, type, Rid) {
    $.ajax({
        type: 'get',
        url: "/administrator/Appendix/AJAXInsert.aspx?URL=" + url + "&Title=" + title + "&TYPE=" + type + "&Rid=" + Rid,
        //beforeSend:function(xmlhttp){},
        success: function (date) {
            if (date > 0) {
                //alert("成功");
                MessageBox(true, "添加到附件成功！");
            } else {
                //alert("失败");
                MessageBox(false, "添加到附件失败！");
            }
        }
    })
}
//删除相册数据库一张图片数据
function AJAXGalleryDelPic(url,Del){
			$.ajax({
				   type: 'get',
				   url: "/administrator/Gallery/AJAXInsert.aspx?URL="+url+"&Del="+Del,
				   //beforeSend:function(xmlhttp){},
				   success: function(date){ 
				   if(date>0){
				       MessageBox(true, "成功！");
					   }else{
				    MessageBox(false, "失败！");
					   }
				   }
				})
}
//删除附件数据库数据
function AJAXAppendixDelFile(url, Del) {
    $.ajax({
        type: 'get',
        url: "/administrator/Appendix/AJAXInsert.aspx?URL=" + url + "&Del=" + Del,
        //beforeSend:function(xmlhttp){},
        success: function (date) {
            if (date > 0) {
                MessageBox(true, "成功！");
            } else {
                MessageBox(false, "失败！");
            }
        }
    })
}
//静态生成主入口
function AJAXNewHtml(per){
			$.ajax({
				   type: 'get',
				   url: "/administrator/NewHtml/AJAXNewHtml.aspx?ONE=" + per + "&random" + Math.random(),
				   beforeSend:function(xmlhttp){ $("#ONE").find("input:eq("+(per-1)+")").attr("value","正在努力生成中..."); },
				   success: function(date){ 
				   if(date=="0"){
				       $("#ONE").find("input:eq("+(per-1)+")").attr("value","点击生成");
					   alert("必须在站点全局配置里启用静态浏览选项");
					   }else{		   
							$("#ONE").find("input:eq("+(per-1)+")").attr("value","点击生成");
							   alert(date);
					   }
				   }
				})
}
//相册代码 添加到列表
function InsertPic(MyUrl)
{
	$("#pic_scroll>ul").append("<li><a href='javascript:;'><img bimg='"+MyUrl+"' src='"+MyUrl+"' /></a></li>");//追加
	$("#pic_show>img").attr("src",MyUrl);//设置大的形象图为当前添加
	$("#pic_scroll>ul").find("a").removeClass("hovers");//先清除所有样式
	$("#pic_scroll>ul>li").last().find("a").addClass("hovers");//设置当前被选中样式
	
	$("#goods_img,#original_img,#pic").val(MyUrl);
	$("#goods_thumb").val(MyUrl.replace(".","_thumb."));
}
//附件代码 添加到列表
function InsertFile(MyUrl,Title) {
    $("#AppendixList").append("<div>附件名称：" + Title + "附件地址：" + MyUrl + "</div>"); //追加
    
    //<a href='javascript:;' Rid='<%#Eval("Rid")%>" URL="<%#Eval("URL")%>">删除</a>
}
/////////////////////////////////////////////////////////////////////////////////////
//主函数方法
function AdminMain(){
	//表单异步提交 objet/Insert.aspx
	$("#InsertBT,.InsertBT").click(function(){
	  var err = InsertReg();
   if(err!=null){alert(err);return}

	editor.sync();//同步编辑器数据
	EditorSync();//在页面输出  同步编辑器数据
	////K.sync(".REditor");//同步所有编辑器数据 
	
		$.ajax({
			   type: 'POST',
			   url: "/administrator/objet/AJAXInsert.aspx",
			   data: $("#InsertForm").serialize(),
			   beforeSend:function(xmlhttp){$("#InsertBT").attr("value","正在提交...");$("#InsertBT").attr("disabled","disabled");},
			   success: function(date){ 
			   $("#InsertBT").removeAttr("disabled");
			   if (date>0) {
				   $("#InsertBT").attr("value","提交");
				   MessageBox(true, "成功！");
				} else {
				   $("#InsertBT").attr("value","继续提交");
				   MessageBox(false, "失败！");
				};
			   }
			})
	})
	
	//Insert 添加信息表单验证
function InsertReg(){
	var e=null;function set(po){if (e==null){e=po;};}
	    
		if(!Validator("#ROYcms__RTitle",regexEnum.notempty)){set("标题不能为空！")};
		if(!Validator("#orders",regexEnum.intege1)){set("权重必须为数字！");}; //正整数
		if(!Validator("#hits",regexEnum.intege1)){set("浏览量必须为数字！")}; //非空
		if(!Validator("#dig",regexEnum.intege1)){set("热度必须为数字！")}; 
		
		return e;	
}


	//添加和编辑频道表单异步提交 class/Insert.aspx
	$("#ClassInsertBT").click(function(){
	  var err = ClassInsertReg();
   if(err!=null){alert(err);return}
	editor.sync();//同步编辑器数据
		$.ajax({
			   type: 'POST',
			   url: "/administrator/CLASS/AJAXInsert.aspx",
			   data: $("#ClassInsertForm").serialize(),
			   beforeSend:function(xmlhttp){$("#ClassInsertBT").attr("value","正在提交...");$("#ClassInsertBT").attr("disabled","disabled");},
			   success: function(date){ 
			   $("#ClassInsertBT").removeAttr("disabled");
			   if (date>0) {
				   $("#ClassInsertBT").attr("value","提交");
				   MessageBox(true, "成功！");
			} else if (date == -1) {
				   $("#ClassInsertBT").attr("value","继续提交");
				   MessageBox(false, "文件保存地址重复，目录和默认文档地址组合重复！");
			} else{
			    $("#ClassInsertBT").attr("value", "继续提交");
			    MessageBox(false, "失败！");
			};
			   }
			})
	})
	//Insert 添加信息表单验证
function ClassInsertReg(){
	var e=null;function set(po){if (e==null){e=po;};}
	    if(!Validator("#ClassName",regexEnum.notempty)){set("频道名称不能为空！")};
		return e;	
}
//站点配置表单提交 CMS_config.aspx	
function CMSConfigAjax(objet){
   		$.ajax({
			   type: 'POST',
			   url: "/administrator/config/AJAXConfig.aspx",
			   data: $(objet+"Form").serialize(),
			   beforeSend:function(xmlhttp){$(objet+"BT").attr("value","正在提交...");$(objet+"BT").attr("disabled","disabled");},
			   success: function(date){ 
			   $(objet+"BT").removeAttr("disabled");
			   if (date>0) {
				   $(objet+"BT").attr("value","提交");
				   MessageBox(true, "成功！");
				} else {
				   $(objet+"BT").attr("value","继续提交");
				   MessageBox(false, "失败！");
				};
			   }
			})
}
$("#ConfigIndexBT").unbind();
$("#ConfigIndexBT").click(function(){
   var objet ="#ConfigIndex";
   CMSConfigAjax(objet);
})
$("#ConfigUcenterBT").unbind();
$("#ConfigUcenterBT").click(function(){
   var objet ="#ConfigUcenter";
   CMSConfigAjax(objet);
})	
$("#ConfigPayBT").unbind();
$("#ConfigPayBT").click(function(){
   var objet ="#ConfigPay";
   CMSConfigAjax(objet);
})
$("#ConfigEmailBT").unbind();
$("#ConfigEmailBT").click(function(){
   var objet ="#ConfigEmail";
   CMSConfigAjax(objet);
})

// 关联自定义模型 
$(".Class_ModelBT").unbind();
$(".Class_ModelBT").click(function(){
    $.ajax({
		   url: "/administrator/Class/AJAXClass_Model.aspx",
		   data: "Id="+$(this).attr("id"),
		   success: function(date){ 
		   if (date>0) {
		       MessageBox(true, "成功！");
			   Boxy.get(".Class_ModelBT").hide(); //关闭窗口
			}
			else if(date==-1){
		       alert("失败:模型未初始化！请先初始化模型表。");
			}
			else {
			    MessageBox(false, "失败！");
			};
		   }
		})
})
// 删除关联自定义模型 
$(".Class_ModelDelBT").unbind();
$(".Class_ModelDelBT").click(function(){
if(!confirm("确实要删除关联自定义模型吗?")){
	return false;
	}else {
    $.ajax({
		   url: "/administrator/Class/AJAXClass_Model.aspx",
		   data: "Del="+$(this).attr("id"),
		   success: function(date){ 
		   if (date>0) {
		       MessageBox(true, "成功！");
			   Boxy.get(".Class_ModelDelBT").hide(); //关闭窗口
			} else {
		    MessageBox(false, "失败！");
			};
		   }
		})}
})

//静态生成站点文件
$("#NewHtmlBT").unbind();
$("#NewHtmlBT").click(function(){
    $.ajax({
		   type: 'POST',
		   url: "/administrator/NewHtml/AJAXNewHtml.aspx",
		   data: $("#NewHtmlForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#NewHtmlBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if(date=="0"){
		              $("#NewHtmlBT").attr("value","提交");
					   alert("必须在站点全局配置里启用静态浏览选项");
					   }
					   else{
				   $("#NewHtmlBT").attr("value","提交");
				   alert(date);
			   }
		   }
		})
})

//一键 静态生成
$("#ONE").find("input:eq(0)").click(function(){
AJAXNewHtml(1);
})
$("#ONE").find("input:eq(1)").click(function(){
AJAXNewHtml(2);
})
$("#ONE").find("input:eq(2)").click(function(){
AJAXNewHtml(3);
})
$("#ONE").find("input:eq(3)").click(function(){
AJAXNewHtml(4);
})

//添加一个模块方法Add_objet.aspx
$("#InsertObjetBT").unbind();
$("#InsertObjetBT").click(function(){
   var err = InsertObjetReg();
   if(err!=null){alert(err);return}
    $.ajax({
		   type: 'POST',
		   url: "/administrator/GO/AJAXAdd_objet.aspx",
		   data: $("#InsertObjetForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#InsertObjetBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#InsertObjetBT").attr("value","提交");
		       MessageBox(true, "成功！");
			   window.parent.frames.item('leftFrame').location.reload(); 
			   //window.location.reload();//刷新页面
			} else {
			   $("#InsertObjetBT").attr("value","继续提交");
			   MessageBox(false, "失败！");
			};
		   }
		})
})
//添加一个模型方法 //选择LOGO图标
$("#add_objet_set_logo").find("img").click(function(){
$("#logo").val($(this).attr("src"));
})

$("#Set_AppendixConfig").find("a").click(function(){
$("#AppendixConfig").val($(this).html());
Boxy.get(this).hide(); //关闭窗口
})

$("#Set_AppendixPath").find("a").click(function(){
$("#AppendixPath").val($(this).html());
Boxy.get(this).hide(); //关闭窗口
})



//相册代码
$("#pic_scroll>ul>li>a>img").live("click",function(){//列表单击事件
	$("#pic_scroll>ul").find("a").removeClass("hovers");//先清除所有样式
	$(this).parent().addClass("hovers");//设置当前被选中样式
	$("#pic_show>img").attr("src",$(this).attr("src"));
	
	$("#goods_thumb,#goods_img,#original_img,#pic").val($(this).attr("src"));
	$("#goods_thumb").val($(this).attr("src").replace(".","_thumb."));
	
})
//删除相册的数据的按钮绑定事件
$("#GalleryDelPic>img").click(function(){
   AJAXGalleryDelPic($("#pic_show>img").attr("src"),$('#Id').val());
   $("#pic_show>img").attr("src","");
   $(".hovers").hide();
})
//删除附件的数据的按钮绑定事件
$("#AppendixList").find("a").click(function () {
    AJAXAppendixDelFile($(this).attr("URL"), $('#Id').val());
    $(this).parent().hide();
})

//商品的编辑和添加	
$("#InsertGoodsBT").unbind();
$("#InsertGoodsBT").click(function(){
    editor.sync();//同步编辑器数据
   // var err = InsertObjetReg();
   // if(err!=null){alert(err);return}
    $.ajax({
		   type: 'POST',
		   url: "/administrator/myshop/AJAXGoods.aspx",
		   data: $("#InsertGoodsForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#InsertGoodsBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#InsertGoodsBT").attr("value","提交");
		       MessageBox(true, "成功！");
			   //window.location.reload();//刷新页面
			} else {
			   $("#InsertGoodsBT").attr("value","继续提交");
			   MessageBox(false, "失败！");
			};
		   }
		})
})
//品牌商品品牌的编辑和添加	
$("#InsertBrandBT").unbind();
$("#InsertBrandBT").click(function(){
   
   // var err = InsertObjetReg();
   // if(err!=null){alert(err);return}
    $.ajax({
		   type: 'POST',
		   url: "/administrator/myshop/AJAXBrand.aspx",
		   data: $("#InsertBrandForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#InsertBrandBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#InsertBrandBT").attr("value","提交");
		       MessageBox(true, "成功！");
			   //window.location.reload();//刷新页面
			} else {
			   $("#InsertBrandBT").attr("value","继续提交");
			   MessageBox(false, "失败！");
			};
		   }
    })

    // 编辑模型是的 权限列表赋值

    $("#Role option[value='" + $("#RoleVal").val() + "']").attr("selected", "selected");

    $("#Visible option[value='" + $("#VisibleVal").val() + "']").attr("selected", "selected");

    // 编辑管理员用户是的 权限列表赋值

    $("#Rol option[value='" + $("#RolVal").val() + "']").attr("selected", "selected");



})
}

///////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////
/*页面加载类*/
$(document).ready(function() {
AdminMain();//表单异步提交 objet/add.aspx 和 edit.aspx
AdminTabs();//选项卡效果
});