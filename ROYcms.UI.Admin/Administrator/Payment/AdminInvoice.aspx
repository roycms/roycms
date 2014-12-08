<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminInvoice.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Payment.AdminInvoice" %>

<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head id="Head1" runat="server">
<title>发票申领管理</title>
</head>
<body>
<form id="AdminInvoiceForm" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
    <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap>
        <div class="tiao_con">
        <a href="AdminInvoice.aspx" title="发票申领管理"><img align="absmiddle" src="/administrator/images/nv6.png" />发票申领管理</a> 
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
              
                  <TD width="28" nowrap="nowrap"><span class="line">编号</span></TD>
                  <TD nowrap><span class="line">申领人</span></TD>
                  <TD nowrap><span class="line">发票抬头</span></TD>
                  <TD nowrap ><span class="line">申领金额</span></TD>
                  <TD nowrap><span class="line">邮寄方式</span></TD>
                  <TD nowrap><span class="line">联系人</span></TD>
                  <TD nowrap><span class="line">电话</span></TD>
                  <TD nowrap><span class="line">手机</span></TD>
                  <TD nowrap><span class="line">创建时间</span></TD>
                  <TD nowrap  width="100"></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
         
                    <td><%#Request["page"]==null?Container.ItemIndex+1:(((Convert.ToInt32(Request["page"])-1))*Convert.ToInt32(Application["PageSize"]==null?"20":Application["PageSize"])+Container.ItemIndex+1 )%></td>
              <td nowrap>

<%#
                   
                  (new ROYcms.Sys.BLL.ROYcms_user().GetModel(Convert.ToInt32(Eval("UserID")))==null?"":new ROYcms.Sys.BLL.ROYcms_user().GetModel(Convert.ToInt32(Eval("UserID"))).name)
                  
                  %>
              </td>
              <td nowrap><%# Eval("InvoiceName")%></td>
              <td nowrap><%#Eval("Price")%></td>
              <td nowrap><%#Eval("PostType")%></td>
              <td nowrap><%#Eval("RealName")%></td>
              <td nowrap><%#Eval("Tel")%></td>
              <td nowrap><%#Eval("Mobil")%></td>
              <td nowrap><%#Eval("CreateTime")%></td>
              <td align="center" nowrap>
                  <%#Eval("State").ToString()=="0"?"<a href='#D"+Eval("Id") +"' rel='facebox' title='标注为已处理'>标注为已处理</a>":"已处理"%>
              
                  <div id="D<%#Eval("Id") %>" style="display:none; width:360px;">
                      <textarea id="AdminRemark" rows="3" cols="50" name="AdminRemark" runat="server"></textarea>
                      <a class="btnSearch" id="BT<%#Eval("Id") %>" href="?Id=<%#Eval("Id") %>&State=1">确认处理</a>
                  </div>
              </td>
            
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"10\">暂无记录</td></tr>" : ""%>

                  <TR>
                      <TD bgColor=#E2F1FC colSpan=10><input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute;clip: rect(6 15 15 6)">
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

