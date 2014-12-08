<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.AdminMap.index" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title></title>
</head>

<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div style="margin-bottom:5px;margin-top:5px; display:table; width:100%;" > 
	<table width="100%" border="0" class="tiao_top" >
              <tr>
                <td width="77%" nowrap><div class="tiao_con">
                <a  href='Insert.aspx' rel="facebox"  title="注册一个功能模块"><img align="absmiddle" src="/administrator/images/nv6.png" />注册一个功能模块</a> 
                
                </div></td>
                <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
              </tr>
        </table>
    

            <asp:Repeater ID="Repeater_admin" runat="server">
            <HeaderTemplate>
            <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
            <tr id="tiao_center">
              <td width="23" nowrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
              <td width="38" nowrap><span class="line">编号</span></td>
              <td width="139" ><span class="line">功能模块名称</span></td>
              <td width="139" ><span class="line">功能模块URL地址</span></td>
              <td width="322"><span class="line">功能模块描述</span></td>
              <td align="left"><span class="line">创建时间</span></td>
              <td width="147"></td>
            </tr>
            </HeaderTemplate>
              <ItemTemplate>
                <tr   onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td nowrap><asp:CheckBox ID="ID_list" runat="server" /></td>
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
                  <td nowrap="nowrap"><%#Eval("Name")%></td>
                  <td nowrap="nowrap"><%#Eval("Path")%></td>
                  <td nowrap="nowrap"><%#Eval("Description")%></td>
                  <td align="left" nowrap="nowrap"><%#Eval("Time")%></td>
                  <td align="center" nowrap>
                  <a rel="facebox" title='确实要编辑模块 [<%#Eval("Name")%>] 吗?'  href='Insert.aspx?Id=<%#Eval("Id")%>'>编辑 </a>
                  | <a rel="facebox" title='确实要删除模块 [<%#Eval("Name")%>] 吗?' href='#del<%#Eval("Id")%>'>删除 </a>
                  </td>
                    <div id="del<%#Eval("Id")%>" style="display:none; width:260px;">
                      <a href="?del=<%#Eval("Id")%>">删除</a>
                      <a href="?">取消</a>
                    </div>
                </tr>
              </ItemTemplate>
              <FooterTemplate>
                <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"7\">暂无记录</td></tr>" : ""%>
                  <tr>
                  <td height="25" colspan="7" bgcolor="#F4FBFF"><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                    <img src="/administrator/images/cms-ico12.gif" border="0">
                    <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif"  style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
                    <span style="float:right">显示 <asp:TextBox ID="PageSize" Text=30 runat="server" Width="30px" CssClass="txtInput"></asp:TextBox>条/页</span>
                    <center>
                      <Script Language="JavaScript" type="text/JavaScript" src="/administrator/js/page.js"></Script>
                      <script language="JavaScript">
                        <!--
                          var pg = new showPages('pg');
                          pg.pageCount = 1;  // 定义总页数(必要)
                          pg.argName = 'page';  // 定义参数名(可选,默认为page)
                          //document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
                          pg.printHtml(1);
                        //-->
                      </script>
                    </center>        
                  </td>
                </tr>
              </table>
              </FooterTemplate>
            </asp:Repeater>

          
  </div>
</form>
</body>
</html>
