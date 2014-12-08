<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="admin_Workflow_UGroup.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.UCenter.admin_Workflow_UGroup" %>

<!DOCTYPE HTML>
<html >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>该小组下已添加的工作流 </h3>
    <asp:Repeater ID="Repeater_list" runat="server" 
            DataSourceID="Workflow_UGroup_ObjectDataSource">
            <ItemTemplate>
           <li> <%# ___ROYcms_Workflow_bll.GetField(Convert.ToInt32(Eval("Workflow_id")), "name")%> <span><a href='admin_Workflow_UGroup.aspx?del=<%#Eval("id") %>'>删除关联</a></span></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:ObjectDataSource ID="Workflow_UGroup_ObjectDataSource" runat="server"  
            SelectMethod="GetList" TypeName="ROYcms.Sys.BLL.ROYcms_UGroup_Workflow">
            <SelectParameters>
                <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
