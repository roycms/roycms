//向附件数据库添加一张图片数据
function DNS_login(url,gotourl, FROM) {
    $.ajax({
        type: 'POST',
        url: url,
        data: FROM.serialize(),
        success: function (date) {
            if (date > 0) {
                location.href = gotourl;
            } else {
                $(".alert").show();
            }
        }
    })
}
///////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////
/*页面加载类*/
$(document).ready(function () {
 //登录
    $("#login_bt").click(function () {
        //pos path  , goto url , from id 
        DNS_login("../AJAXLogin.aspx", "Welcome.aspx", $("#apnetFrom"));
    })
    //注册
    $("#reg_bt").click(function () {
        //pos path  , goto url , from id 
        DNS_login("../AJAXUserReg.aspx", "Welcome.aspx", $("#apnetFrom"));
    })
    //找回密码
    $("#getpassword_bt").click(function () {
        //pos path  , goto url , from id 
        DNS_login("../AJAXGetPassword.aspx", "login.aspx", $("#apnetFrom"));
    })
    //
    $('.dropdown-toggle').dropdown()
});