<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Right.ascx.cs" Inherits="ROYcms.Community.Web.App_Community.Right" %>
<div id="rightbody">
            <div id="rightSideContent">
              <div class="module module-gadget">
                <div class="module-gadget-head-bg"></div>
                <div class="module-body">
                  <a href="Redeem" target="_blank">
                  <%=___GetConfigValue("Ads")%>
                  </a>
                  <div class="fs-redeem-history">
                    <ul>
                    
                     <asp:Repeater ID="Repeater_list" runat="server">
                  <ItemTemplate>
                       <li class="fs-redeem-history-item">
                        <a href='/Community/CommMsgs-<%#Eval("bh") %>.html'><%# Eval("user_id").ToString() == "" ? "匿名用户" : ___GetUserDate("{name}",Eval("user_id").ToString())%></a>
                        <%#Eval("title") %><span class="meta">(<%#ROYcms.Common.TimeParser.TimeNonce( Eval("Time").ToString()) %>)</span>
                      </li>
                  </ItemTemplate>
                </asp:Repeater>
                    
                    
                     
              
                    </ul>
                  </div>
                  <div class="cl"></div>
                </div>
                <div class="fs-rc fs-rctl"></div>
                <div class="fs-rc fs-rctr"></div>
                <div class="fs-rc fs-rcbl"></div>
                <div class="fs-rc fs-rcbr"></div>
              </div>
            </div>
          </div>