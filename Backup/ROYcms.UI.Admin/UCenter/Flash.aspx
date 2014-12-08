
<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.Flash" Title="闪存" Codebehind="Flash.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script>    $("#ing").parent().addClass("hover");</script>
    <div id="Topnav_tags">
      <ul>
        <li>
          <a href="?S=0">大家在在说什么？</a>
        </li>
        <li>
          <a href="?S=1">我说的</a>
        </li>
      </ul>
    </div>

<asp:TextBox CssClass="txtInput" Height="36px" ID="TextBox_flash_title" runat="server"  Text="忙碌了一天抽空闪一下吧！"  Width="390px"></asp:TextBox>
<asp:Button ID="Button_ADDflash" runat="server" Text="闪一下"  Height="36px"  Width="90px" onclick="Button_ADDflash_Click" CssClass="btnSubmit"  />
<dl class="feed_block" style="margin-left:15px;">
  <%if (ROYcms.Common.Request.GetQueryInt("S") == 0)
       {%>
<asp:Repeater ID="Repeater_list" runat="server">
<ItemTemplate>
<dt class="ing">
<span><%#___ROYcms_user_bll.GetField(Convert.ToInt32(Eval("User_Id")),"name")%>说:</span> 
<a href="#all<%#Eval("id")%>" rel="facebox" title="<%#Eval("title")%>"><%#Eval("title")%></a> 
<%#Convert.ToDateTime(Eval("time")).ToString("yy/mm/dd/hh")%>
        <div id="all<%#Eval("id")%>" style=" display:none;">
        <%#___ROYcms_user_bll.GetField(Convert.ToInt32(Eval("User_Id")),"name")%>在[<%#Eval("time")%>]时刻路过时<br />
        闪了一下：<%#Eval("title")%><br />
        </div>
       
 </dt>
</ItemTemplate>
 <FooterTemplate>
              <%#Repeater_list.Items.Count == 0 ? "暂无记录" : ""%>
                  </TBODY>
                </TABLE>
            </FooterTemplate>
</asp:Repeater>
  <%}
       else if (ROYcms.Common.Request.GetQueryInt("S") == 1)
       {%>
       <asp:Repeater ID="Repeater_MyList" runat="server">
<ItemTemplate>
<dt class="ing">
<span><%#___ROYcms_user_bll.GetField(Convert.ToInt32(Eval("User_Id")),"name")%>说:</span> 
<a href="#all<%#Eval("id")%>" rel="facebox" title="<%#Eval("title")%>"><%#Eval("title")%></a> 
<%#Convert.ToDateTime(Eval("time")).ToString("yy/mm/dd/hh")%>
        <div id="all<%#Eval("id")%>" style=" display:none;">
        <%#___ROYcms_user_bll.GetField(Convert.ToInt32(Eval("User_Id")),"name")%>在[<%#Eval("time")%>]时刻路过时<br />
        闪了一下：<%#Eval("title")%><br />
        <%#Eval("user_id").ToString() == ROYcms.Common.Session.Get("user_id") ? "<a href='?del=" + Eval("id") + "'  Class='btnSearch'>删除</a>" : ""%>
        </div>
<%#Eval("user_id").ToString() == ROYcms.Common.Session.Get("user_id") ? "<a href='#del" + Eval("id") + "' rel='facebox' title='" + Eval("title") + "' >删除</a>" : ""%>
        <div id="del<%#Eval("id")%>" style=" display:none;">
        确实要删除<br />[<%#Eval("title")%>] 吗？
        <a href="?del=<%#Eval("id")%>"  Class='btnSearch'>删除</a>
        </div>
 </dt>
</ItemTemplate>
 <FooterTemplate>
              <%#Repeater_list.Items.Count == 0 ? "暂无记录" : ""%>
                  </TBODY>
                </TABLE>
            </FooterTemplate>
</asp:Repeater>
        <%} %>
</dl>

</asp:Content>
