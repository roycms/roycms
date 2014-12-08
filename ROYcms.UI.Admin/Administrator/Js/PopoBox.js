//弹出窗口的绑定事件
function PopoMain(){

MainReg();//验证所有弹出框的输入 指向PopoBoxRegex.js 文件的MainReg()方法
SystemTabs() //    弹出框内的选项卡效果

//////////////////////////////////////////////////////////////////////////
//创建模型方法 AddModel.aspx
$("#AddModelBT").unbind();
$("#AddModelBT").click(function(){
   var err = AddModeReg();
   if(err!=null){alert(err);return}
    $.ajax({
		   type: 'POST',
		   url: "/administrator/model/AJAXModel.aspx",
		   data: $("#AddModeForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#AddModelBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#AddModelBT").attr("value", "提交");
		       MessageBox(true, "成功！");
               //alert("成功!");
			   Boxy.get("#AddModelBT").hide(); //关闭窗口
			   window.location.reload();//刷新页面
			} else {
			   $("#AddModelBT").attr("value","继续提交");
			   MessageBox(false, "失败！");
			};
		   }
		   
		})
})

//添加和编辑一个敏感词替换 InsertSynonymsBT.aspx
$("#InsertSynonymsBT").unbind();
$("#InsertSynonymsBT").click(function(){
   // var err = Edit_AdminUserReg();
   // if(err!=null){alert(err);return}
    $.ajax({
		   type: 'POST',
		   url: "/administrator/CMSHelp/AjaxSynonyms.aspx",
		   data: $("#InsertSynonymsForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#InsertSynonymsBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#InsertSynonymsBT").attr("value","提交");
		       MessageBox(true, "成功！");
			   Boxy.get("#InsertSynonymsBT").hide(); //关闭窗口
			   window.location.reload();//刷新页面
			} else {
			   $("#InsertSynonymsBT").attr("value","继续提交");
			   MessageBox(false, "失败！");
			};
		   }
		})
})
//////////////////////////////////////////////////////////////////////////


//添加和编辑一个管理员信息 Edit_AdminUser.aspx
$("#Edit_AdminUserBT").unbind();
$("#Edit_AdminUserBT").click(function(){
   var err = Edit_AdminUserReg();
   if(err!=null){alert(err);return}
    $.ajax({
		   type: 'POST',
		   url: "/administrator/config/AjaxAdminUser.aspx",
		   data: $("#Edit_AdminUserForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#Edit_AdminUserBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#Edit_AdminUserBT").attr("value","提交");
		       MessageBox(true, "成功！");
			   Boxy.get("#Edit_AdminUserBT").hide(); //关闭窗口
			   window.location.reload();//刷新页面
			} else {
			   $("#Edit_AdminUserBT").attr("value","继续提交");
			   MessageBox(false, "失败！");
			};
		   }
		})
})
//添加和编辑一个功能模块 adminMap/insert.aspx
$("#AdminMapBT").unbind();
$("#AdminMapBT").click(function(){
   // var err = Edit_AdminUserReg();
   // if(err!=null){alert(err);return}
    $.ajax({
		   type: 'POST',
		   url: "/administrator/AdminMap/AjaxMap.aspx",
		   data: $("#AdminMapForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#AdminMapBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#AdminMapBT").attr("value","提交");
		       MessageBox(true, "成功！");
			   Boxy.get("#AdminMapBT").hide(); //关闭窗口
			   window.location.reload();//刷新页面
			} else {
			   $("#AdminMapsBT").attr("value","继续提交");
			   MessageBox(false, "失败！");
			};
		   }
		})
})
//快捷生成静态文件 newhtml/newlist.aspx
$("#KNewHtmlBT").unbind();
$("#KNewHtmlBT").click(function(){
    $.ajax({
		   type: 'POST',
		   url: "/administrator/NewHtml/AJAXNewHtml.aspx",
		   data: $("#KNewHtmlForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#KNewHtmlBT").attr("value","正在提交..."); },
		   success: function(date){
               if(date=="0"){
                   //alert("必须在站点全局配置里启用静态浏览选项");
                   MessageBox(false, "必须在站点全局配置里启用静态浏览选项");
			   }else{		   
				   $("#KNewHtmlBT").attr("value","提交");
				   //alert(date);
				   MessageBox(true, date);
			   }
		   }
		})
})

//配置权限的设定
$("#Set_Role_Bt").unbind();
$("#Set_Role_Bt").click(function(){
alert("成功");
Boxy.get("#Set_Role_Bt").hide(); //关闭窗口
    // $.ajax({
		   // url: "/administrator/Class/AJAXClass_Model.aspx",
		   // data: "Del="+$(this).attr("id"),
		   // success: function(date){ 
		   // if (date>0) {
               // alert("成功");
			   // Boxy.get(".Class_ModelDelBT").hide(); //关闭窗口
			// } else {
		       // alert("失败");
			// };
		   // }
		// })
})

// 编辑管理员用户是的 权限列表赋值

$("#Rol option[value='" + $("#RolVal").val() + "']").attr("selected", "selected");


}
