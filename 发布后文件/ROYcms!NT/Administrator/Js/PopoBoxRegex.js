//弹出窗口表单验证插件
//Add_objet 添加对象表单验证
function InsertObjetReg(){
	var e=null;function set(po){if (e==null){e=po;};}
	
		//if(!Validator("#ClassKind",regexEnum.intege1)){set("标识必须为数字！");}; //正整数
		if(!Validator("#Title",regexEnum.notempty)){set("标题不能为空！")}; //非空
		if(!Validator("#logo",regexEnum.notempty)){set("图标不能为空！")}; 
		if(!Validator("#AppendixConfig",regexEnum.notempty)){set("附件配置文件不能为空！")}; 
		if(!Validator("#AppendixPath",regexEnum.notempty)){set("附件地址不能为空！")}; 
		if(!isBool("#Visible")){set("显示状态必须为0或1的数字!")}; //
		//if(!Validator("#Role",regexEnum.intege1)){set("权限必须为数字！")}; //正整数
		
		return e;	
}
//AddMode 添加模型表单验证
function AddModeReg(){
	var e=null;function set(po){if (e==null){e=po;};}
	
		if(!Validator("#Name",regexEnum.notempty)){set("模型名称不能为空！");}; //正整数
		if(!Validator("#TableName",regexEnum.letter)){set("表格名字必须为英文字母！")}; //非空
		
		return e;	
}
//AddMode 添加模型表单验证
function Edit_AdminUserReg(){
	var e=null;function set(po){if (e==null){e=po;};}
	
	if(!Validator("#name",regexEnum.username)){set("用户名不能为空！");}; //正整数
		if(!Validator("#password",regexEnum.notempty)){set("密码不能为空！")}; 
		if(!Validator("#password2",regexEnum.notempty)){set("再次密码不能为空！")}; 
		if(!Validator("#classkind",regexEnum.intege1)){set("标识必须为数字！")};
		//if(!Validator("#Rol",regexEnum.intege1)){set("权限必须为数字！")}; 
        if($("#password").val()!=$("#password2").val()){set("两次密码输入不一致！")}; 
		
		return e;	
}

//提交表单验证非AJAX验证
function MainReg(){
    //添加和编辑 管理员用户验证
	// $("#Add_AdminUserForm,#Edit_AdminUserForm").submit(function(){
	// var e=null;function set(po){if (e==null){e=po;};}
	
		// if(!Validator("#txtname",regexEnum.username)){set("用户名不能为空！");}; //正整数
		// if(!Validator("#txtpassword",regexEnum.notempty)){set("密码不能为空！")}; 
		// if(!Validator("#txtpassword2",regexEnum.notempty)){set("再次密码不能为空！")}; 
		// if(!Validator("#txtclasskind",regexEnum.intege1)){set("标识必须为数字！")};
		// if(!Validator("#txtRol",regexEnum.intege1)){set("权限必须为数字！")}; 
        // if($("#txtpassword").val()!=$("#txtpassword2").val()){set("两次密码输入不一致！")}; 
		
		// if(e!=null){alert(e);return false}
		// else{return true;}

	// })
	
	//编辑个人用户
	$("#user_edit_form").submit(function(){
	var e=null;function set(po){if (e==null){e=po;};}
	
		if(!Validator("#txtname",regexEnum.username)){set("用户名格式不正确！");}; //正整数
		if(!Validator("#txtpassword",regexEnum.notempty)){set("密码不能为空！")}; 
		if(!Validator("#txtpassword2",regexEnum.notempty)){set("再次密码不能为空！")}; 
		//if(!Validator("#txtusername",regexEnum.notempty)){set("昵称不能为空！")};
		//if(!Validator("#UGroup_DropDownList",regexEnum.intege1)){set("请选择工作组！")};
		if(!Validator("#txtemail",regexEnum.email)){set("邮件格式不正确！")};
		if(!Validator("#txtqq",regexEnum.qq)){set("QQ号码格式不正确！")};	
        if($("#txtpassword").val()!=$("#txtpassword2").val()){set("两次密码输入不一致！")}; 
		
		if(e!=null){alert(e);return false}
		else{return true;}

	})
	
	//编辑添加用户组
	$("#AddGroupForm,#group_editForm").submit(function(){
	var e=null;function set(po){if (e==null){e=po;};}
	
		if(!Validator("#txtname",regexEnum.notempty)){set("用户组不能为空！");}; //正整数
		//if(!Validator("#txtzhaiyao",regexEnum.notempty)){set("摘要不能为空！")}; 
		if($("#txtRoleID").val()!=null){
		    if(!Validator("#txtRoleID",regexEnum.intege1)){set("权限格式必须为数字！")}; 
		}
		
		if(e!=null){alert(e);return false}
		else{return true;}

	})
	
    //编辑添加工作流
	$("#AddWorkflowForm,#Workflow_editForm").submit(function(){
	var e=null;function set(po){if (e==null){e=po;};}
	
		if(!Validator("#txtkeyId",regexEnum.notempty)){set("权限标识不能为空！");}; //正整数
		if(!Validator("#txtname",regexEnum.notempty)){set("工作流不能为空！")}; 
		//if(!Validator("#txtzhaiyao",regexEnum.notempty)){set("摘要不能为空！")}; 
		
		if(e!=null){alert(e);return false}
		else{return true;}

	})
	
	
}