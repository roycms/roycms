

<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.Comment" Title="评论" Codebehind="Comment.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script>    $("#question").parent().addClass("hover");</script>
<div id="Topnav_tags">
      <ul>
        <li>
          <a href="?S=0">我评论的</a>
        </li>
        <li>
          <a href="?S=1">评论设置</a>
        </li>
      
      </ul>
    </div>
</asp:Content>