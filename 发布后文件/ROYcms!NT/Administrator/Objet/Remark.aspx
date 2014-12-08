<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Remark.aspx.cs" Inherits="ROYcms.UI.Admin.Remark" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head id="Head1" runat="server">
<title></title>
<style type="text/css">

</style>
</head>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div style="margin-right:5px;margin-bottom:5px;margin-top:5px; display:table;"  >
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        
        <a href="/administrator/objet/Remark.aspx?NewsId=<%= Request["NewsId"] %>" ><img align="absmiddle" src="/administrator/images/nv6.png" />当前信息评论</a> 
        <a href="/administrator/objet/Remark.aspx" ><img align="absmiddle" src="/administrator/images/nv2.png" />所有评论</a> 
     
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
          <TBODY>
        <TR id="tiao_center">
          <TD width=23 noWrap><input 
            id=topchkAll type=checkbox 
            name=topchkAll onClick="topCheckAll(form)"></TD>
          <TD width="30"><span class="line">编号</span></TD>
          <TD width="182" ><span class="line">评论者</span></TD>
          <TD width="339" ><span class="line">内容</span></TD>
          <TD width="44" align=left><span class="line">IP</span></TD>
          <TD width="84" align=middle><span class="line">时间</span></TD>
          <TD width="198"  align=middle></TD>
        </TR>
        <asp:Repeater ID="Repeater_admin" runat="server">
          <ItemTemplate>
            <tr   onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td height="25" nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
              <td height="25" ><%#Eval("userName")%></td>
              <td><%#Eval("contents")%></td>
              <td align="left"><%#Eval("Ip")%></td>
              <td align="center"><%#Eval("time")%></td>
              <td align="center" nowrap>&nbsp; <a href='/ucenter/login.aspx' target="_blank" >登入</a> | <a href='user_edit.aspx?uid=<%#Eval("id")%>&t=edit' rel='facebox'>编辑</a> | <a href='#del<%#Eval("id") %>' rel='facebox' >删除</a>
                <div id="del<%#Eval("bh") %>" style="display:none;">
                  <h3>确定删除 [<%#Eval("name") %>] 吗?</h3>
                  <a href='?t=del&bh=<%#Eval("userName")%>' >删除</a> </div></td>
            </tr>
          </ItemTemplate>
        </asp:Repeater>
        <TR>
          <TD bgColor=#E2F1FC colSpan=9><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
            <img src="/administrator/images/cms-ico12.gif" border="0">
            <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif"  style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/administrator/images/cms-K.gif"  style="width: 63px" />
            <center>
              <Script Language="JavaScript" type="text/JavaScript" src="/administrator/js/page.js"></Script>
              <script language="JavaScript">
<!--
var pg = new showPages('pg');
pg.pageCount =;  // 定义总页数(必要)
pg.argName = 'page';  // 定义参数名(可选,默认为page)
//document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
pg.printHtml(1);
//-->
      </script>
              总 [
             
              ] 条数据
            </center></TD>
        </TR>
      </TBODY>
    </TABLE>
  </div>
</form>
</body>
</html>