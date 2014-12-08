<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator.UCenter.UGroupConfig" CodeBehind="UGroupConfig.aspx.cs" %>
<html>
<body>
<form id="UGroupConfigForm" runat="server">
  <table width="480" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td colspan="2" nowrap><div class="tagMenu" style="margin-bottom:15px;">
          <ul class="menu">
            <li>投递信息权限配置</li>
            <li>组关联工作流配置</li>
            <li>浏览权限配置</li>
            <li>关联智能表单配置</li>
          </ul>
        </div>
        <div class="content" style="padding:5px;">
          <div class="layout">
          
             <asp:Repeater ID="Repeater_XClass" runat="server">
                    <ItemTemplate>
                      <div style="float:left; margin:5px; ">
    <asp:CheckBox ID="ID_list" runat="server" Text='<%#Eval("ClassName") %>' Enabled='<%#(Eval("ColumnsType").ToString()=="0")?true:false %>' />
                      </div>
                    </ItemTemplate>
                  </asp:Repeater>
     <table width="100%" border="0" cellpadding="10" cellspacing="0" style="clear:both; height:50px;">
                <tr>
                  <td align="right"><input id="UGroupSendBT" name="UGroupSendBT" type="button" value="确认选择"></td>
                </tr>
              </table>
           
          </div>
          <div class="layout">
          
          
           <table width="100%" cellpadding="4" cellspacing="1" style="background-color:#CCC">
     <tr>
       <td width="87%" bgcolor="#F7F7F7" >工作流名称</td>
       <td width="13%" bgcolor="#F7F7F7">操作</td>
     </tr>   
  <asp:Repeater ID="Repeater_Workflow" runat="server">
                    <ItemTemplate>
                      <tr>
        <td bgcolor="#FFFFFF"><%#Eval("name")%></td>
        <td bgcolor="#FFFFFF"><a href="javascript:" id='<%#Eval("id")%>' class="UGroupWorkflowBT">应用</a></td> 
        </tr>
                    </ItemTemplate>
                  </asp:Repeater>
      </table>
          
          
          </div>
          <div class="layout">无</div>
          <div class="layout">无</div>
        </div></td>
    </tr>
  </table>
</form>
</body>
</html>
