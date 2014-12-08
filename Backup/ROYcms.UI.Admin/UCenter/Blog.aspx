<%@ Page Title="" Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="ROYcms.UI.Admin.UCenter.Blogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script>    $("#blog").parent().addClass("hover");</script>
  <div id="Topnav_tags">
      <ul>
        <li>
          <a href="?S=0">我的博客文章</a>
        </li>
        <li>
          <a href="?S=1">博客设置</a>
        </li>
        <li>
          <a href="?S=2">名博推荐</a>
        </li>
      </ul>
    </div>
    <dl class="feed_block">
      <%if (ROYcms.Common.Request.GetQueryInt("S") == 0)
        {%>
      <asp:Repeater ID="Repeater_list" runat="server">
        <ItemTemplate>
          <dt class="current">
            <a>分类:</a>
            <a>111111</a>
            <span class="font_666">222222222</span></dt>
          <dd> 33333 <img src="images/quote-end.gif" width="14" height="10" /></dd>
        </ItemTemplate>
         <FooterTemplate>
              <%#Repeater_list.Items.Count == 0 ? "暂无记录" : ""%>
                  </TBODY>
                </TABLE>
            </FooterTemplate>
      </asp:Repeater>
      <%}
        else if (ROYcms.Common.Request.GetQueryInt("S") == 1)
        { %>
        博客设置暂时未开通
      <%} %>

    </dl>
</asp:Content>
