<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Answer.aspx.cs" Inherits="ROYcms.Ask.Web.Answer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>回答问题 - <%=___GetConfigValue("Title")%></title>
</head>
<body>
    <form id="form1" runat="server" action='/app_ask/Answer.aspx' >
    <div>
      <table width="100%" border="0" cellspacing="5" cellpadding="5">
        <tr>
          <td width="86%">
          <h3>回答问题</h3>
          <label>
            <textarea name="content" cols="60" rows="8" id="content"></textarea>
            <input name="question_id" type="hidden" id="question_id" value="<% =Request["question_id"] %>" />
          </label></td>
        </tr>
        <tr>
          <td>标签
            <input name="tag" type="text" id="tag" size="60" /> 
            逗号分隔(,)</td>
        </tr>
        <tr>
          <td><label>
            <input type="submit" name="button" id="button" value="提交回答" />
          </label></td>
        </tr>
      </table>
    
    </div>
    </form>
</body>
</html>
