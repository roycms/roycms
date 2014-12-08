<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator.Model.AdminModel" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>

<body>
<form id="form1" runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
	<table width="100%" border="0" class="tiao_top" >
              <tr>
                <td width="77%" nowrap><div class="tiao_con">
                <a  href='AddModel.aspx' rel="facebox"  title="添加一个模型"><img align="absmiddle" src="/administrator/images/nv6.png" />添加一个模型</a> 
                
                </div></td>
                <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
              </tr>
        </table>
    

            <asp:Repeater ID="Repeater_admin" runat="server">
            <HeaderTemplate>
            <table border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
            <tr id="tiao_center">
              <td width="23" nowrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
              <td width="28" nowrap><span class="line">编号</span></td>
              <td nowrap><span class="line">自定义模型名称</span></td>
              <td nowrap><span class="line">表格名称</span></td>
              <td nowrap><span class="line">自定义模型描述</span></td>
              <td nowrap><span class="line">初始化状态</span></td>
              <td nowrap><span class="line">创建时间</span></td>
              <td width="100" nowrap></td>
            </tr>
            </HeaderTemplate>
              <ItemTemplate>
                <tr   onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
                  <td nowrap><asp:CheckBox ID="ID_list" runat="server" /></td>
                  <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("Id") %>'></asp:Label></td>
                  <td nowrap="nowrap"><%#Eval("Name")%></td>
                  <td nowrap="nowrap"><%#Eval("TableName")%></td>
                  <td nowrap="nowrap"><%#Eval("ModelDescription")%></td>
                   <td nowrap="nowrap"><%# new ROYcms.Sys.BLL.CMS().Exists(Eval("TableName").ToString())==true?"成功":"未初始化"%></td>
                  <td nowrap="nowrap"><%#Eval("TIME")%></td>
                  <td align="center" nowrap><a rel="facebox" title='确实要删除模块 [<%#Eval("Name")%>] 吗?' href='#del<%#Eval("Id")%>'>删除 </a>
                   | <a title="配置模型字段" href="ConfigModel.aspx?Rid=<%#Eval("Id")%>&TableName=<%#Eval("TableName")%>">配置</a></td>
                    <div id="del<%#Eval("Id")%>" style="display:none; width:260px;">
                    <p style="color:Red; margin-bottom:5px;">注意：删除数据模型后模块儿和频道所对应的数据模型扩展关联也将删除。</p>
                      <a href="?del=<%#Eval("id")%>" class="btnSearch" style="padding:3px;">删除</a>
                      <a href="?" class="btnSearch" style="padding:3px;">取消</a>
                    </div>
                </tr>
              </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"8\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=9><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
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
