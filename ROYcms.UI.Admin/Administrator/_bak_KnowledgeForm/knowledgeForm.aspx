<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="knowledgeForm.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.knowledgeForm.knowledgeForm" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<html>
<head id="Head1" runat="server">
<title></title>

</head>

<body>
<form id="form1" runat="server">
<Resources:Resources ID="Resources1" runat="server" />

  <div style="margin-bottom:5px;margin-top:5px; display:table; width:100%;" > 
	<table width="100%" border="0" class="tiao_top">
              <tr>
                <td width="77%" nowrap><div class="tiao_con">
                <a href="add_form.aspx" title="添加一个智能表单"  rel="facebox"  target="_blank"><img align="absmiddle" src="/administrator/images/nv6.png" />添加一个智能表单</a> 
                
                </div></td>
                <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
              </tr>
        </table>
  
   
		<table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
            <tr id="tiao_center">
              <td width="23" nowrap><input 
            id=topchkAll type=checkbox 
            name=topchkAll onClick="topCheckAll(form)"></td>
              <td width="38" nowrap><span class="line">编号</span></td>
              <td width="139" >智能表单名称</td>
              <td width="322">描述</td>
              <td align="left">地址</td>
              <td width="116" align="center">时间</td>
              <td width="147" align="center">&nbsp; <a href='add_form.aspx' rel="facebox" ><strong>添加一个表单</strong></a></td>
            </tr>
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
            <tr>
              <td height="65" colspan="8" bgcolor="#F4FBFF"><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                <img src="/administrator/images/cms-ico12.gif" border="0">
                <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif"  style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="/administrator/images/cms-ding.gif"  style="width: 63px" />
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/administrator/images/cms-tuijian.gif"  style="width: 63px" />
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/administrator/images/cms-K.gif"  style="width: 63px" />
                <center>
                  <Script Language="JavaScript" type="text/JavaScript" src="/administrator/js/page.js"></Script>
                  <script language="JavaScript">
<!--
var pg = new showPages('pg');
pg.pageCount =10;  // 定义总页数(必要)
pg.argName = 'page';  // 定义参数名(可选,默认为page)
//document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
pg.printHtml(1);
//-->
      </script>
                  总 [
                  <% = 1*30 %>
                  ] 条数据
                </center></td>
            </tr>
          </table>
  </div>
</form>
</body>
</html>
