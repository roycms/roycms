<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="DbBackup.aspx.cs" Inherits="ROYcms.UI.Admin.SqlManagement_DbBackup" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
 <Resources:Resources ID="Resources1" runat="server" />
  <div>
  	

  
    <table  cellpadding="2" cellspacing="2" border="0" width="100%">


      <tr>
        <td align="left" >
        
            <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        
        <a href="/administrator/SqlManagement/Login.aspx"><img align="absmiddle" src="/administrator/images/nv6.png" />SqlManagement </a> 
        <a href="/administrator/SqlManagement/DbBackup.aspx"><img align="absmiddle" src="/administrator/images/nv8.png" />备份/还原</a> 
         <a  rel="facebox" title="执行SQL语句"  href="/administrator/SqlManagement/sql.aspx"><img align="absmiddle" src="/administrator/images/nv9.png" />执行SQL语句</a> 
     
         
        
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
        
        
        <table width="100%" cellpadding="8" cellspacing="1" bgcolor="#cccccc">
            <tr>
              <td width="15%" align="right" nowrap="nowrap" bgcolor="#F4FBFF" style="height: 19px"> SQL SERVER服务器：</td>
              <td width="85%" align="left" bgcolor="#F4FBFF" style="height: 19px">
              <asp:TextBox ID="txtSQL" runat="server" CssClass="txtInput" >(local)</asp:TextBox>
                <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置" /> (默认本机数据库)</td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF">备份名称：</td>
              <td align="left" bgcolor="#F4FBFF">
                  <asp:TextBox CssClass="txtInput" 
                      ID="BAK_name" runat="server"></asp:TextBox>
              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置" /></td>
            </tr>
            <tr>
              <td align="right" nowrap="nowrap" bgcolor="#F4FBFF">数据库备份文件路径名称：</td>
              <td align="left" bgcolor="#F4FBFF"><asp:TextBox CssClass="txtInput" ID="BAK_BOX" Width="260px" runat="server"></asp:TextBox>
              <img name="" src="/administrator/images/tick.png" width="16" height="16" alt="网站基本信息设置" /></td>
            </tr>
            <tr>
              <td align="center" bgcolor="#F4FBFF">&nbsp;</td>
              <td align="left" bgcolor="#F4FBFF">
              <asp:Button ID="wbtn_Backup" runat="server" Width="60px" Text="备 份"  CssClass="btnSubmit" OnClick="wbtn_Backup_Click"  OnClientClick="return window.confirm('确定要执行备份数据库操作吗?');" ></asp:Button></td>
            </tr>
            <tr>
              <td align="right" bgcolor="#F4FBFF">选择还原对象：</td>
              <td align="left" bgcolor="#F4FBFF">
                  <asp:DropDownList CssClass="select" ID="DropDownList_path" runat="server"  Width="200px"
                      DataSourceID="XmlDataSource_bak" DataTextField="name" 
                      DataValueField="path">
                  </asp:DropDownList>
                  <asp:XmlDataSource ID="XmlDataSource_bak" runat="server" 
                      DataFile="~/administrator/app_Config/DbBackup.xml"></asp:XmlDataSource>
&nbsp;<asp:Button CssClass="btnSubmit" ID="Button_huanyuan" runat="server" Text="还原数据库"   
                      OnClientClick="return window.confirm('确定要还原数据库操作吗?');" 
                      onclick="Button_huanyuan_Click"  />
                              &nbsp;
                              <asp:Button ID="Button_daochu" runat="server" Text="导出数据库脚本" 
                      CssClass="btnSubmit" onclick="Button_daochu_Click"  />
                              </td>
            </tr>
            <tr>
              <td colspan="2" bgcolor="#F4FBFF"> (SQL SERVER数据库默认为当前站点数据库服务器，可以填入网络上存在的一个服务器名称)</td>
            </tr>
          </table></td>
      </tr>
      <tr>
        <td colspan="2" bgcolor="#BDD6E1" align="center" style="color:Black; height: 34px;">&nbsp;</td>
      </tr>
    </table>
  </div>
</form>
</body>
</html>
