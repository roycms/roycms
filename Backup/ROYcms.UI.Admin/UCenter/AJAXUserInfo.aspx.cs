using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.UCenter
{
    public partial class AJAXUserInfo : ROYcms.UserPage
    {
        public ROYcms.Sys.BLL.ROYcms_UserInfo BLL = new Sys.BLL.ROYcms_UserInfo();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_UserInfo Model = new Sys.Model.ROYcms_UserInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            int PRE = 0;
            Model.Id = ROYcms.Common.Request.GetFormInt("Id");
            if (Model.Id > 0)//编辑
            {
                Model = BLL.GetModel(Model.Id);
            }

            Model.UserId = ROYcms.Common.Request.GetFormInt("UserId");
            Model.AccountBalance = ROYcms.Common.Request.GetFormInt("AccountBalance");
            Model.AvilableBalance = ROYcms.Common.Request.GetFormInt("AvilableBalance");
            Model.ConsumedAmount = ROYcms.Common.Request.GetFormInt("ConsumedAmount");
            Model.Money = ROYcms.Common.Request.GetFormInt("Money");
            Model.GradeID = ROYcms.Common.Request.GetFormInt("GradeID");
            Model.State = ROYcms.Common.Request.GetFormInt("State");
            Model.RealName = ROYcms.Common.Request.GetFormString("RealName");
            Model.Qq = ROYcms.Common.Request.GetFormInt("Qq");
            Model.Mobil = ROYcms.Common.Request.GetFormString("Mobil");
            Model.Tel = ROYcms.Common.Request.GetFormString("Tel");
            Model.Address = ROYcms.Common.Request.GetFormString("Address");
            Model.Postcode = ROYcms.Common.Request.GetFormString("Postcode");
            Model.Website = ROYcms.Common.Request.GetFormString("Website");
            Model.IDcardNum = ROYcms.Common.Request.GetFormString("IDcardNum");
            Model.AccountType = ROYcms.Common.Request.GetFormInt("AccountType");
            Model.SiteID = ROYcms.Common.Request.GetFormInt("SiteID");

            if (Model.Id == 0)//添加
            {
                PRE = this.BLL.Add(this.Model);
            }
            else //编辑
            {
                PRE = this.BLL.Update(this.Model) == true ? 1 : 0;
            }

            Response.ContentType = "text/plain";
            Response.Write(PRE);
        }
    }
}