<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertSynonyms.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.CMSHelp.InsertSynonyms" %>

<!DOCTYPE HTML>
<html>
<body>
<form id="InsertSynonymsForm" runat="server">
    <table cellSpacing="2" cellPadding="2" width="360" border="0">
      <tr>
        <td height="25" width="30%" align="right">查找的词</td>
        <td height="25" width="*" align="left">
        <input name="id"  type="hidden" id="id" value='<%=Model.id %>' >
        <input name="find" id="find" type="input" value='<%=Model.find%>' class="txtInput">
        </td>
      </tr>
      <tr>
        <td height="25" align="right">替代词</td>
        <td height="25" align="left"><input name="REPLACE" id="REPLACE" type="input" value='<%=Model.REPLACE%>' class="txtInput"></td>
      </tr>
      <tr>
        <td height="25" width="30%" align="right">&nbsp;</td>
        <td height="25" width="*" align="left">
        <input type="button" name="InsertSynonymsBT" id="InsertSynonymsBT" value="提交" class="btnSearch">
        <input type="reset" name="noBT" id="noBT" value="重置" class="btnSearch"></td>
      </tr>
    </table>
</form>
</body>
</html>

