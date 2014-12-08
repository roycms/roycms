<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_knowledge_Form" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>生成静态文件...</title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
<script src="/administrator/WebUI/jQuery/jquery.js" type="text/javascript"></script>
    <form id="form1" runat="server">
    <div id=con runat="server">
        <center>
          <table width="200" border="0" align="center" cellpadding="10" cellspacing="0">
          <tr>
            <td align="center">
<fieldset>
<div id=con>
  <table width="100%" border="0" cellspacing="0" cellpadding="10">
    <tr>
      <td align="center">
      
               
     
             <table width="100%" border="0" cellspacing="3" cellpadding="0"> 
                <asp:Repeater ID="Repeater_admin" runat="server">
              <ItemTemplate>
                <tr  onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td  nowrap><asp:CheckBox ID="ID_list" runat="server" /></td>
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
                  <td  nowrap="nowrap" ><a href="preview.aspx?id=<%#Eval("id") %>" target="_blank" ><%#Eval("title")%></a></td>
                  <td nowrap="nowrap"><%#Eval("zhaiyao")%></td>
                  <td align="left" nowrap="nowrap"><%#Eval("Path")%></td>
                  <td align="center" nowrap="nowrap"><%#Eval("Time")%></td>
                  <td align="center" nowrap>&nbsp; <a href='edit_Form.aspx?id=<%#Eval("id")%>&n=<%=DateTime.Now.ToString()%>' rel="facebox">编辑</a> | <a href='#del<%#Eval("id")%>' rel="facebox">删除 </a></td>
                  <div id="del<%#Eval("id")%>" style="display:none;">
                    <h3>确实要删除模块 [<%#Eval("title")%>] 吗?</h3>
                    <br />
                    <a href="?del=<%#Eval("id")%>">删除</a> </div>
                </tr>
              </ItemTemplate>
            </asp:Repeater>
             

        </table>
        <hr width="100%" style="margin-top:8px; margin-bottom:-5px;" />
        </td>
    </tr>
  </table>
  <table width="100%" height="50" border="0" cellpadding="10" cellspacing="0">
    <tr>
      <td height="50" align="left" valign="top"><font color="#FF0000"> 注：导入后！</font></td>
      </tr>
  </table>
  </div>
<img id="wait" src="/administrator/images/wait.gif" width="90" height="20" style="display:none" />
</fieldset></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="2">
            <tr>
              <td width="98%" align="right"><font color="#999999" style=" font-size:9px">®ROYcms!NT 2009 </font></td>
              <td width="5px" align="right"></td>
            </tr>
          </table>
       </center>
    </div>
    </form>
</body>
</html>