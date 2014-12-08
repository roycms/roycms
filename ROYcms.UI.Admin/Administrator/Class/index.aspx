<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_class_index"  %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<head>
<title></title>
</head>
<body>
<form id="form" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
<div style="margin-right:5px;margin-bottom:5px;margin-top:2px;width:100%;"  >
     <table width="100%" border="0" class="tiao_top" style="margin-bottom:2px; padding-right:5px;">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        <a href='Insert.aspx?ClassKind=<% =ClassKind %>'><img align="absmiddle" src="/administrator/images/nv6.png" />增加顶级频道</a> 
        <a href="/administrator/objet/admin.aspx?Classkind=<% =this.ClassKind %>"><img align="absmiddle" src="/administrator/images/nv8.png" />管理信息</a> 
        <a href='/administrator/class/index.aspx?ClassKind=<% =ClassKind %>'><img align="absmiddle" src="/administrator/images/nv9.png" />分类管理</a> 
       </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
     </table>
     <asp:Repeater ID="rptMenuList" runat="server" OnItemDataBound="rptMenuList_ItemDataBound">               
            <HeaderTemplate>
                <table class="main_table" cellpadding="0" cellspacing="0" border="0" width="100%" style="border:1px solid #E7E7E7;">
                <tr align="center" class="td_title"  id="tiao_center" height="30px;">
                <td width="53%" align="left" class="enfont2">
                <img src="/administrator/images/lightbulb_add.png" width="16" align="absmiddle" height="16" border="0"> 提示：频道操作注意事项。</td>
                <td width="47%" align="right" nowrap>
                <span style="display:none"><input type="submit" name="buttonbutton" id="buttonbutton"  /></span>      
                </td>
                </tr>
            </HeaderTemplate>
                      
             <ItemTemplate>
                <tr onmouseover="this.style.background='#EEF7FD'" onmouseout="this.style.background='#fafafa'" style="height:24px;" >
                <td nowrap style="padding-left:5px;">
                    <asp:CheckBox ID="CheckBoxId" runat="server" />
                    <asp:HiddenField ID="txtClassId" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"ClassId") %>' />
                    <asp:Literal ID="LitFirst" runat="server"></asp:Literal>
                    <a rel="facebox" title="频道信息统计" href='Report.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Id") %>'>
                    <asp:Label ID="LabClassNm" runat="server" Text=' <%#DataBinder.Eval(Container.DataItem,"ClassName")%> '></asp:Label>
                    </a>
                    <%#" [ID:"+ DataBinder.Eval(Container.DataItem,"Id").ToString()+"]"%> 
                    <a  href='Insert.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Id") %>&ClassId=<%#DataBinder.Eval(Container.DataItem,"ClassId") %>&ClassKind=<% =ClassKind %>&ClassPre=<%#DataBinder.Eval(Container.DataItem,"ClassPre") %>'> 
                    <img src="/administrator/images/wand.png" width="16" height="16" border="0">
                    </a>
                </td>
                <td align="right" nowrap>
                <a rel="facebox" title="生成[<%#DataBinder.Eval(Container.DataItem,"ClassName")%>]频道静态文件" href='/administrator/NewHtml/NewList.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Id") %>&ClassId=<%#DataBinder.Eval(Container.DataItem,"ClassId") %>&ClassKind=<% =ClassKind %>' > 生成</a> 
                <span class="ColumnsTypeNo<%#DataBinder.Eval(Container.DataItem,"ClassId") %>" >
                    | <a href='/administrator/objet/Insert.aspx?Class=<%#DataBinder.Eval(Container.DataItem,"Id") %>&ClassKind=<% =ClassKind %>'>发布信息</a>
                    | <a href='/administrator/objet/admin.aspx?Class=<%#DataBinder.Eval(Container.DataItem,"Id") %>&ClassKind=<% =ClassKind %>'>管理信息</a>
                    | <a rel="facebox" title="批量转移信息" href='go_class.aspx?ClassKind=<% =ClassKind %>&ClassId=<%#DataBinder.Eval(Container.DataItem,"ClassId") %>'> 转移</a>
                </span>    <!--判断文章类型-->
                <%#DataBinder.Eval(Container.DataItem, "ColumnsType").ToString().Trim() == "2" ? "<script>$('.ColumnsTypeNo" + DataBinder.Eval(Container.DataItem, "ClassId") + "').hide();</script>" : ""%>
                | <a  href='Insert.aspx?ClassId=<%#DataBinder.Eval(Container.DataItem,"ClassId") %>&ClassKind=<% =ClassKind %>'> 添加子频道</a>
                | <a  href='Insert.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Id") %>&ClassId=<%#DataBinder.Eval(Container.DataItem,"ClassId") %>&ClassKind=<% =ClassKind %>&ClassPre=<%#DataBinder.Eval(Container.DataItem,"ClassPre") %>'> 配置</a>
                | <a href='#del<%#Eval("id")%>' rel="facebox" title='确实要删除 [<%#Eval("ClassName")%>]频道吗?'> 删除 </a>
                 <div id="del<%#Eval("id")%>" style="display:none; width:260px;">
                      <p style="color:Red; margin-bottom:5px;">注意：删除频道将删除该频道下的所有子频道并且同步删除频道下数据，请提前将频道下数据转移到其他频道。</p>
                      <a href="?del=<%#Eval("ClassId")%>&ClassKind=<% =ClassKind %>" class="btnSearch" style="padding:3px;">确认删除</a>
                      <a href="?ClassKind=<% =ClassKind %>" class="btnSearch" style="padding:3px;">取消</a>
                    </div>
                <span style=" display:none">
                <asp:TextBox CssClass="input" ID="txtOrder" Height="18" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"ClassOrder") %>' Width="26"></asp:TextBox>
                </span>
                </td>
                </tr>       
              </ItemTemplate>
                        
               <FooterTemplate>
                      <%#rptMenuList.Items.Count == 0 ? "<tr><td align=\"center\" style=\"padding:5px;\"><a href=Insert.aspx?ClassKind="+ ClassKind +">暂无频道记录，请点击增加顶级频道</a></td></tr>" : ""%>  
                      <tr class="td_on" onMouseOver="this.className='td_off'" onMouseOut="this.className='td_on'" bgcolor="#E7E7E7">
                        <td height="30" align="left" bgcolor="#E2F1FC">
                        <label style="padding-left:5px;"><input  id=chkAll type=checkbox  name=chkAll onClick="CheckAll(form)" style="vertical-align:middle;"> 全选</label>
                        </td>
                        <td height="30" align="right" nowrap bgcolor="#E2F1FC">
                        <asp:Button CssClass="btnSearch"  ID="Btn_all_del" runat="server" Text="批量删除频道" />
                        <asp:Button CssClass="btnSearch"  ID="Btn_huancun" runat="server" Text="更新频道缓存" />
                        <span style=" display:none">
                        <asp:Button CssClass="btnSearch" Font-Bold="true"  ID="BtnSave" runat="server" Text=" 更新频道顺序 " Width="92" OnClick="BtnSave_Click" />
                        </span>
                       </td>
                      </tr>
                    </table>
              </FooterTemplate>         
       </asp:Repeater>
</div>
</form>
</body>
</html>
