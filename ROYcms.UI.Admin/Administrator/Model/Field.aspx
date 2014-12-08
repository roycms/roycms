<%@ Page Language="C#" Inherits="ROYcms.UI.Admin.Administrator.Model.Field" %>
<table width="100%" cellpadding="4" cellspacing="1" bgcolor="#DFDFDF" class="FieldHtml">



              <tr id="tiao_center">
                  <td nowrap="nowrap"><span class="line"> <strong>标签</strong></span></td>
                <td><span class="line"><strong>显示形式</strong></span></td>
                  <td nowrap="nowrap"><strong>操作</strong></td>
                  <td align="center" nowrap="nowrap"><span class="line"> <strong>排序</strong></span></td>
                </tr>
 <asp:Repeater ID="Repeater_admin" runat="server">
   <ItemTemplate>           
                <tr>
                <td nowrap bgcolor="#F4FBFF"><%#Eval("Lable")%></td>
                <td  width="100%" bgcolor="#F4FBFF">
                
                <%#ROYcms.Templet.ResponseForm.FormPut(Request["Id"],Request["Class"],Eval("Name").ToString(), Eval("Lable").ToString(), Eval("Len").ToString(), Eval("FieldType").ToString(), Eval("IsNull").ToString(), Eval("DefaultVal").ToString(), Eval("Display").ToString(), Eval("InputType").ToString(), Eval("InputLen").ToString())%>
                
                </td>
                <td nowrap bgcolor="#F4FBFF">
                <%#Eval("Name").ToString() == "_RTitle" || Eval("Name").ToString() == "_RContent" ? "默认字段无法操作" : "<a id='" + Eval("Id") + "' href='javascript:' class='FieldEditBT'>编辑</a> | "%>
                
                <%#Eval("Name").ToString() == "_RTitle" || Eval("Name").ToString() == "_RContent" ? "" : "<a id='" + Eval("Id") + "' href='javascript:' class='FieldDelBT'>删除</a>"%>
                
                </td>
                <td align="center" valign="top" nowrap bgcolor="#F4FBFF">
                <input name="textfield" type="text" id='<%#Eval("Id")%>' value='<%#Eval("OrderBy")%>' size="3" class="OrderByF txtInput" /></td>
                
                </tr>
               
              
   </ItemTemplate>
</asp:Repeater>   
<tr>
                  <td colspan="3" nowrap bgcolor="#F4FBFF">&nbsp;</td>
                  <td nowrap bgcolor="#F4FBFF"><input type="button" name="OrderBT" id="OrderBT" value="重新排序" class="btnSubmit" /></td>
                </tr>
</table>