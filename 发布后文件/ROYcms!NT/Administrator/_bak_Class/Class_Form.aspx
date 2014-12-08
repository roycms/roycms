<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Class_Form.aspx.cs" Inherits="ROYcms.UI.Admin.Class_Form" %>
<!DOCTYPE HTML>
<html >
<body>
<form id="form1" runat="server">
    <p><a style="margin-left:5px; color:#F66; ">预览当前表单请选择该分类发布然后切换到扩展属性选项卡</a></p>
 

      <asp:Repeater ID="Repeater_admin" runat="server">
        <ItemTemplate>
           
            
            <table width="201" border="1" cellpadding="2" cellspacing="2">
              <tr>
                <td><img name="" src="/administrator/images/tree.gif" alt="" /> <%#Eval("title")%></td>
                <td><a href='Class_form.aspx?From_id=<%#Eval("id")%>&From_GUID=<%#Eval("GUID")%>&class_id=<% =Request["id"]%>&classkind=<% =Request["classkind"]%>'>选择</a></td>
              </tr>
            </table>
  
        </ItemTemplate>
      </asp:Repeater>
   <table width="100" border="0" cellpadding="4" cellspacing="4">
      <tr>
        <td nowrap="nowrap">
        <a href="Class_form.aspx?del=<% =Request["id"]%>&classkind=<% =Request["classkind"]%>">删除关联的智能表单扩展 </a>
        </td>
      
      </tr>
    </table>

</form>
</body>
</html>
