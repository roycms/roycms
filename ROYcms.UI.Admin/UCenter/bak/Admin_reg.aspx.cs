/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;
using ROYcms.Common;
using ROYcms.Sys.Model;
using ROYcms.Sys.BLL;
//using ROYcms.UI.Admin.WC_ROYcms_user;
using ROYcms.UI.Admin;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_Enterprise_reg : System.Web.UI.Page
    {
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the Button_add control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Button_add_Click(object sender, EventArgs e)
        {

            string name = this.txtname.Value;
            string password = this.txtpassword.Value;
            string qq = "";
            string email = "";
            int age = 0;
            string sex = "";
            string pic = "";
            string username = "";
            ROYcms.Sys.Model.ROYcms_user model = new ROYcms.Sys.Model.ROYcms_user();
            

            model.name = name;
            model.password = password;
            model.qq = qq; 
            model.email = email;
            model.age = age;
            model.sex = sex;
            model.pic = pic;
            model.login_time = DateTime.Now;
            //默认可选参数组
            model.money = 0;
            model.quanxian = "Enterprise";
            model.username = username;
            model.GUID = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("guid");

            ROYcms.Sys.BLL.ROYcms_user bll = new ROYcms.Sys.BLL.ROYcms_user();


            if (yanzhengma.Value.Trim().ToUpperInvariant() == Session["code"].ToString())
            {   
                ROYcms.Sys.BLL.ROYcms_user user = new ROYcms.Sys.BLL.ROYcms_user();
                if (!user.Exists(name))
                {
                    int _bh = bll.Add(model);
                    if ( _bh!= 1)
                    {
                        ROYcms.Sys.Model.ROYcms_user _model = bll.GetModel(this.txtname.Value);
                        ROYcms.Common.Session.Add("user_id", _model.bh.ToString().Trim());
                        ROYcms.Common.Session.Add("user", _model.name.Trim());


                        ROYcms.Sys.Model.ROYcms_Enterprise Enterprise_model = new ROYcms.Sys.Model.ROYcms_Enterprise();
                        if (ROYcms.Common.Session.Get("user_id") != null)
                        {
                            Enterprise_model.user_id = Convert.ToInt32(ROYcms.Common.Session.Get("user_id"));
                        }
                        string mesbox = "请尽快完善您的企业企业信息！";
                        Enterprise_model.gs_name = this.GSname.Value;//公司名称
                        Enterprise_model.gs_tel = this.GStel.Value;//公司电话
                        Enterprise_model.keyword = this.GSname.Value;
                        Enterprise_model.description = this.GSname.Value;


                        Enterprise_model.introduces = mesbox;
                        Enterprise_model.business_scope = mesbox;
                        Enterprise_model.intelligence_honor = mesbox;
                        Enterprise_model.contacts_us = mesbox;
                        Enterprise_model.enterprise_culture = mesbox;
                        Enterprise_model.marketing_network = mesbox;
                        Enterprise_model.other_1 = mesbox;
                        Enterprise_model.other_2 = mesbox;
                        Enterprise_model.other_3 = mesbox;
                        Enterprise_model.other_4 = mesbox;

                        ROYcms.Sys.BLL.ROYcms_Enterprise Enterprise_bll = new ROYcms.Sys.BLL.ROYcms_Enterprise();

                        if (Enterprise_bll.Add(Enterprise_model) != 1)
                        {

                            //非主站点   
                            if (ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("ucenter_webserver") != "index")
                            {
                                try
                                {
                                    ////webserver接口数据
                                    //ROYcms.UI.Admin.WC_ROYcms_user.ROYcms_user1 WC_model = new ROYcms_user1();
                                    //WC_model.name = name;
                                    //WC_model.password = password;
                                    //WC_model.qq = qq;
                                    //WC_model.email = email;
                                    //WC_model.age = age;
                                    //WC_model.sex = sex;
                                    //WC_model.pic = pic;
                                    //WC_model.login_time = DateTime.Now;

                                    ////默认可选参数组
                                    //WC_model.money = 0;
                                    //WC_model.quanxian = "Enterprise";
                                    //WC_model.username = username;
                                    //WC_model.GUID = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("guid");

                                    ////webserver api 到主站注册
                                    //ROYcms.UI.Admin.WC_ROYcms_user.ROYcms_user User = new ROYcms.UI.Admin.WC_ROYcms_user.ROYcms_user();
                                    //User.Url = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("ucenter_webserver") + "administrator/WebService/ROYcms_user.asmx";
                                    //if (User.Add(WC_model) != 1)
                                    //{
                                    //    //为实现验证是否存在该用户
                                    //    MessageBox.ShowAndRedirect(this, "注册本站/通行证成功！可以在站群之间漫游！", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + "administrator/index.aspx");
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.ShowAndRedirect(this, "注册本站成功！注册通行证失败！将直接转到会员后台！", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + "administrator/index.aspx");
                                    //}
                                }
                                catch
                                {

                                    MessageBox.ShowAndRedirect(this, "注册本站成功！注册通行证失败！将直接转到会员后台！", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + "administrator/index.aspx");
                                }
                            }
                            else
                            {
                                MessageBox.ShowAndRedirect(this, "注册主站点成功！将直接转到会员后台！", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_host") + "administrator/index.aspx");
                            }
                        }
                        else
                        { 
                            try
                            {
                                user.Delete(_bh);//回滚删除刚注册的用户
                            }
                            catch
                            {
                                MessageBox.ShowAndRedirect(this, "初始化店铺失败！", "Enterprise_reg.aspx");
                            }

                            MessageBox.ShowAndRedirect(this, "初始化店铺失败！", "Enterprise_reg.aspx");
                        }
                    }
                    else { MessageBox.ShowAndRedirect(this, "注册失败！", "Enterprise_reg.aspx"); }

                }
                else { MessageBox.Show(this, "该用户已经存在！"); }

            }
            else { MessageBox.Show(this, "验证码错误！"); }


        }
    }
}