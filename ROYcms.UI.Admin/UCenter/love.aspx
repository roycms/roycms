<%@ Page Title="" Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="true" CodeBehind="love.aspx.cs" Inherits="ROYcms.UI.Admin.UCenter.love" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script>    $("#love").parent().addClass("hover");</script>
<div id="Topnav_tags">
      <ul>
        <li>
          <a href="?S=0">我喜欢的</a>
        </li>
        <li>
          <a href="?S=1">我收藏的</a>
        </li>
      
      </ul>
    </div>

  <asp:Repeater ID="Repeater_admin" runat="server">
         <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
                <TBODY>
                <TR id="tiao_center">
                  <TD width=23 noWrap><input id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></TD>
                  <TD nowrap><span class="line">标题</span></TD>
                  <TD nowrap><span class="line">时间</span></TD>
                  <TD nowrap  width="100"></TD>
                </TR>
         </HeaderTemplate>
          <ItemTemplate>
            <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
              <td nowrap ><asp:CheckBox ID="ID_list" runat="server" /></td>
              <td></td>
              <td></td>
              <td align="center" nowrap>
              <a href="#S" title='手动处理订单'>处理</a>
              </td>
            
            </tr>
          </ItemTemplate>
            <FooterTemplate>
              <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"4\">暂无记录</td></tr>" : ""%>
               </TBODY>
                </TABLE>
            </FooterTemplate>
        </asp:Repeater>

</asp:Content>
