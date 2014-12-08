
<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.PeopleDate" Title="个人资料" Codebehind="PeopleDate.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link rel="stylesheet" href="/administrator/editor/themes/default/default.css" />
<script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script>
<script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
<STYLE>
 .Tb td{
   font-size:12px;
   padding:3px;
 }
</STYLE>
    <div>
    <div id="Topnav_tags">
      <ul>
        <li>
          <a href="/ucenter/PeopleDate.aspx?S=0">基本资料</a>
        </li>
        <li>
          <a href="/ucenter/PeopleDate.aspx?S=1">详细资料</a>
        </li>
         <li>
          <a href="/ucenter/PeopleDate.aspx?S=2">第三方账户</a>
        </li>
       <li>
          <a href="/ucenter/PeopleDate.aspx?S=3">企业认证</a>
        </li>
         <li>
          <a href="/ucenter/PeopleDate.aspx?S=4">日志</a>
        </li>
      </ul>
    </div>
     <!--******************************基本资料********************************-->
      <%if (ROYcms.Common.Request.GetQueryInt("S") == 0)
        { %>
    
     <table width="477" border="0" align="center" cellpadding="10" cellspacing="0">
       <tr>
    <td width="128" align="center" valign="top"><table width="90%" border="0" align="center" cellpadding="0" cellspacing="3">
      <tr>
        <td align="center"><asp:Image ID="Photo_pic" CssClass="Photo_pic" runat="server" />
          </td>
      </tr>
      <tr>
        <td align="center">
        <a href="javascript:;" id="SitePhoto_pic">更改我的头像+</a>
        
          <script>
              KindEditor.ready(function (K) {
                  var editor = K.editor({
                      cssPath: '/Administrator/Editor/plugins/code/prettify.css',
                      uploadJson: '/Administrator/Editor/C/upload_json.ashx?root=Ucenter,Pic',
                      fileManagerJson: '/Administrator/Editor/C/file_manager_json.ashx?root=Ucenter,Pic',
                      allowFileManager: true
                  });
                  K('#SitePhoto_pic').click(function () {
                      editor.loadPlugin('image', function () {
                          editor.plugin.imageDialog({
                              imageUrl: K('.Photo_pic').attr("src"),
                              clickFn: function (url, title, width, height, border, align) {
                                  K('.Photo_pic').attr("src", url);
                                  editor.hideDialog();
                              }
                          });
                      });
                  });
              });
		                        </script>


        </td>
      </tr>
    </table></td>
    <td width="309"><table cellspacing="10" cellpadding="0" width="310" border="0">
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> 登录名称：</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
            <%= ROYcms.Common.Session.Get("user")%>
            <a href="#">修改</a>
            </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> 密码：</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
          ***<%=___ROYcms_user_bll.GetModel(Convert.ToInt32(ROYcms.Common.Session.Get("user_id"))).password.Remove(0, 3)%>
        <a href="#" onclick="window.open('update_password.aspx','Sample','toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=no,resizable=yes,copyhistory=yes,width=450,height=300,left=200,top=100')" >修改密码</a>
        </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> QQ：</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
        <asp:TextBox CssClass="input_css" id="txtqq" runat="server" Width="200px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap">邮箱：</td>
        <td width="170" height="25" align="left" nowrap="nowrap"><asp:TextBox CssClass="input_css" id="txtemail" runat="server" Width="200px"></asp:TextBox></td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> 年龄：</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
        <asp:TextBox CssClass="input_css" id="txtage" runat="server" Width="50px"></asp:TextBox></td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap">性别：</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
            <asp:DropDownList ID="DropDownList_sex" runat="server" CssClass="select" Width="50px">
                <asp:ListItem>男</asp:ListItem>
                <asp:ListItem Value="女"></asp:ListItem>
                <asp:ListItem>保密</asp:ListItem>
            </asp:DropDownList>
          </td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> 头像 ：</td>
        <td width="170" height="25" align="left" nowrap="nowrap"><asp:TextBox CssClass="input_css" id="txtpic" runat="server" Width="200px"></asp:TextBox></td>
      </tr>
      <tr>
        <td width="90" height="25" align="right" nowrap="nowrap"> 昵称：</td>
        <td width="170" height="25" align="left" nowrap="nowrap">
        <asp:TextBox CssClass="input_css" id="txtusername" runat="server" Width="200px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td height="25" nowrap="nowrap"></td>
        <td height="25" nowrap="nowrap">
        <asp:Button ID="btnUpdate" runat="server" Text="确认编辑" OnClick="btnUpdate_Click" CssClass="btnSubmit" ></asp:Button>
        </td>
      </tr>
    </table></td>
  </tr>
</table>
<%}  else if (ROYcms.Common.Request.GetQueryInt("S") ==1){%>


    <!--******************************详细资料********************************-->
  

                          <table width="477" border="0" align="center" cellpadding="0" cellspacing="6">
                <tr>
                  <td width="129" align="right">联系人姓名：</td>
                  <td width="330"><input type="text" class="txtInput" name="RealName" id="RealName" /></td>
                </tr>
                <tr>
                  <td align="right">联系人手机：</td>
                  <td><input type="text" class="txtInput" name="Mobil" id="Mobil" /></td>
                </tr>
                <tr>
                <td align="right">电话：</td>
                <td><input type="text" class="txtInput" name="Tel" id="Tel" /></td>
                </tr>
                <tr>
                <td align="right">地址：</td>
                <td><input name="Address" type="text" class="txtInput" id="Address" size="45" /></td>
                </tr>
                <tr>
                <td align="right">邮编：</td>
                <td><input type="text" class="txtInput" name="Postcode" id="Postcode" /></td>
                </tr>
                <tr>
                <td align="right">网站：</td>
                <td><input type="text" class="txtInput" name="Website" id="Website" /></td>
                </tr>
                <tr>
                <td align="right">身份证号码：</td>
                <td><input name="IDcardNum" type="text" class="txtInput" id="IDcardNum" size="45" /></td>
                </tr>
                <tr>
                  <td align="right">&nbsp;</td>
                  <td><input type="button" name="button" id="button" value="确认编辑"  class="btnSubmit"/></td>
                </tr>

     </table>

        <%} else if (ROYcms.Common.Request.GetQueryInt("S") == 2)
        { %>

            <!--******************************第三方账户********************************-->
   
        第三方账户绑定暂无

        <%}  else if (ROYcms.Common.Request.GetQueryInt("S") == 3)
        { %>
            <!--******************************企业认证********************************-->
     
        企业人正在暂无，请联系网站管理员。

        <%} else if (ROYcms.Common.Request.GetQueryInt("S") == 4)
        {  %>
                    <!--******************************日志********************************-->
      

                <asp:Repeater ID="Repeater_admin" runat="server">
        <HeaderTemplate>
            <TABLE border=0 cellSpacing=1 cellPadding=5 width="100%"  class="Tb" >
              <TBODY>
                <TR id="tiao_center">
               
                  <TD width="28" nowrap><span class="line">编号</span></TD>
            
                  <TD><span class="line">事件</span></TD>
              
                  <TD><span class="line">IP地址</span></TD>
                  <TD><span class="line">发生时间</span></TD>
                </TR>
        </HeaderTemplate>
          <ItemTemplate>
            <tr  onMouseOver="this.style.background='#92C9D9'"  onmouseout="this.style.background='#f4fbff'">
             
              <td nowrap><asp:Label ID="Label_id" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
              <td><%#Eval("Event")%></td>
           
              <td><a rel="facebox" href='/app_api/AJAXIP.aspx?ip=<%#Eval("Ip")%>'><%#Eval("Ip")%></a></td>
              <td><%#Eval("Time")%></td>
            </tr>
          </ItemTemplate>
          <FooterTemplate>
          <%#Repeater_admin.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\">暂无记录</td></tr>" : ""%>
                  </TBODY>
                </TABLE>
          </FooterTemplate>
        </asp:Repeater>

        <%} %>
    </div>
</asp:Content>
