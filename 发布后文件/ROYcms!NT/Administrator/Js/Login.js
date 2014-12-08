//登录注册
function DNS_login(url, gotourl, FROM) {
    $.ajax({
        type: 'POST',
        url: url,
        data: FROM.serialize(),
        beforeSend: function (xmlhttp) { $("#login_bt").html("正在提交中..."); $("#reg_bt").html("正在提交中..."); },
        success: function (date) {
            if (date > 0) {
                location.href = gotourl;
            } else {
                $("#login_bt").html("登入");
                $("#reg_bt").html("注册");
                $(".alert").show();
            }
        }
    })
}
/*页面加载类*/
$(document).ready(function () {
//登录
$("#login_bt").click(function () {
    if (!Validator("#username", regexEnum.notempty)) { alert("用户不能为空！"); return; }; //非空
    if (!Validator("#password", regexEnum.notempty)) { alert("密码不能为空！"); return; }; //非空
    //pos path  , goto url , from id 
    DNS_login("/ucenter/AJAXLogin.aspx", "/ucenter/default.aspx", $("#apnetFrom"));
})
//注册
$("#reg_bt").click(function () {
    if (!Validator("#name", regexEnum.notempty)) { alert("标题不能为空！"); return; }; //非空
    if (!Validator("#email", regexEnum.notempty)) { alert("标题不能为空！"); return; }; //非空
    if (!Validator("#password", regexEnum.notempty)) { alert("密码不能为空！"); return; };
    if (!Validator("#password2", regexEnum.notempty)) { alert("再次密码不能为空！"); return; };
    if ($("#password").val() != $("#password2").val()) { alert("两次密码输入不一致！"); return; };
    if (!Validator("#valdates", regexEnum.notempty)) { alert("验证码不能为空！"); return; };

    //pos path  , goto url , from id 
    DNS_login("/ucenter/AJAXUserReg.aspx", "/ucenter/login.html", $("#apnetFrom"));
})
//找回密码
$("#getpassword_bt").click(function () {
    //pos path  , goto url , from id 
    DNS_login("/ucenter/AJAXGetPassword.aspx", "login.aspx", $("#apnetFrom"));
})
//
$('.dropdown-toggle').dropdown();
});