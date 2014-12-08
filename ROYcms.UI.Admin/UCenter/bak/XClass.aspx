
<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.XClass" Title="开放类别" Codebehind="XClass.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="560" border="0" align="center" cellpadding="10" cellspacing="0">
  <tr>
    <td align="center" valign="top"><fieldset>
      <legend> 开放投递分类</legend>
      <table width="98%" border="0" cellspacing="10" cellpadding="0">
        <tr>
          <td bgcolor="#E7EAF1"><strong>点击链接进行发布</strong></td>
          </tr>
        <tr>
          <td>
              <asp:Repeater ID="Repeater_list" runat="server">
              <ItemTemplate>
               <a href='/administrator/objet/add.aspx?Class=<%# Eval("Class_id")%>&ClassKind=<%# ___ROYcms_class_Bll.GetClassField(Convert.ToInt32(Eval("Class_id")),"ClassKind") %>' target="_blank"><%# ___ROYcms_class_Bll.GetClassField(Convert.ToInt32(Eval("Class_id")),"ClassName") %></a>
              </ItemTemplate>
              </asp:Repeater>
            </td>
          </tr>
      </table>
    </fieldset></td>
</tr>
</table>
</asp:Content>