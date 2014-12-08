<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="CommMsgs.aspx.cs" Inherits="ROYcms.Community.Web.App_Community.CommMsgs"  ValidateRequest="false" %>

<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc1" %>
<%@ Register src="Right.ascx" tagname="Right" tagprefix="uc2" %>
<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html>
<head runat=server>
<meta http-equiv="X-UA-Compatible" content="IE=7" >
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title></title>
<meta name="Keywords" content=<%=___GetConfigValue("Keyword")%> />
<meta name="Description" content=<%=___GetConfigValue("Description")%> />
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.2.6/jquery.min.js" type="text/javascript"></script>
<link href="images/Community.css" rel="stylesheet" type="text/css">
<link href="/app_Community/images/Community.css" rel="stylesheet" type="text/css">
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
</head>
<body class="fs-fit-win-body fs-3-1-column fs-commmsgs-page">
    <form id="form1" runat="server" action="?">
<div id="fs-min-width-ctn">
  <div id="fs-body-wrapper">
    <div id="fs-page-content-ctn">
      <div>
        <!--头部-->
                      
              <uc3:Top ID="Top1" runat="server" />

        <div class="min-width">
          <div class="min-width-inner">
            <div class="fix-min-width">
              <div id="category-nav" class="fs-nav-infocard">
                <div class="fs-c">
                  <div style="position:absolute;right:1.8em;width:400px;text-align:right;margin-top:0.8em;padding-top:3px;">
                    <div style="float:right;margin-left:0.4em"></div>
                    <div style="float:right"></div>
                  </div>
                  <div class="fs-comm-logo">
                    <div class="fs-comm-logo-bg">
                      <a href="?" title="爱情故事" >
                        <img src="/app_Community/images/u1-s.gif" />
                      </a>
                    </div>
                  </div>
                  <table cellspacing="0" cellpadding="0">
                    <tr>
                      <td><h1 title="爱情故事">外汇社区</h1></td>
                      <td valign="middle"><!--           <div class="fs-comm-cat">
                            <span class="fs-icons fs-icon-cat">&nbsp;</span>
                            <a href="?">生活</a>
                            &raquo;
                            <a href="?">情感</a>
                          </div>--></td>
                    </tr>
                  </table>
                  <div id="category-nav-i">
                    <ul>
                      <li>
                        <a class="comm-cat-drop-menu" id="tabSpec0" href="/Community/default.html" >本吧首页</a>
                      </li>
                      <li class="active first">
                        <div class="fs-rc fs-rctl"></div>
                        <div class="fs-rc fs-rctr"></div>
                        <a href="/Community/default.html" class="comm-cat-drop-menu" id="tabSpec1">讨论<span class="fs-meta">(36666)</span></a>
                      </li>
                      <li>
                        <a class="comm-cat-drop-menu" id="tabSpec2" href="/Community/default.html" >百科</a>
                      </li>
                      <li>
                        <a class="comm-cat-drop-menu" id="tabSpec3" href="/Community/default.html" >成员<span class="fs-meta">(1322)</span></a>
                      </li>
                      <li>
                        <a class="comm-cat-drop-menu" id="tabSpec4" href="/Community/default.html" >资料</a>
                      </li>
                    </ul>
                    <div class="cl"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div id="mainbody">
        <div class="fs-c">
          <div class="cl">

</div>
                     
              <uc2:Right ID="Right1" runat="server" />
          <!--右侧-->
          <div id="leftbody">
            <div class="fs-v-space fs-meta">
              <div class="fs-adjacent-posts">
                <a href="" target="_blank">
                <span class="goog-inline-block fs-control fs-control-prev">&nbsp;</span>
                &nbsp;<span>前一篇</span></a>
                <span class="fs-h-separator">|</span>后一篇
                <a href=""><span class="goog-inline-block fs-control fs-control-next">&nbsp;</span></a>
              </div>
              <a class="fs-action-link" href="/Community/default.html">&laquo; 返回帖子列表</a>
            </div>
            <h1 class="fs-post-title"> 
            
           标题：   <asp:Literal ID="title" runat="server"></asp:Literal>
            </h1>
            <div class="fs-user-action-paging">
              <div class="fs-pagination"><span class="page_info fs-meta">第<strong>1</strong>-<strong>26</strong>篇回帖, 共<strong>26</strong>篇</span>
                <span class="paging"><span class="fs-paging-item paging_nolink fs-paging-pre">上一页&nbsp;</span>
                <span class="fs-paging-item paging_nolink fs-paging-next">下一页&nbsp;</span></span></div>
            </div>
            <div class="fs-user-action">
              <a class="fs-small-user-avatar umhook " href="?"><img src="/app_Community/images/u1-s.gif" /></a>
              <div class="fs-user-action-main">
                <strong>
                <a href="?" id="c0" class="umhook"><asp:Literal ID="user_name" runat="server"></asp:Literal></a>
                </strong>
                <span class="fs-meta">在<asp:Literal ID="Time" runat="server"></asp:Literal>时说 </span>
                <div id="post0" class="fs-user-action-body">

                <asp:Literal ID="content" runat="server"></asp:Literal>
                </div>
                <div class="fs-user-action-btns">
                  <strong class="fs-meta">#Top</strong>
                  <span class="fs-h-separator fs-meta">|</span>
                  <a class="fs-ip-addr"><asp:Literal ID="ip" runat="server"></asp:Literal></a>
                  <div id="replyBtn_0" class="goog-custom-button goog-inline-block fs-post-reply "  >
                    <div class="goog-inline-block goog-custom-button-outer-box">
                      <div class="goog-inline-block goog-custom-button-inner-box">
                        <a href="#newT">回复</a>
                      </div>
                    </div>
                  </div>
                </div>
                <div style="margin-top:24px; margin-bottom:12px ">
                  <div class="fs-related-topics-wide-bg">
                    <div style="margin-bottom:6px; font-weight:bold;">相关帖子</div>
                    <ul class="fs-related-topics-wide">
                <asp:Repeater ID="Repeater_list_" runat="server">
                  <ItemTemplate>
 <li>
                       <!-- <a class="thumb">
                        <img  src="" class="tiny-topic-image" /></a>-->
                        <div class="detail image-topic-detail">
                          <div class="title">
                           <a href='/Community/CommMsgs-<%#Eval("bh") %>.html'><%#Eval("title") %></a>
                          </div>
                          <div class="fs-topic-meta">
                            <span class="fs-deco-icons fs-icon-sep fs-icon-reply"></span>
                            <span class="fs-meta">30条回复 - <%#Eval("end_time") %></span>
                          </div>
                        </div>
                      </li>
                    
                  </ItemTemplate>
                </asp:Repeater>
                     
                      
                      
                    </ul>
                  </div>
                </div>
                <div style="margin-top:1em;text-align:right">
                  <span class="fs-meta">分享到：</span>
                  <a class="fs-action-link-nu" href="javascript:void(0)" id="shareToKaixin"><span title=分享到开心网 class="fs-icons fs-icon-kaixin">&nbsp;</span> 开心网</a>
                  <span class="fs-h-separator">
                  </span>
                  <a class="fs-action-link-nu" href="javascript:void(0)" id="shareToXiaonei"><span title=分享到校内网 class="fs-icons fs-icon-xiaonei">&nbsp;</span> 校内网</a>
                  <span class="fs-h-separator">
                  </span>
                  <a class="fs-action-link-nu" href="javascript:void(0)" id="shareToDouban"><span title=分享到豆瓣 class="fs-icons fs-icon-douban">&nbsp;</span> 豆瓣</a>
                </div>
              </div>
              <div class="cl-l"></div>
            </div>
            
            <asp:Repeater ID="Repeater_list" runat="server">
      <ItemTemplate>     
        
 <div class="fs-user-action">
              <a class="fs-small-user-avatar umhook " href="?">
              <img src="/app_Community/images/u1-s.gif" /></a>
              <div class="fs-user-action-main">
                <strong>
                <a href="?" id="c23" class="umhook"><%#___GetUserDate("{name}", Eval("user_id").ToString())%></a>
                </strong>
                <span class="fs-meta">在<%#ROYcms.Common.TimeParser.TimeNonce( Eval("Time").ToString()) %>前说 ,</span>
                <div id="post23" class="fs-user-action-body"><%#Eval("title") %><%#Eval("content") %></div>
                <div class="fs-user-action-btns">
                  <strong class="fs-meta">#<%# Container.ItemIndex+1%></strong>
                  <span class="fs-h-separator fs-meta">|</span>
                  <a class="fs-ip-addr" ><%#Eval("ip") %></a>
                  <span class="fs-vote-status"></span>
                  <div id="replyBtn_23" class="goog-custom-button goog-inline-block fs-post-reply "  >
                    <div class="goog-inline-block goog-custom-button-outer-box">
                      <div class="goog-inline-block goog-custom-button-inner-box">
                        <a href="#newT">回复</a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="cl-l"></div>
        </div>
        
      </ItemTemplate>
    </asp:Repeater>
            

            <div class="fs-user-action-paging">
              <div class="fs-pagination"><span class="page_info fs-meta">第<strong>1</strong>-<strong>26</strong>篇回帖, 共<strong>26</strong>篇</span>
                <span class="paging"><span class="fs-paging-item paging_nolink fs-paging-pre">上一页&nbsp;</span>
                <span class="fs-paging-item paging_nolink fs-paging-next">下一页&nbsp;</span></span></div>
            </div>
            <div class="fs-user-action fs-user-action fs-post-editor-ctn">
<a class="fs-small-user-avatar umhook " href="?"><img src="/app_Community/images/u1-s.gif" /></a>
              <div class="fs-user-action-main">
              
              <span id="UCLoginBar">
  <%if (ROYcms.Common.Session.Get("user_id") != null)
    { %>
  <a>欢迎 <%= ROYcms.Common.Session.Get("user")%> </a>
  <a href=/ucenter/PeopleDate.aspx >个人信息</a>
  <a href=/ucenter/logout.aspx?url=Community/default.html >注销</a>
  <%}
    else
    { %>
                  <strong>游客</strong>
                <div style="margin-bottom:6px">对不起，您只能以匿名身份发帖和跟帖。请  <b>
                   <a href="/ucenter/login.aspx?url=Community/default.html">登录</a>
                  </b> 或 <b>
                       <a href="/ucenter/Reg.aspx?url=Community/default.html">注册</a>
                  </b>
                  </div>
  <%} %>
  </span>

                <div id="msgPostEditor">
           <!--       <p class="fs-edit-before-loading fs-meta">-->
<form action="?" >
                     <table width="100%" border="0" cellspacing="4" cellpadding="4">
        <tr>
          <td width="2%" nowrap="nowrap"><a name="send"></a><a name="newT"></a>
            标 题</td>
          <td width="98%" align="left"><span id="sprytextfield1">
            <label>
              <input name="title" type="text" id="title" size="80" />
              <input name="Community_id" type="hidden" value='<%=Request["id"]%>'>
            </label>
          <span class="textfieldRequiredMsg">帖子标题必填</span></span></td>
        </tr>
        <tr>
          <td nowrap="nowrap">内 容</td>
          <td align="left"><span id="sprytextarea1">
            <label>
              <script type="text/javascript" src="/administrator/FCKedit/fckeditor.js"></script> 
<script type="text/javascript">
    var FCKeditor = new FCKeditor("content");
    FCKeditor.BasePath = "/administrator/FCKedit/";
    FCKeditor.Height =180;
    FCKeditor.ToolbarSet = "Basic";
    FCKeditor.Create();
</script>
            </label>
          <span class="textareaRequiredMsg">帖子内容必填</span></span></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td align="left"><label>
            <input type="submit" name="button" id="button" value="确认提交" />
          </label></td>
        </tr>
</table>
                  
       </form>
                </div>
                <div class="cl-l"></div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="fs-c" style="height:1%">
      </div>
      <!--底部-->
           <uc1:Footer ID="Footer1" runat="server" />
    </div>
  </div>
</div>
<script type="text/javascript">
<!--
    var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
/*    var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1");*/
//-->
</script>
    </form>
</body>
</html>
