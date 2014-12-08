<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_Class_UGroup.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.UCenter.admin_Class_UGroup" %>
<!DOCTYPE HTML>
<html >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>该小组下允许发布的分类 </h3>
        <asp:Repeater ID="Repeater_list" runat="server" 
            DataSourceID="Class_UGroup_ObjectDataSource">
          <ItemTemplate>
           <li> <%# ___ROYcms_class_Bll.GetClassField(Convert.ToInt32(Eval("Class_id")),"ClassName") %> <span><a href='admin_Class_UGroup.aspx?del=<%#Eval("id") %>'>删除关联</a></span></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:ObjectDataSource ID="Class_UGroup_ObjectDataSource" runat="server"  
            SelectMethod="GetList" TypeName="ROYcms.Sys.BLL.ROYcms_Class_UGroup">
            <SelectParameters>
                <asp:QueryStringParameter Name="id" 
                    QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
