<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_Model.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.Class.Class_Model" %>
<!DOCTYPE HTML>
<html>
<body>
    <form id="Class_Modelform" runat="server">  
    
    <table width="360" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td colspan="2" nowrap><div class="tagMenu">
          <ul class="menu">
            <li>关联智能表单配置</li>
            <li>频道开放权限配置</li>
           
          </ul>
        </div>
        <div class="content" style="padding:5px;">
          <div class="layout">
          <p style=" margin:8px 8px;">
             当前模型是：
          <%
              string ModelName =null;
              string Modelid = new ROYcms.Sys.BLL.ROYcms_Class_Model().CidGetP("Mid", "Cid=" + Request["Id"]);
              if (Modelid != null)
              { ModelName = new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Modelid)) == null ? "" : new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Modelid)).Name;        
          %> 
          [<%=ModelName  %>]
           <a href="javascript:" id='<%=Request["Id"]%>' class="Class_ModelDelBT">取消关联</a>
          <%}else {%>   
          无关联的模型
          <%}%>
          </p>
          
                  <table width="100%" cellpadding="4" cellspacing="1" style="background-color:#CCC">
     <tr>
       <td width="87%" bgcolor="#F7F7F7" >模型名称</td>
       <td width="13%" bgcolor="#F7F7F7">操作</td>
     </tr>   
      <asp:Repeater ID="Repeater_admin" runat="server">
        <ItemTemplate>
        <tr>
        <td bgcolor="#FFFFFF"><%#Eval("Name")%></td>
        <td bgcolor="#FFFFFF"><a href="javascript:" id='<%#Eval("Id")%>,<%=Request["Id"]%>' class="Class_ModelBT">应用</a></td> 
        </tr>
      
        </ItemTemplate>
      </asp:Repeater>
      </table>
          
          </div>
          <div class="layout">无</div>
        
        </div></td>
    </tr>
  </table>

    </form>
</body>
</html>
