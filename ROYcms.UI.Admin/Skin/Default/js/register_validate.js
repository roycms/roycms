//=====================初始化代码======================
$(function() {
	//显示验证码
    $("#txtCode").bind("focus", function() {
        $("#verifyCode").show();
    });
    //同意条款
    $("#chkAgree").bind("click", function() {
        if ($(this).is(":checked")) {
            $("#btnSubmit").attr("disabled", "");
        } else {
            $("#btnSubmit").attr("disabled", "disabled");
        }
    });
	//初始化验证表单
    $("#regform").validate({
        errorElement: "span",
		success: "success",
        rules: {
            txtUserName: {
                required: true,
                minlength: 3,
                maxlength: 20,
                remote: {
                    type: "post",
                    url: $("#txtUserName").attr("validateurl"),
                    data: {
                        username: function() {
                            return $("#txtUserName").val();
                        }
                    },
                    dataType: "html",
                    dataFilter: function(data, type) {
						if (data == "true")
                            return true;
                        else
                            return false;
                    }
                }
            }
        },
        messages: {
            txtUserName: {
                required: "只允许字母、数字、下划线。",
                minlength: "用户名太短啦！",
                maxlength: "你的用户名太长啦！",
                remote: "很抱歉，该用户名不可用！"
            }
        },
        submitHandler: function(form) {
			//AJAX提交表单
			$(form).ajaxSubmit({
				beforeSubmit: showRequest,
				success: showResponse,
				error: showError,
				url: $("#regform").attr("url"),
				type: "post",
				dataType: "json",
				//resetForm: true,
				timeout: 30000
			});
            return false;
        }
    });
    
    //表单提交前
	function showRequest(formData, jqForm, options) {
		$("#btnSubmit").val("正在提交...")
		$("#btnSubmit").attr("disabled", "disabled");
		$("#chkAgree").attr("disabled", "disabled");
	}
	//表单提交后
	function showResponse(data, textStatus) {
		if(data.msg == 1){ //成功
			location.href = data.url;
		}else{ //失败
			$.ligerDialog.error(data.msgbox);
			$("#btnSubmit").val("再次提交");
			$("#btnSubmit").attr("disabled", "");
			$("#chkAgree").attr("disabled", "");
		}
	}
	//表单提交出错
	function showError(XMLHttpRequest, textStatus, errorThrown) {
		//alert('状态: ' + textStatus + '\n 出错的内容是: \n' + errorThrown);
		$.ligerDialog.error("状态：" + textStatus + "；出错提示：" + errorThrown);
		$("#btnSubmit").val("再次提交");
		$("#btnSubmit").attr("disabled", "");
		$("#chkAgree").attr("disabled", "");
	}
});