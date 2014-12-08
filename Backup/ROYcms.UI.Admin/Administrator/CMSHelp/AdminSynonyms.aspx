<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSynonyms.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.CMSHelp.AdminSynonyms" %>


<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head id="Head1" runat="server">
<title>敏感词，特殊词替换</title>
</head>
<body>
<form id="AdminSynonymsForm" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap>
        <div class="tiao_con">
        <a href="InsertSynonyms.aspx"  rel="facebox" title="敏感词，特殊词替换"><img align="absmiddle" src="/administrator/images/nv6.png" />添加敏感词，特殊词替换</a> 
        </div>
        </td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>

        <asp:Repeater ID="Repeater_admin" runat="server">
         <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
                <TBODY>
                <TR id="tiao_center">
                  <TD width=23 noWrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></TD>
                  <TD width="28" nowrap="nowrap"><span class="line">编号</span></TD>
                  <TD nowrap><span class="line">要查找的词</span></TD>
                  <TD nowrap><span class="line">替代词</span></TD>
                  <TD nowrap width="100" align=center></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
              <td ><%#Eval("find")%></td>
              <td><%# Eval("REPLACE")%></td>
              <td align="center">
              <a href="InsertSynonyms.aspx?id=<%#Eval("id")%>" rel="facebox"  title='编辑 [<%#Eval("find")%>] '>编辑</a>
              | <a href="#Del<%#Eval("id") %>"  rel="facebox" title='确实要删除 [<%#Eval("find")%>] 替换吗?'>删除</a>
               <div id="Del<%#Eval("id")%>" style="display:none; width:260px;">
                      <a href="?del=<%#Eval("id")%>" class="btnSearch" style="padding:3px;">确认删除</a>
                      <a href="?" class="btnSearch" style="padding:3px;">取消</a>
               </div>
              </td>
            
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=5><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
                        <img src="/administrator/images/cms-ico12.gif" border="0">
                        <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif"  style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
                       
                        <span style="float:right">显示 <asp:TextBox ID="PageSize" OnTextChanged="PageSizeTextChanged" AutoPostBack="True" Text=<%#Application["PageSize"] %> runat="server" Width="30px" CssClass="txtInput"></asp:TextBox>条/页</span>
                          <center>
                          <Script Language="JavaScript" type="text/JavaScript" src="/Administrator/js/page.js"></Script> 
                              <script language="JavaScript">
						                    <!--
						                    var pg = new showPages('pg');
						                    pg.pageCount =<% =ViewState["PageCon"] %>;  // 定义总页数(必要)
						                    pg.argName = 'page';  // 定义参数名(可选,默认为page)
						                    //document.write('<br>Show Times: ' + pg.showTimes + ', Mood 1');
						                    pg.printHtml(1);
						                    //
						                    -->
                              </script> 
          
                           </center> 
                        
                        <div> 结果总共<% =ViewState["PageContent"]%>条数据</div> 
                        </TD>
                    </TR>
                  </TBODY>
                </TABLE>
            </FooterTemplate>
        </asp:Repeater>
</form>
</body>
</html>


