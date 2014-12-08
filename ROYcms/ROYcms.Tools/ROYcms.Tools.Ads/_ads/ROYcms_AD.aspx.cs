using System;
using System.Web.UI;

namespace ROYcms.Tools.Ads
{
    public partial class addAd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["action"] != null)
                {
                    //修改
                    BindDataEdit();
                }
                else
                {
                    BindDataSort("");
                }
                if (Request.QueryString["id"] != null)
                {
                    BindDataAd(Request.QueryString["id"].ToString());//绑定所属的广告内容
                }
            }
        }

        private void BindDataEdit()
        {
            AdMsg admsg = new AdMsg();
            AdMsgInfo minfo = admsg.GetModelAd(int.Parse(Request.QueryString["id"].ToString()));
            if (minfo != null)
            {
                BindDataSort(minfo.sid.ToString());
                txtTitle.Text = minfo.adname;
                txtPic.Text = minfo.adpic;
                txtUrl.Text = minfo.adurl;
                txtWidth.Text = minfo.adwidth.ToString();
                txtHeight.Text = minfo.adheight.ToString();
                hiddJs.Value = minfo.adjs;
                //绑定所属类型
                try
                {
                    radType.Items.FindByValue(minfo.adtype.ToString()).Selected = true;
                }
                catch
                {
                }
            }
        }

        private void BindDataSort(string sid)
        {
            AdSort adsort = new AdSort();
            ddSort.DataSource = adsort.GetList("");
            ddSort.DataValueField = "id";
            ddSort.DataTextField = "sortname";
            ddSort.DataBind();

            try
            {
                ddSort.Items.FindByValue(sid).Selected = true;
            }
            catch { }
        }

        protected void btnAddAd_Click(object sender, EventArgs e)
        {
            AdMsgInfo minfo = new AdMsgInfo();

            minfo.sid = int.Parse(ddSort.SelectedValue.ToString());
            minfo.adname = txtTitle.Text;
            minfo.adpic = txtPic.Text;
            minfo.adtype = int.Parse(radType.SelectedValue.ToString());
            minfo.adurl = txtUrl.Text;
            minfo.adwidth = int.Parse(txtWidth.Text.ToString());
            minfo.adheight = int.Parse(txtHeight.Text.ToString());
            minfo.adstop = 0;
            minfo.adendtime = DateTime.Parse(DateTime.Now.ToString());
            minfo.adcount = 1;
            minfo.adjs = hiddJs.Value.ToString();
            AddAd(minfo);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="minfo"></param>
        private void AddAd(AdMsgInfo minfo)
        {
            try
            {
                //写入数据库
                AdMsg admsg = new AdMsg();
                if (Request.QueryString["action"] == "edit")//修改
                {
                    CreatJs.CreatepicFile(minfo);
                    minfo.id = int.Parse(Request.QueryString["id"].ToString());
                    admsg.UpdateAd(minfo);
                }
                else
                {
                    //添加
                    admsg.AddAd(minfo);
                    int id = admsg.AdMaxid();

                    //生成JS
                    string getpath = CreatJs.CreatepicFile(minfo);

                    //完成操作
                    admsg.AdUpdateJs(id, getpath);
                }

                Response.Write("完成");



            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
        private void BindDataAd(string getsid)
        {
            AdMsg admsg = new AdMsg();
            RepAdList.DataSource = admsg.GetList("sid=" + getsid);
            RepAdList.DataBind();
        }
    }
}