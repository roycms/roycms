/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI.WebControls;
using ROYcms.FileManager;
using ROYcms.Common;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Appendix_Default : AdminPage
    {  
        #region type属性
        /// <summary>
        /// 
        /// </summary>
        protected string type
        {
            get
            {
                return (string)ViewState["type"];
            }
            set
            {
                ViewState["type"] = value;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                this.type = Request["id"];
                try
                {

                    BindGrid(Server.MapPath(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("upload_path")));

                }
                catch { Response.Redirect("/administrator/Message.aspx?message=操作失败！ 没有权限，或者参数错误！&z=no"); }
                
            }
        }

        #region BindGrid()
        /// <summary>
        /// Binds the grid.
        /// </summary>
        private void BindGrid()
        {
            List<FileSystemItem> list = FileSystemManager.GetItems();
            GridView1.DataSource = list;
            GridView1.DataBind();
            lblCurrentPath.Text = FileSystemManager.GetRootPath();
        }

        /// <summary>
        /// Binds the grid.
        /// </summary>
        /// <param name="path">The path.</param>
        private void BindGrid(string path)
        {
            if (!path.Contains(Server.MapPath(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("upload_path"))))
            {
                path = Server.MapPath(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("upload_path"));
            }
            List<FileSystemItem> list = FileSystemManager.GetItems(path);
                GridView1.DataSource = list;
                GridView1.DataBind();
                lblCurrentPath.Text = path;

        }
        #endregion

        /// <summary>
        /// Handles the RowDataBound event of the GridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewRowEventArgs"/> instance containing the event data.</param>
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lb = (LinkButton)e.Row.Cells[1].FindControl("LinkButton1");
                if (lb.Text != "根目录" && lb.Text != "上一级")
                {
                    if (Directory.Exists(lb.CommandArgument.ToString()))
                    {
                        lb.Text = string.Format("<img src=\"/administrator/images/file/folder.gif\" style=\"border:none; vertical-align:middle;\" /> {0}", lb.Text);
                    }
                    else
                    {
                        string ext = lb.CommandArgument.ToString().Substring(lb.CommandArgument.LastIndexOf(".") + 1);
                        if (File.Exists(Server.MapPath(string.Format("/administrator/images/file/{0}.gif", ext))))
                        {
                            lb.Text = string.Format("<img src=\"/administrator/images/file/{0}.gif\" style=\"border:none; vertical-align:middle;\" /> {1}", ext, lb.Text);
                        }
                        else
                        {
                            lb.Text = string.Format("<img src=\"/administrator/images/file/other.gif\" style=\"border:none; vertical-align:middle;\" /> {0}", lb.Text);
                        }
                    }
                }
                else
                {
                    e.Row.Cells[0].Controls.Clear();
                }
            }
        }

        /// <summary>
        /// Handles the RowCommand event of the GridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewCommandEventArgs"/> instance containing the event data.</param>
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (Directory.Exists(e.CommandArgument.ToString()))
            {
                BindGrid(e.CommandArgument.ToString());
            }
            else
            {
                string path = e.CommandArgument.ToString().Normalize();
                //if (config.FileManager_root != "*")
                //{
                //    path = path.Replace(FileSystemManager.GetRootPath(), config.FileManager_root);
                //}
                //else
                //{
                //    path = FileSystemManager.GetRootPath();
                //}

                path = path.Replace("\\", "/");
                path = path.Replace("//", "/");
                int al1 = path.LastIndexOf((ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("upload_path")).Replace("~", ""));
                int al2 = path.Length - path.LastIndexOf((ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("upload_path")).Replace("~", ""));
                path = path.Substring(al1, al2);
                //Response.Redirect("edit.aspx?page=" + path);
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>"
                    +
                    "javascript:MyCL('" + path + "','" + this.type + "'); "
                    + "</script>");
              
             
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox cb = (CheckBox)row.Cells[0].FindControl("CheckBox1");
                    if (cb.Checked)
                    {
                        LinkButton lb = (LinkButton)row.Cells[1].FindControl("LinkButton1");
                        if (Directory.Exists(lb.CommandArgument))
                        {
                            FileSystemManager.DeleteFolder(lb.CommandArgument);
                        }
                        else
                        {
                            FileSystemManager.DeleteFile(lb.CommandArgument);
                        }
                    }
                }
            }
            BindGrid(lblCurrentPath.Text);
        }

        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreateFolder_Click(object sender, EventArgs e)
        {
            FileSystemManager.CreateFolder(TextBox2.Text, lblCurrentPath.Text);
            BindGrid(lblCurrentPath.Text);
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string path = lblCurrentPath.Text + "\\";
                path += Path.GetFileName(FileUpload1.FileName);
                FileUpload1.PostedFile.SaveAs(path);
                BindGrid(lblCurrentPath.Text);
            }
        }

        /// <summary>
        /// 剪切
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCut_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox cb = (CheckBox)row.Cells[0].FindControl("CheckBox1");
                    if (cb.Checked)
                    {
                        LinkButton lb = (LinkButton)row.Cells[1].FindControl("LinkButton1");
                        items.Add(lb.CommandArgument);
                    }
                }
            }
            ViewState["clipboard"] = items;
            ViewState["action"] = "cut";
        }

        /// <summary>
        /// 粘贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPaste_Click(object sender, EventArgs e)
        {
            if (ViewState["clipboard"] != null)
            {
                if (ViewState["action"].ToString() == "cut")
                {
                    List<string> items = (List<string>)ViewState["clipboard"];
                    foreach (string s in items)
                    {
                        if (Directory.Exists(s))
                        {
                            Directory.Move(s, lblCurrentPath.Text + s.Substring(s.LastIndexOf("\\")));
                        }
                        else
                        {
                            File.Move(s, lblCurrentPath.Text + "\\" + Path.GetFileName(s));
                        }
                    }
                }
                else
                {
                    List<string> items = (List<string>)ViewState["clipboard"];
                    foreach (string s in items)
                    {
                        if (Directory.Exists(s))
                        {
                            DirectoryInfo di = new DirectoryInfo(s);
                            FileSystemManager.CopyFolder(s, lblCurrentPath.Text + "\\" + di.Name);
                        }
                        else
                        {
                            File.Copy(s, lblCurrentPath.Text + "\\复件 " + Path.GetFileName(s), true);
                        }
                    }
                }
            }
            ViewState["clipboard"] = null;
            ViewState["action"] = null;
            BindGrid(lblCurrentPath.Text);
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCopy_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox cb = (CheckBox)row.Cells[0].FindControl("CheckBox1");
                    if (cb.Checked)
                    {
                        LinkButton lb = (LinkButton)row.Cells[1].FindControl("LinkButton1");
                        items.Add(lb.CommandArgument);
                    }
                }
            }
            ViewState["clipboard"] = items;
            ViewState["action"] = "copy";
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRename_Click(object sender, EventArgs e)
        {
            string src = "";
            string dest = "";
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox cb = (CheckBox)row.Cells[0].FindControl("CheckBox1");
                    if (cb.Checked)
                    {
                        LinkButton lb = (LinkButton)row.Cells[1].FindControl("LinkButton1");
                        src = lb.CommandArgument;
                    }
                }
            }
            if (src.Length > 0)
            {
                dest = src.Substring(0, src.LastIndexOf('\\'));
                dest = dest + "\\" + TextBox3.Text;
                if (Directory.Exists(src))
                {
                    FileSystemManager.MoveFolder(src, dest);
                }
                else
                {
                    FileSystemManager.MoveFile(src, dest);
                }
                BindGrid(lblCurrentPath.Text);
            }
        }
    }
}