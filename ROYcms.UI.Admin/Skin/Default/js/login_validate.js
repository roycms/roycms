//====================初始化验证表单====================
$(function(){
	//提交表单
	$("#btnSubmit").bind("click", function() {
		if($("#txtUserName").val()=="" || $("#txtPassword").val()==""){
			$("#msgtips").show();
			$("#msgtips dd").text("请填写用户名和登录密码！");
			return false;
		}
		$.ajax({
            type: "POST",
            url: $("#loginform").attr("url"),
			dataType: "json",
            data: {
                txtUserName: function() {
                	return $("#txtUserName").val();
                },
				txtPassword: function() {
                	return $("#txtPassword").val();
                },
				chkRemember: function() {
					return $("#chkRemember").attr("checked");
                }
            },
            timeout: 20000,
			beforeSend: function(XMLHttpRequest) {
				$("#btnSubmit").attr("disabled", "disabled");
				$("#msgtips").show();
				$("#msgtips dd").text("正在登录，请稍候...");
			},
            success: function(data, textStatus) {
                if (data.msg == 1){
					if(typeof(data.url)=="undefined"){
						location.href = $("#turl").val();
					}else{
						location.href = data.url;
					}
                } else {
                    $("#btnSubmit").attr("disabled", "");
                    $("#msgtips dd").text(data.msgbox);
                }
            },
			error: function (XMLHttpRequest, textStatus, errorThrown) {
				$("#msgtips dd").text("状态：" + textStatus + "；出错提示：" + errorThrown);
				$("#btnSubmit").attr("disabled", "");
			} 
        });
		return false;
    });
});