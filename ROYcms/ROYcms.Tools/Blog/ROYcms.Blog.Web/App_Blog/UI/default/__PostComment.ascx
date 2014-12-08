<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="__PostComment.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.__PostComment" %>
<%if (ROYcms.Common.Session.Get("user_id") != null)
  { %>
  <h3>我要评论</h3>
  <table border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td>评论标题</td>
      <td><span id="spryCommentTitle">
        <label>
          <input name="CommentTitle" type="text" id="CommentTitle" size="50" />
        </label>
        <span class="textfieldRequiredMsg">需要提供评论标题</span></span>
        <input type="hidden" name="blog_id" id="blog_id" value='<%=Request["id"] %>' />
        <input type="hidden" name="user_id" id="user_id" value='<%=ROYcms.Common.Session.Get("user_id") %>' />
        </td>
    </tr>
    <tr>
      <td>评论内容</td>
      <td><span id="spryCommentContent">
        <label>
          <textarea name="CommentContent" id="CommentContent" cols="60" rows="8"></textarea>
        </label>
        <span class="textareaRequiredMsg">需要提供评论内容</span></span></td>
    </tr>
    <tr>
      <td></td>
      <td><label>
          <input type="submit" name="button" id="button" value="提 交" />
        </label></td>
    </tr>
  </table>
<script type="text/javascript">
<!--
    var spryCommentTitle = new Spry.Widget.ValidationTextField("spryCommentTitle");
    var spryCommentContent = new Spry.Widget.ValidationTextarea("spryCommentContent", { isRequired: false });
//-->
</script>
<%}
  else
  { %>
   <p style="margin:20px;"> 你没有登录请先登录才能发表评论现在
      <a href="/ucenter/login.aspx?url=blog-<%=this.User_id %>/default.html">登录</a>
      或
      <a href="/ucenter/reg.aspx?url=blog-<%=this.User_id %>/default.html">注册</a>
    </p>
  
<%} %>