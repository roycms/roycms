<%@ Page Language="C#" MasterPageFile="~/UCenter/UCenter.Master" AutoEventWireup="True" Inherits="ROYcms.UCenter.Workflow" Title="待审信息-工作流" Codebehind="Workflow.aspx.cs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   

<h3>我所处的信息审核阶段 - [工作流]</h3>
<ul>
<asp:Repeater ID="Repeater_list" runat="server">
<ItemTemplate>
<li style=" margin-left:5px;">
<span>
<a href="#all<%#Eval("id")%>" rel=facebox>
<%#___ROYcms_Workflow_bll.GetField(Convert.ToInt32(Eval("Workflow_id")),"name")%>
</a>
<div id="all<%#Eval("id")%>" style="display:none">
<h3><%#___ROYcms_Workflow_bll.GetField(Convert.ToInt32(Eval("Workflow_id")),"name")%></h3>
<p><%#___ROYcms_Workflow_bll.GetField(Convert.ToInt32(Eval("Workflow_id")),"Time")%></p>
</div>
 - <a href='NewsWorkflow.aspx?keyId=<%#___ROYcms_Workflow_bll.GetField(Convert.ToInt32(Eval("Workflow_id")),"keyId")%>' target=_blank >
 查看审核信息
 </a> 
</span>
</li>
</ItemTemplate>
</asp:Repeater>
</ul>
</asp:Content>