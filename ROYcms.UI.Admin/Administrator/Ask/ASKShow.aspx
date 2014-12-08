<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASKShow.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Ask.ASKShow" %>


<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>商品管理</title>
</head>
<body>
   <form id="form1" runat="server">

          <Resources:Resources ID="Resources1" runat="server" />

          <div style="margin-right:5px;margin-bottom:5px;margin-top:5px; display:table; width:100%"  >
    <table width="100%" border="0" class="tiao_top">
      <tr>
       <td width="77%" nowrap><div class="tiao_con">
        <a href="?"><img align="absmiddle" src="/administrator/images/rosette.png" />会员等级管理</a>
     
        </div></td>
       <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>


              
            <div style="margin-bottom:10px; margin-top:10px;">
               问题标题： <%=  ASKModel.Title %><br />
               问题内容：<%=ASKModel.Contents %>

            </div>

       




               <h4>已经回答的信息</h4> 
                <table  border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb">
                   <asp:Repeater ID="Repeater_admin" runat="server">
                    <HeaderTemplate>
    <thead>
  <tr  id="tiao_center">
    <td>编号</td>
    <td>回答标题</td>
    <td>回答内容</td>
   
   <td>时间</td>
  
  </tr>
  </thead>
  <tbody>
  </HeaderTemplate>
                         <ItemTemplate>
  <tr>
    <td><%#Eval("Id")%></td>
    <td><%#Eval("Title")%></td>
    <td><%#Eval("Contents")%></td>
   
      <td><%#Eval("CreateTime")%></td>
   
    
  </tr>
</ItemTemplate>
                       <FooterTemplate>
                             <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\">暂无记录</td></tr>" : ""%>
  </tbody>
                       </FooterTemplate>
                       </asp:Repeater>

</table>
              
         <div>
               <h4>我要回答</h4>
           答案标题： <asp:TextBox id="txtTitle" runat="server" Width="260px" CssClass="txtInput"></asp:TextBox>
                <br />
           答案内容： <asp:TextBox id="txtContents" runat="server" Width="460px" Height="80px" CssClass="txtInput" TextMode="MultiLine"></asp:TextBox> 
             
                <asp:Button ID="Button_save" runat="server" CssClass="btnSubmit"  Text="提交回答" OnClick="Button_save_Click" />
              
            </div>
             


    </div>
</form>
    </body>
    </html>
