<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SetUserGrade.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.DNS.SetUserGrade" %>
    <form id="form1" action="/Administrator/dns/SetUserGrade.aspx" runat="server">
    <div>
        当前等级是 <%= getGrade()%><br />
      <asp:DropDownList ID="txtGradeID" runat="server" CssClass="txtInput">
       </asp:DropDownList>
        <%   
            if(Bll.GetModel_(Convert.ToInt32(ViewState["UserId"]))==null){

             %>
      <span style="color:red">会员信息未完善不允许设置等级</span> 
      <%  } else{%>

        <asp:Button ID="btnSave" runat="server" Text="设置"  CssClass="btnSearch" OnClick="btnSave_Click"></asp:Button>
        <%} %>
    </div>
    </form>
