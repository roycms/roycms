<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UPfile_zip.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.config.UPfile_zip" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<html>
<body>
<form id="form1" runat="server"> 
   <table width="360px"  border="0" align="center" cellpadding="0" cellspacing="10">
            <tr>
              <td>
  
<div id="divUpload">
<h3>上传并解压文件</h3>
<span style=" margin-bottom:10px;">支持zip文件解压，按照压缩包的文件结构直接解压到根目录</span>
      <asp:FileUpload ID="FileUpload1" runat="server" />
       <asp:Button ID="btnUpload" runat="server" Text="上传并解压"  OnClick="btnUpload_Click"/>
   </div>
  
              </td>
            </tr>
          </table>
</form>
</body>
</html>

