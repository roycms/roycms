<%@ Control Language="C#" AutoEventWireup="true"  Inherits="ROYcms.Blog.Web.App_Blog.__PostComment" %>
<%if (ROYcms.Common.Session.Get("user_id") != null)
  { %>

<table width="620" border="0" cellspacing="5" cellpadding="0">
  <tr>
    <td class="f14">标　题：</td>
    <td><span id="spryCommentTitle">
        <label>
          <input name="CommentTitle" type="text" id="CommentTitle" size="50" />
      </label>
        <span class="textfieldRequiredMsg">需要提供评论标题</span></span>
        <input type="hidden" name="blog_id" id="blog_id" value='<%=Request["id"] %>' />
        <input type="hidden" name="user_id" id="user_id" value='<%=ROYcms.Common.Session.Get("user_id") %>' /></td>
  </tr>
  <tr>
    <td valign="top" class="f14" id="reTitle">内　容：</td>
    <td><span id="spryCommentContent">
        <label>
          <textarea name="CommentContent" id="CommentContent" cols="60" rows="8"></textarea>
      </label>
      <span class="textareaRequiredMsg">需要提供评论内容</span></span></td>
  </tr>
  <tr>
    <td valign="top"class="f14">&nbsp;</td>
    <td valign="top" class="f14"><input id="btn_ok" name="btn_ok" type="submit" value="发表评论" tabindex=5></td>
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



