using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Drawing;
namespace ROYcms.Common
{
    public class validateCode : System.Web.UI.Page
    {

        /// <returns>返回一个随机数字符串</returns>
        public string RandNum(int VcodeNum)
        {
            string Vchar = "0,1,2,3,4,5,6,7,8,9";
            string[] VcArray = Vchar.Split(',');//拆分成数组
            string VNum = "";
            int temp = -1;//记录上次随机数值，尽量避避免生产几个一样的随机数
            Random rand = new Random();
            //采用一个简单的算法以保证生成随机数的不同
            for (int i = 0; i < VcodeNum; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(VcArray.Length - 1);
                if (temp != -1 && temp == t)
                {
                    return RandNum(VcodeNum);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;
        }
        /// 生成图片并写入字符
        public void ValidateCode(string VNum, int w, int h, string font, int fontSize, string bgColor)
        {
            Bitmap Img = new Bitmap(w, h);//生成图像的实例
            Graphics g = Graphics.FromImage(Img);//从Img对象生成新的Graphics对象
            g.Clear(ColorTranslator.FromHtml(bgColor));//背景颜色
            Font f = new Font(font, fontSize);//生成Font类的实例
            SolidBrush s = new SolidBrush(Color.Black);//生成笔刷类的实例
            g.DrawString(VNum, f, s, 3, 3);//将VNum写入图片中
            Img.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);//将此图像以Jpeg图像文件的格式保存到流中
            Response.ContentType = "image/Jpeg";
            //回收资源
            g.Dispose();
            Img.Dispose();
            Response.End();
        }
    }
    //调用方法
    //Session["code"] = RandNum(4);
    //ValidateCode(Session["code"].ToString(), 40, 20, "黑体", 10, "#FFFFFF");

}