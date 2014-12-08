<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCRight.ascx.cs" Inherits="ROYcms.UI.Admin.UCenter.UCRight" %>
    <!--right_sidebar begin-->
    <div id="right_sidebar">
      <div class="right_content_wrapper">
        » <a href="/ucenter/XClass.aspx?url=Delivery.aspx">意见反馈</a><br />
        » <a href="/help.ashx">会员帮助中心</a>
      </div>
      <div class="right_content_wrapper">
        <h2>站内搜索</h2>
        <div id="SearchBar">
            <asp:TextBox ID="TextBoxSearch" runat="server" CssClass="txtInput"></asp:TextBox>
            <asp:Button ID="ButtonSearch" runat="server" Text="搜索" onclick="ButtonSearch_Click" CssClass='btnSearch' />
        </div>
      </div>
    </div>
<!--right_sidebar end-->