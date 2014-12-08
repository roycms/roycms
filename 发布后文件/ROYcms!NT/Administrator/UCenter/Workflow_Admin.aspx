<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Workflow_Admin.aspx.cs" Inherits="ROYcms.UI.Admin.UCenter.Workflow_Admin" %>
<%@ Register src="top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <div style="margin-bottom:5px;margin-top:5px; display:table; width:100%;"  >
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        <a href="AddWorkflow.aspx" rel="facebox" title="添加工作流"><img align="absmiddle" src="/administrator/images/nv6.png" />添加工作流</a> 
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
  
        <asp:Repeater ID="Repeater_list" runat="server">
        <HeaderTemplate>
          <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
          <TBODY>
            <tr id="tiao_center">
              <td width="23" nowrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
              <td width="28" ><span class="line">编号</span></td>
              <td nowrap><span class="line">工作流名称</span></td>
              <td><span class="line">时间</span></td>
              <td width="100" ></td>
            </tr>
        </HeaderTemplate>
          <ItemTemplate>
            <tr  onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td  nowrap><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
              <td><a href="#zhaiyao<%#Eval("id") %>" title='<%# Eval("zhaiyao") %>' rel='facebox'><%# Eval("name") %> [详情]</a>
                <div id="zhaiyao<%#Eval("id") %>" style="display:none; width:260px;">
               
                  <p><%# Eval("zhaiyao") %></p>
                </div></td>
              <td><%# Eval("time") %></td>
              <td align="center" nowrap>
              <a title='编辑<%#Eval("name")%>信息' href='Workflow_edit.aspx?id=<%#Eval("id")%>&amp;n=<%=DateTime.Now.ToString()%>'  rel='facebox'>编辑</a> | 
              <a href='#del<%#Eval("id") %>' rel='facebox' title='确实要删除【<%#Eval("name")%>】吗？' >删除</a>
                <div id="del<%#Eval("id") %>" style="display:none; width:260px;">
                  <a href='?del=<%#Eval("id")%>'  class="btnSearch" style="padding:3px;">删除</a> 
                  <a href='?' class="btnSearch" style="padding:3px;">取消</a> 
                  </div>
              </td>
            </tr>
          </ItemTemplate>
          <FooterTemplate>
           <%#Repeater_list.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"6\">暂无记录</td></tr>" : ""%>
               <tr>
                  <td colspan="6" bgcolor="#E2F1FC"><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                    <img src="/administrator/images/cms-ico12.gif" border="0">
                    <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif"  style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
                   <span style="float:right">显示 <asp:TextBox ID="PageSize" OnTextChanged="PageSizeTextChanged" AutoPostBack="True" Text=<%#Application["PageSize"] %> runat="server" Width="30px" CssClass="txtInput"></asp:TextBox>条/页</span>
                    <center>
                      <Script Language="JavaScript" type="text/JavaScript" src="/administrator/js/page.js"></Script>
                      <script language="JavaScript">
                        <!--
                        var pg = new showPages('pg');
                        pg.pageCount =<% =ViewState["PageCon"] %>;  // 定义总页数(必要)
                        pg.argName = 'page';  // 定义参数名(可选,默认为page)
                        //document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
                        pg.printHtml(1);
                        //-->
                      </script>
                    </center>
                    <div> 结果总共<% =ViewState["PageContent"]%>条数据</div> 
                    </td>
                </tr>
              </TBODY>
            </table>
          </FooterTemplate>
        </asp:Repeater>

  </div>
</form>
</body>
</html>
