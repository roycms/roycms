

<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.Rss" Title="订阅中心" Codebehind="Rss.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script>$("#current").parent().addClass("hover");</script>
    <div id="Topnav_tags">
      <ul>
        <li>
          <a href="/ucenter/default.aspx">站内公告</a>
        </li>
        <li>
          <a href="/ucenter/rss.aspx">我订阅的</a>
        </li>
        <li>
          <a href="/ucenter/default.aspx">收听设置</a>
        </li>
          <li>
          <a href="AddRss.aspx" rel="facebox" title="订阅我的信息">订阅</a>
        </li>
      </ul>
    </div>
<dl class="feed_block" style="margin-left:15px;">
<asp:Repeater ID="Repeater_list" runat="server">
<ItemTemplate>
<dt class="ing">
<%#Eval("name")%>
<a href=<%#Eval("url")%> target=_blank><%#Eval("url")%></a>   
 <%#Eval("user_id").ToString() == ROYcms.Common.Session.Get("user_id") ? " <a title='" + Eval("name") + "'  href='#del" + Eval("id") + "' rel=facebox>删除</a>" : ""%>
<div id="del<%#Eval("id")%>" style=" display:none;">
<h3>确实要删除[<%#Eval("name")%>]吗？</h3>
<a href='?del=<%#Eval("id")%>'>删除</a>
 </div>
 </dt>
</ItemTemplate>
</asp:Repeater>
</dl>


</asp:Content>
