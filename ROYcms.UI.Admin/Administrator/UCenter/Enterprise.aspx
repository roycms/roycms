<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Enterprise.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator_Enterprise_Enterprise" %>

<!DOCTYPE HTML>
<html >
<head runat="server">
    <title></title>
    <link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
    <link href="/administrator/WebUI/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">
</head>
<script language = "JavaScript">
function CheckAll(form)
  {
  for (var i=0;i<form.elements.length;i++)
    {
    var e = form.elements[i];
    if (e.Name != "chkAll"&&e.disabled==false)
       e.checked = form.chkAll.checked;
    }
}
</script>
<body>
    <form id="form1" runat="server">
    
    
    
        <table width="100%" border="0" align="center" cellpadding="5" cellspacing="5">
      <tr>
        <td>
        <fieldset>
        <legend>&nbsp;<img name="" src="/administrator/images/bullet_wrench.png" width="16" height="16" alt="">&nbsp;会员管理</legend>
                        <br />
        
      <table width="98%" height="53" border="0" align="center" cellpadding="5" cellspacing="1" bgcolor="#CCCCCC">
        <tr class="TabbedPanelsTabHover">
        <td width="23" height="25" nowrap></td>
          <td width="28" nowrap><span class="line">编号</span></td>
          <td width="139" height="25">登录名</td>
          <td width="322">公司名称</td>
          <td width="161" align="left">qq</td>
          <td width="200" align="center">权限</td>
          <td width="116" align="center">密码</td>
          <td width="147" align="center">&nbsp;</td>
          </tr> 
        
        <asp:Repeater ID="Repeater_admin_user" runat="server">
          <ItemTemplate>
            <tr>
             <td height="25" nowrap bgcolor="#F4FBFF"><asp:CheckBox ID="ID_list" runat="server" /></td>
             <td nowrap  bgcolor="#F4FBFF"><asp:Label ID="Label_id" runat="server" Text='<%#Eval("bh") %>'></asp:Label>
              </td>
              <td height="25" bgcolor="#F4FBFF"><%#Eval("name")%></td>
              <td bgcolor="#F4FBFF"><%# get_Enterprise(Eval("bh").ToString())%></td>
              <td align="left" bgcolor="#F4FBFF"><%#Eval("qq")%></td>
              <td align="center" bgcolor="#F4FBFF"><%#Eval("quanxian").ToString() == "Enterprise"?"企业用户":"个人用户"%></td>
              <td align="center" bgcolor="#F4FBFF"><%#Eval("password")%></td>
              <td align="center" nowrap bgcolor="#F4FBFF"><a href='?bh=<%#Eval("bh")%>&t=tj'>推荐</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href='user_edit.aspx?uid=<%#Eval("bh")%>&t=edit'>编辑</a>&nbsp; |&nbsp; <a href='?t=del&bh=<%#Eval("bh")%>' onClick="return window.confirm('确定删除 [<%#Eval("name") %>] 吗?');">删除</a></td>
              </tr>
            </ItemTemplate>
          </asp:Repeater>
          
        <tr>
          <td height="25" colspan="9" bgcolor="#F4FBFF">
            

            
            <input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
            <img src="/administrator/images/cms-ico12.gif" border="0">
            <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif" onclick="ImageButton_all_del_Click" OnClientClick="return window.confirm('确定删除多条记录吗?');" style="width: 63px" />      
          
            
            <center>
            
            <Script Language="JavaScript" type="text/JavaScript" src="/administrator/js/page.js"></Script>
            <script language="JavaScript">
<!--
var pg = new showPages('pg');
pg.pageCount =<% =pages %>;  // 定义总页数(必要)
pg.argName = 'page';  // 定义参数名(可选,默认为page)
//document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
pg.printHtml(1);
//-->
      </script>
               总 [<% = pages*30 %>] 条数据
            </center>
            
            
          </td>
          </tr>
          
          
      </table>

   </fieldset>        </td>
      </tr>
    </table>
        
 
    </form>
</body>
</html>
