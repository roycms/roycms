using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml;
using System.IO;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class small_add_order : System.Web.UI.Page
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["orderId"] != null && Request["orderAmount"] != null && Request["productName"] != null && Request["productNum"] != null)
                {
                    Order_add(Request["orderId"], Request["orderAmount"], Request["productName"], Request["productNum"], Request["k"]);
                }
            }
            
        }

        /// <summary>
        /// 创建订单
        /// </summary>
        /// <param name="orderId">订单号</param>
        /// <param name="orderAmount">价格 </param>
        /// <param name="productName">产品名称</param>
        /// <param name="productNum">数量</param>
        /// <param name="k">k</param>
        protected void Order_add(string orderId, string orderAmount, string productName, string productNum,string k)
        {
            string order_id = orderId;
            
            string user_id = ROYcms.Common.Session.Get("user_id") ; //用户id
            string order_status="1"; //订单状态 默认未支付0代表已经支付
            decimal order_price = decimal.Parse(orderAmount); //订单金额
            string order_payment = ""; // 支付方式
            string order_rec_name=""; //收件人
            string order_rec_address=""; //收件人地址
            string order_rec_code="";//邮编
            string order_rec_phone="";//手机
            string order_rec_tel="";//固话
            string order_shipping = "";//配送方式
            decimal order_freight = 0;//运费
            string order_deliveryTime = DateTime.Now.ToString();//送货时间
            DateTime create_time = DateTime.Now;//订单创建时间
            bool ifdefault=true; //默认地址

            ROYcms.Sys.Model.ROYcms_product_order model=new ROYcms.Sys.Model.ROYcms_product_order();
            model.order_id=order_id;
            model.user_id=user_id;
            model.order_status=order_status;
            model.order_price=order_price;
            model.order_payment=order_payment;
            model.order_rec_name=order_rec_name;
            model.order_rec_address=order_rec_address;
            model.order_rec_code=order_rec_code;
            model.order_rec_phone=order_rec_phone;
            model.order_rec_tel=order_rec_tel;
            model.order_shipping=order_shipping;
            model.order_freight=order_freight;
            model.order_deliveryTime=order_deliveryTime;
            model.create_time=create_time;
            model.ifdefault=ifdefault;

            ROYcms.Sys.BLL.ROYcms_product_order bll = new ROYcms.Sys.BLL.ROYcms_product_order();
            NewXml(bll.Add(model));



            Response.Redirect("/administrator/Payment/99bill/99bill.aspx?orderId=" + orderId + "&orderAmount=" + orderAmount + "&productName=" + productName + "&productNum=" + productNum + "&k=" + k);
            
        }


        /// <summary>
        /// 创建XML 数据文件  News the XML.
        /// </summary>
        /// <returns></returns>
        public bool NewXml(int ID)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"), null);
                doc.AppendChild(dec);
                //创建一个根节点（一级） 
                XmlElement root = doc.CreateElement("ROYcms");
                doc.AppendChild(root);
                //创建节点（二级） 
                XmlNode node = doc.CreateElement("Order");
                XmlAttribute attr = null;
                attr = doc.CreateAttribute("Time");
                attr.Value = DateTime.Now.ToString();
                node.Attributes.SetNamedItem(attr);
                for (int i = 0; i < Request.Params.Count; i++)
                {
                    //Request.Form.Remove("");
                    //带有"<![CDATA[   ]]>"的元素 
                    if (!Request.Params.GetKey(i).Contains("_"))
                    {
                        XmlElement element = doc.CreateElement(Request.Params.GetKey(i));
                        //element.SetAttribute("Name", Request.Form.GetKey(i));
                        ////element.InnerText = "Round Comment";
                        XmlCDataSection idata = doc.CreateCDataSection("item");
                        idata.InnerText = Request.Params.Get(i);
                        element.AppendChild(idata);
                        node.AppendChild(element);
                    }
                }
                root.AppendChild(node);
                if (!Directory.Exists(Server.MapPath("~/APP_XML/Order/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/APP_XML/Order/")); //创建新路径 
                }
                doc.Save(Server.MapPath("~/APP_XML/Order/" + ID + ".xml"));
                Console.Write(doc.OuterXml);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
