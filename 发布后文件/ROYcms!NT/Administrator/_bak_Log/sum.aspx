<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>日志数据统计</h3>
    <hr />
   <div> 所有注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount("bh>0")%> </div>
   <div> 今天注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount("(DATEDIFF(dd, login_time, GETDATE()) = 0)")%> </div>
   <div> 昨天注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount("(DATEDIFF(dd, login_time, GETDATE()) = 1)")%> </div>
   <div> 广州长宽注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='广州长宽') ")%> </div>
   <div> 上海长宽注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='上海长宽') ")%> </div>
   <div> 深圳长宽注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='深圳长宽') ")%> </div>
   <div> 上海鹏博士注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='上海鹏博士') ")%> </div>
    <hr />
   <div><a href='/app_api/send_mail.aspx?url=<%=Request.RawUrl %>' target=_blank>发送到邮箱</a></div>
    
    </div>
    </form>
</body>
</html>
