<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ROYcms.Community.Web.App_Community.index" ValidateRequest="false" %>
<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc1" %>
<%@ Register src="Right.ascx" tagname="Right" tagprefix="uc2" %>
<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html>
<head>
<meta http-equiv="X-UA-Compatible" content="IE=7" >
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title><%=___GetConfigValue("Title")%></title>
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
                      <div style="float:right">
                      </div>
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
                  <a><span>前一页</span></a>
                  <span class="fs-h-separator">|</span>后一页
                  </a>
                </div>
                <a class="fs-action-link" href="/Community/default.html">&laquo; 返回首页</a>
              </div>
              <table>
                <tr>
                  <td><div class="fs-add-clean-btn">
                      <a href="#send" style="color:#FFF;">发表新帖子</a>
                    </div></td>
                  <td><div class="fs-add-clean-btn" id="newPollButton">
                      <a href="#send" style="color:#FFF;">发起投票</a>
                    </div></td>
                </tr>
              </table>
              <table class="fs-topic-list" border="0" cellspacing="0" cellpadding="0" width="100%">
                <col width="18px"/>
                <col width="80%"/>
                <col width="20px"/>
                <col width="12%"/>
                <col width="100px"/>
                <tr>
                  <td class="rowg" colspan="7"></td>
                </tr>
                <tr>
                  <td class="rowg" colspan="7"></td>
                </tr>
                <asp:Repeater ID="Repeater_list" runat="server">
                  <ItemTemplate>
                    <tr onmouseover="this.className='fs-row-hover'" onmouseout="this.className=''">
                      <td valign="middle" class="fs-hot-topic-dots-ctn"><div class="fs-hot-topic-dots" style="background-position:0 -0px" ></div></td>
                      <td valign="middle" class="fs-topic-name"><a href='/Community/CommMsgs-<%#Eval("bh") %>.html'><%#Eval("title") %></a>
                        <%if(ROYcms.Common.Session.Get("administrator")!=null){ %>
                        <a rel=facebox href='#del<%#Eval("bh") %>' > 删除 </a>
                        <%} else{%>
                        <%#Eval("user_id").ToString() == ROYcms.Common.Session.Get("user_id") ? "<a rel=facebox href='#del" + Eval("bh") + "' > 删除 </a>" : ""%>
                        <%} %>
                        <div id="del<%#Eval("bh") %>" style=" display:none;">
                          <h3>确实要删除吗？</h3>
                          <p>
                            <a href='?del=<%#Eval("bh") %>'>删除</a>
                          </p>
                        </div>
                        <span class="fs-meta" > 0/0</span></td>
                      <td valign="middle"><a class="fs-tiny-user-avatar umhook " ><img src="/app_Community/images/u1-t.gif" /></a></td>
                      <td valign="middle" style="padding-left:4px"><a href="?" class="umhook">
                        <%# Eval("user_id").ToString() == "" ? "匿名用户" : ___GetUserDate("{name}", Eval("user_id").ToString())%>
                        </a></td>
                      <td valign="middle" nowrap class="fs-topic-last-mdfy fs-meta" ><%#ROYcms.Common.TimeParser.TimeNonce( Eval("star_time").ToString()) %></td>
                    </tr>
                    <tr>
                      <td class="rowg" colspan="7"></td>
                    </tr>
                  </ItemTemplate>
                </asp:Repeater>
                <tr>
                  <td class="rowg" colspan="7"></td>
                </tr>
              </table>
              <div style="text-align:right;margin-top:1em;margin-bottom:2em;">
                <div class="fs-pagination"><span class="page_info fs-meta">第<strong>1</strong>-<strong>50</strong>篇帖子</span>
                  <span class="paging"><span class="fs-paging-item paging_nolink fs-paging-pre">上一页&nbsp;</span>
                  <b class="fs-paging-item fs-paging-cur">1</b>
                  <a class="fs-paging-item" href="?page=2">2</a>
                  <a class="fs-paging-item" href="?page=3">3</a>
                  <a class="fs-paging-item" href="?page=4">4</a>
                  <a class="fs-paging-item" href="?page=5">5</a>
                  <a class="fs-paging-item" href="?page=6">6</a>
                  <a class="fs-paging-item" href="?page=7">7</a>
                  <a class="fs-paging-item" href="?page=8">8</a>
                  <a class="fs-paging-item" href="?page=9">9</a>
                  <a class="fs-paging-item" href="?page=10">10</a>
                  <span class="fs-paging-item fs-paging-dots">...</span>
                  <a href="" class="fs-paging-item fs-paging-next">下一页&nbsp;</a>
                  </span></div>
              </div>
              <div class="fs-user-action fs-user-action fs-post-editor-ctn">
                <a class="fs-small-user-avatar umhook " href=""><img src="/app_Community/images/u1-s.gif" /></a>
                <div class="fs-user-action-main">
                  <span id="UCLoginBar">
                  <%if (ROYcms.Common.Session.Get("user_id") != null)
    { %>
                  <a>欢迎 <%= ROYcms.Common.Session.Get("user")%>
                  </a>
                  <a href=/ucenter/PeopleDate.aspx >个人信息</a>
                  <a href=/ucenter/logout.aspx?url=Community/default.html >注销</a>
                  <%}
    else
    { %>
                  <strong>游客</strong>
                  <div style="margin-bottom:6px">对不起，您只能以匿名身份发帖和跟帖。请 <b>
                    <a href="/ucenter/login.aspx?url=Community/default.html">登录</a>
                    </b> 或 <b>
                    <a href="/ucenter/Reg.aspx?url=Community/default.html">注册</a>
                    </b>
                  </div>
                  <%} %>
                  </span>
                  <div id="msgPostEditor">
                    <!--<p class="fs-edit-before-loading fs-meta">-->
<form action="?" >
                    <table width="100%" border="0" cellspacing="4" cellpadding="4">
                      <tr>
                        <td width="2%" nowrap="nowrap"><a name="send"></a>
                          标 题</td>
                        <td width="98%" align="left"><span id="sprytextfield1">
                          <label>
                            <input name="title" type="text" id="title" size="80" />
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
    FCKeditor.Height = 180;
    FCKeditor.ToolbarSet = "Basic";
    FCKeditor.Create();
</script>
                          </label>
                          <span class="textareaRequiredMsg">帖子内容必填</span></span></td>
                      </tr>
                      <tr>
                        <td>&nbsp;</td>
                        <td align="left"><label>
                            <input type="submit" name="button" id="Submit1" value="确认提交" />
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
</form>
<script type="text/javascript">
<!--
    var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1");
/*    var sprytextarea1 = new Spry.Widget.ValidationTextarea("sprytextarea1");*/
//-->
</script>
</body>
</html>
