<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE HTML>
<html >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>注册用户数据统计</h3>
    <hr />
   <div> 所有注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount("bh>0")%> </div>
   <div> 今天注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount("(DATEDIFF(dd, login_time, GETDATE()) = 0)")%> </div>
   <div> 昨天注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount("(DATEDIFF(dd, login_time, GETDATE()) = 1)")%> </div>
   <div> 广州长宽注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='广州长宽') ")%> </div>
   <div> 上海长宽注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='上海长宽') ")%> </div>
   <div> 深圳长宽注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='深圳长宽') ")%> </div>
   <div> 深圳长宽注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP in (select ip from ROYcms_Ip where city='武汉长宽') ")%> </div>
   <div> 其它地区注册用户数:<%= new ROYcms.Sys.BLL.ROYcms_user().GetCount(" IP not in (select ip from ROYcms_Ip) ")%> </div>
    <hr />
   <div><a href='/app_api/send_mail.aspx?url=<%=Request.RawUrl %>' target=_blank>发送到邮箱</a></div>
    
    </div>
    </form>
</body>
</html>
