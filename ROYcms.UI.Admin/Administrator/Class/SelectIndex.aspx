<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_class_index"  %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<script runat="server">
    /// <summary>
    /// 权限发生更改时
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void setClass_Click(object sender, EventArgs e)
    {

        ROYcms.Sys.BLL.ROYcms_Jurisdiction Bll = new ROYcms.Sys.BLL.ROYcms_Jurisdiction();
        ROYcms.Sys.Model.ROYcms_Jurisdiction Model = new ROYcms.Sys.Model.ROYcms_Jurisdiction();

        
        int AdminId = Convert.ToInt32(ViewState["AdminId"]);

        for (int i = 0; i < rptMenuList.Items.Count; i++)
        {
            int ClassID = Convert.ToInt32(((HiddenField)rptMenuList.Items[i].FindControl("txtClassId")).Value);
            CheckBox CK = (CheckBox)rptMenuList.Items[i].FindControl("selectC");
            if (CK.Checked)
            {
                //判断 该权限是否存在
                if (Bll.GetList(" ClassID=" + ClassID + "  AND AdminID=" + AdminId).Tables[0].Rows.Count < 1)
                { //

                    Model.AdminID = AdminId;
                    Model.ClassID = ClassID;
                    Model.ClassKind = "0";
                    Model.JID = "0";
                    Model.CreateTime = DateTime.Now;

                    Bll.Add(Model);

                   
                }
            }
            else {
                if (Bll.GetList(" ClassID=" + ClassID + "  AND AdminID=" + AdminId).Tables[0].Rows.Count > 0)
                {
                    int Id = Convert.ToInt32(Bll.GetList(" ClassID='" + ClassID + "' AND AdminID=" + AdminId).Tables[0].Rows[0]["Id"]);

                    Bll.Delete(Id);
                }
            }
            ROYcms.Common.MessageBox.Show(this, "设置成功！");
        }
        //Response.Redirect("Insert.aspx");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ClassID"></param>
    /// <returns></returns>
    public bool IsJurisdiction(int ClassID) 
    {
        ROYcms.Sys.BLL.ROYcms_Jurisdiction Bll = new ROYcms.Sys.BLL.ROYcms_Jurisdiction();
        int AdminId = Convert.ToInt32(ViewState["AdminId"]);
        if (Bll.GetList(" ClassID=" + ClassID + "  AND AdminID=" + AdminId).Tables[0].Rows.Count > 0)
        {
            return true;
        }
        else { return false; }
    }
    
    
</script>
<!DOCTYPE HTML>
<html>
<head>
<title></title>
</head>
<body>
<form id="form" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
<div style="margin-right:5px;margin-bottom:5px;margin-top:2px;width:100%;"  >

     <asp:Repeater ID="rptMenuList" runat="server" OnItemDataBound="rptMenuList_ItemDataBound">               
            <HeaderTemplate>
                <table class="main_table" cellpadding="0" cellspacing="0" border="0" width="100%" style="border:1px solid #E7E7E7;">
                <tr align="center" class="td_title"  id="tiao_center" height="30px;">
                <td width="53%" align="left" class="enfont2">
                <img src="/administrator/images/lightbulb_add.png" width="16" align="absmiddle" height="16" border="0"> 提示：选择频道。</td>
                <td width="47%" align="right" nowrap>
                <span style="display:none"><input type="submit" name="buttonbutton" id="buttonbutton"  /></span>      
                </td>
                </tr>
            </HeaderTemplate>
                      
             <ItemTemplate>
                <tr onmouseover="this.style.background='#EEF7FD'" onmouseout="this.style.background='#fafafa'" style="height:24px;" >
                <td nowrap style="padding-left:5px;">
                    <asp:CheckBox ID="selectC" CssClass="selectC" Checked='<%# IsJurisdiction(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"Id"))) %>'  runat="server" />
                    <span Class="selectV" >
                    <asp:HiddenField ID="txtClassId" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"Id") %>' />
                    </span>
                    <asp:Literal ID="LitFirst" runat="server"></asp:Literal>
                    <asp:Label ID="LabClassNm" runat="server" Text=' <%#DataBinder.Eval(Container.DataItem,"ClassName")%> '></asp:Label>
                    <%#" [ID:"+ DataBinder.Eval(Container.DataItem,"Id").ToString()+"]"%> 
                   
                </td>
                <td align="right" nowrap>
              
               <!--判断文章类型-->
                <%#DataBinder.Eval(Container.DataItem, "ColumnsType").ToString().Trim() == "2" ? "<script>$('.ColumnsTypeNo" + DataBinder.Eval(Container.DataItem, "ClassId") + "').hide();</script>" : ""%>
                </td>
                </tr>       
              </ItemTemplate>
                        
               <FooterTemplate>
                      <%#rptMenuList.Items.Count == 0 ? "<tr><td align=\"center\" style=\"padding:5px;\"><a href=Insert.aspx?ClassKind="+ ClassKind +">暂无频道记录，请点击增加顶级频道</a></td></tr>" : ""%>  
                      <tr class="td_on" onMouseOver="this.className='td_off'" onMouseOut="this.className='td_on'" bgcolor="#E7E7E7">
                        <td height="30" align="left" bgcolor="#E2F1FC">
                        <label style="padding-left:5px;"><input  id=chkAll type=checkbox  name=chkAll onClick="CheckAll(form)" style="vertical-align:middle;"> 全选</label>
                        </td>
                        <td height="30" align="right" nowrap bgcolor="#E2F1FC">
                     
                         
                         <asp:Button ID="setClass" CssClass="btnSubmit" runat="server" Text="确认选择"  OnClick="setClass_Click" />

                        <span style=" display:none">
                        <asp:Button CssClass="btnSearch" Font-Bold="true"  ID="BtnSave" runat="server" Text=" 更新频道顺序 " Width="92" OnClick="BtnSave_Click" />
                        </span>
                       </td>
                      </tr>
                    </table>
              </FooterTemplate>         
       </asp:Repeater>
</div>
</form>
</body>
</html>
