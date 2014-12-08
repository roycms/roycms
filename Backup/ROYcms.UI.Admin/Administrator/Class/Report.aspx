<%@ Page Language="C#" AutoEventWireup="true"  Inherits="ROYcms.UI.Admin.Administrator_class_Report" %>
<html>
<body>
<form id="form" runat="server">
    <table width="480" border="0" align="center" cellpadding="3" cellspacing="3">
      <tr>
        <td colspan="2"><img src="/administrator/images/information.gif" align="absmiddle" alt="ROYcms!NT" /> 频道编号[<%=Request["id"] %>] ClassId[<%=Model.ClassId %>]</td>
      </tr>
      <tr>
        <td width="9%"><img src="/Administrator/images/let.png" align="absmiddle" alt="ROYcms!NT" /></td>
        <td width="91%">[<%= Model.ClassName%>] 频道报告</td>
      </tr>
      <tr>
        <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> <a>频道文章总数:
		 <%=ArticleSize()%></a></td>
      </tr>
      <tr>
        <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> <a>等待审核总数: 未知</a></td>
      </tr>
      <tr>
        <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> <a>草稿箱文章数: 未知</a></td>
      </tr>
     <tr>
        <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> <a>回收站文章数: 未知</a></td>
      </tr>
     <tr>
       <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> <a>频道绑定模型: 无</a></td>
     </tr>
     <tr>
       <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> 频道动态地址: <a target="_blank" href='<%=GetArticleUrl(2)%>'> <%=GetArticleUrl(2)%> </a></td>
     </tr>
     <tr>
       <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> 频道静态地址: <a target="_blank" href='<%=GetArticleUrl(0)%>'> <%=GetArticleUrl(0)%><% if (System.IO.File.Exists(Server.MapPath(GetArticleUrl(0)))) { Response.Write(" [已经生成" + System.IO.File.GetCreationTime(Server.MapPath(GetArticleUrl(0))).ToString() + "]"); } else { Response.Write(" 未生成"); } %></a></td>
     </tr>
     <tr>
       <td colspan="2"><img src="/administrator/images/cms-ico7.gif" align="absmiddle" alt="ROYcms!NT" /> 频道列表地址: <a target="_blank" href='<%=GetArticleUrl(1)%>'> <%=GetArticleUrl(1)%><% if (System.IO.File.Exists(Server.MapPath(GetArticleUrl(1)))) { Response.Write(" [已经生成" + System.IO.File.GetCreationTime(Server.MapPath(GetArticleUrl(1))).ToString() + "]"); } else { Response.Write(" 未生成"); } %></a></td>
     </tr>
    </table>
</form>
</body>
</html>
