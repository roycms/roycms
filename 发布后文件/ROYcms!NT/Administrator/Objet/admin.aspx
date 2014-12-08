<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_Objet_admin" CodeBehind="admin.aspx.cs" ValidateRequest="false" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
</head>
<body>
<form runat="server">
  <Resources:Resources ID="Resources1" runat="server" />
  <table width="100%" border="0" class="tiao_top">
    <tr>
      <td width="77%" nowrap><div class="tiao_con"> 
      <%if (Request["class"] != null)
        { %>
      <a href="/administrator/objet/insert.aspx?Classkind=<% =ViewState["ClassKind"] %>&Class=<% =Request["class"] %>">
      <img align="absmiddle" src="/administrator/images/nv6.png" />添加信息</a> 
      <%} %>
      <a href="/administrator/objet/admin.aspx?Classkind=<% =ViewState["ClassKind"] %>">
      <img align="absmiddle" src="/administrator/images/nv8.png" />管理信息</a> 
      <a href='/administrator/class/index.aspx?ClassKind=<% =ViewState["ClassKind"] %>'>
      <img align="absmiddle" src="/administrator/images/nv9.png" />分类管理</a> 
      </div></td>
      <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
    </tr>
  </table>
  <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-bottom:0px; margin-top:5px;">
    <tr>
      <td nowrap><img src="/administrator/images/funnel.png" width="16" height="16" align="absmiddle">
        <asp:DropDownList ID="DdlMenu" runat="server" CssClass="select" Width="100px" AutoPostBack="True" onselectedindexchanged="DdlMenu_SelectedIndexChanged">
         <asp:ListItem Value="0">文章频道</asp:ListItem>
        </asp:DropDownList>
          <asp:DropDownList ID="DdState" runat="server" CssClass="select" Width="78px"  AutoPostBack="True" onselectedindexchanged="DdState_SelectedIndexChanged">
              <asp:ListItem Value="0">文章状态</asp:ListItem>
              <asp:ListItem Value="1">已经发布</asp:ListItem>
              <asp:ListItem Value="2">草稿箱</asp:ListItem>
              <asp:ListItem Value="3">回收站</asp:ListItem>
          </asp:DropDownList>
          <asp:DropDownList ID="DdAttribute" runat="server" CssClass="select" Width="78px"  AutoPostBack="True" onselectedindexchanged="DdAttribute_SelectedIndexChanged">
              <asp:ListItem Value="0">文章属性</asp:ListItem>
              <asp:ListItem Value="1">置顶</asp:ListItem>
              <asp:ListItem Value="2">推荐</asp:ListItem>
              <asp:ListItem Value="3">头条</asp:ListItem>
          </asp:DropDownList>
         <asp:DropDownList ID="DdTime" runat="server" CssClass="select" Width="78px"  AutoPostBack="True" onselectedindexchanged="DdTime_SelectedIndexChanged">
              <asp:ListItem Value="0">发布时间</asp:ListItem>
              <asp:ListItem Value="1">1天内发表</asp:ListItem>
              <asp:ListItem Value="2">2天内发表</asp:ListItem>
              <asp:ListItem Value="3">3天内发表</asp:ListItem>
              <asp:ListItem Value="3">更早发表</asp:ListItem>
          </asp:DropDownList>
      </td>
      <td width="25%" align="right" nowrap>
        <input name="keywords" id="keywords" type="text" class="txtInput" style="width:120px;height:21px" title="输入新闻标题关键词进行搜索！" runat="server">
        <asp:Button ID="Submit" CssClass="btnSearch" runat="server" Text="搜索" onclick="Submit_Click" />
      </td>
    </tr>
  </table>
 
    <asp:Repeater ID="Repeater_admin" runat="server">
    <HeaderTemplate>
    <table cellpadding="5" cellspacing="1" border="0" width="100%"  class="Tb" style="margin-right:5px; margin-bottom:5px;margin-top:5px;" >
    <tr id="tiao_center">
      <td width="23" nowrap><input  id=topchkAll type=checkbox name=topchkAll onClick="topCheckAll(form)"></td>
      <td width="28" nowrap><span class="line">编号</span></td>
      <td nowrap><span class="line">栏目</span></td>
      <td nowrap><span class="line">标题</span></td>
      <td nowrap><span class="line">作者</span></td>
      <td nowrap><span class="line">录入日期</span></td>
      <td nowrap><span class="line">置顶 | 推荐</span></td>
      <td nowrap><span class="line">状态</span></td>
      <td width="100" align="center" nowrap><span class="line">操作</span></td>
    </tr>
    </HeaderTemplate>
    
      <ItemTemplate>
        <tr onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
          <td nowrap><asp:CheckBox ID="ID_list" runat="server" onclick="javascript:chkRow(this);" /></td>
          <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("bh") %>'></asp:Label></td>
          <td nowrap>
          <a rel="facebox" title="频道" href="#classContent<%#Eval("bh") %>"><%#get_classname(Convert.ToInt32(Eval("classname"))) %></a>
            <div id="classContent<%#Eval("bh") %>" style="display:none;">
              <h3>分类详情</h3>
              <p>分类名称:[<%#Eval("classname") %>]<%#get_classname(Convert.ToInt32(Eval("classname"))) %></p>
            </div>
            </td>
          <td>
          <a href='Insert.aspx?id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>'> <%#Eval("title") %> </a> 
          <a rel="facebox" title="摘要" href='#zhaiyao<%#Eval("bh") %>'><img src="/administrator/images/tag.png" alt="查看摘要" border="0" title='<%#Eval("zhaiyao") %>'></a>
            <div id="zhaiyao<%#Eval("bh") %>"  style="display:none;">
              <h3>信息摘要</h3>
              <p><%#Eval("zhaiyao") %></p>
            </div></td>
          <td nowrap><a rel="facebox" href="#author<%#Eval("bh") %>"><%#Eval("author")%></a>
            <div id="author<%#Eval("bh") %>" style="display:none;">
              <h3>作者详情</h3>
              <p><%#Eval("author") %></p>
            </div></td>
          <td nowrap><%#Eval("time")%></td>
          <td nowrap><a href='?t=ding&id=<%#Eval("bh") %>&ding=<%#Eval("ding") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>&page=<% =ViewState["Page"] %>'><b><font color="#FF3300" title="点击置顶"><%#Eval("ding").ToString().Trim()=="0"?"√":"X"%></font></b></a> &nbsp;&nbsp; <a href='?t=tuijian&id=<%#Eval("bh") %>&tuijian=<%#Eval("tuijian") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>&page=<% =Request["page"] %>'><b><font color="#FF3300" title="点击推荐。"><%#Eval("tuijian").ToString().Trim()=="0"?"√":"X"%></font></b></a></td>
          <td nowrap><a href='?t=K&id=<%#Eval("bh") %>&K=<%#Eval("switchs") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>&page=<% =ViewState["Page"] %>'><b><font color="#FF3300" title="点击关闭。"><%#Eval("switchs").ToString().Trim()=="0"?"√":"X"%></font></b></a></td>
          <td align="center" nowrap>
          <a href='<%# new ROYcms.Templet.GetMyUrl().GetArticle(Convert.ToInt32(Eval("bh"))) %>' target=_blank>详情</a>
           | <a href='Insert.aspx?id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>'>编辑</a>
           | <a  href='#del<%#Eval("bh") %>' rel='facebox' title='确定删除 [<%#Eval("title")%>] 吗?'>删除</a>
            <div id="del<%#Eval("bh") %>" style="display:none; width:260px;">
               <p style="color:Red; margin-bottom:5px;">注意：将级联删除用户对信息的评论以及生成的静态文件以及所关联的附件和相册信息。</p>
                  <a href='?t=del&id=<%#Eval("bh") %>&class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>' class="btnSearch" style="padding:3px;">删除</a> 
                  <a href='?class=<%#Eval("classname") %>&ClassKind=<% =ViewState["ClassKind"] %>' class="btnSearch" style="padding:3px;">取消</a> 
            </div>
           
           </td>
        </tr>
      </ItemTemplate>
      
      <FooterTemplate>
      <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\">暂无记录</td></tr>" : ""%>
     
      <tr>
      <td colspan="9" bgcolor="#E2F1FC">
      <input name="chkAll" type="checkbox" id="chkAll" onClick="CheckAll(form)" value="checkbox" style="position:absolute; clip: rect(6 15 15 6)">
      <img src="/administrator/images/cms-ico12.gif" border="0">
      <asp:ImageButton ID="ImageButton_all_del" runat="server" ImageUrl="/administrator/images/cms-ico10.gif" onclick="ImageButton_all_del_Click" style="width: 63px" OnClientClick="return window.confirm('确定删除多条记录吗?');"  />
      <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="/administrator/images/cms-ding.gif" onclick="ImageButton_ding_Click" style="width: 63px" />
      <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/administrator/images/cms-tuijian.gif" onclick="ImageButton_tuijian_Click" style="width: 63px" />
      <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/administrator/images/cms-K.gif" onclick="ImageButton_K_Click" style="width: 63px" />
      
      
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
       </td>
    </tr>
  </table>
    </FooterTemplate>
    </asp:Repeater>

</form>
</body>
</html>