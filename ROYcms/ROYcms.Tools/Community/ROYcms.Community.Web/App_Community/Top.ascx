<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Top.ascx.cs" Inherits="ROYcms.Community.Web.App_Community.Top" %>

<link href="/administrator/webui/facebox/facebox.css" media="screen" rel="stylesheet" type="text/css"/>
<script src="/administrator/webui/facebox/facebox.js" type="text/javascript"></script>
<SCRIPT type=text/javascript>
    jQuery(document).ready(function($) {
      $('a[rel*=facebox]').facebox({
      loading_image: '/administrator/webui/facebox/loading.gif',
      close_image: '/administrator/webui/facebox/closelabel.gif'
      }) 
    })
  </SCRIPT>

<div class="header-all">
          <div class="min-width">
            <div class="min-width-inner">
              <div class="fix-min-width">
                <div class="new-header">
                  <div id="one-tianya" class="fs-header">
                    <div class="user-bar fs-logos">
                    
                    
 <span id="UCLoginBar">
  <%if (ROYcms.Common.Session.Get("user_id") != null)
    { %>
  <a>欢迎 <%= ROYcms.Common.Session.Get("user")%> </a>
  <a href=/ucenter/PeopleDate.aspx >个人信息</a>
  <a href=/ucenter/logout.aspx?url=Community/default.html >注销</a>
  <%}
    else
    { %>
  <a href="/ucenter/login.aspx?url=Community/default.html">登录</a>
  <span class="vertical-seperate-line">|</span>
  <a href="/ucenter/Reg.aspx?url=Community/default.html">注册</a>
  <%} %>
  </span>

                    </div>
                    <div id="one-box-bar">
                    
<div id=gbar>
  <nobr>
  <div style="float:left; width:200px; margin-left:10px;">
   <%=___GetConfigValue("Menu")%>
  </div>
  </nobr>
</div>
                    
                   </div>
                  </div>
                  <div class="cl"></div>
                  <div id="header" class="fs-tianya-header">
                    <div class="fs-c">
                    <div style="float:left;"><img  src=<%=___GetConfigValue("Logo")%>  alt=""></div>
                      <div id="search-form">
                        <form id="search" method="get" action="Glue">
                          <div class="google_search_box">
                            <input autocomplete="off" maxlength="50" size="20" id="q_header" name="q" type="text" onfocus="this.select()" value="外汇知识">
                            <label>
                              <input type="submit" name="button" id="button" value="搜索">
                            </label>
                          </div>
                        </form>
                      </div>
                
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>