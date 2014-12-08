<%@ WebHandler Language="C#" Class="validateCode" %>
using System;
using System.Web;
using System.Web.SessionState;
public class validateCode : IHttpHandler, IRequiresSessionState
{
    /// <summary>
    /// 入口
    /// </summary>
    /// <param name="context"></param>
    public void ProcessRequest(HttpContext context)
    {

        context.Session["code"] = RandNum(4);
        ValidateCode(context, context.Session["code"].ToString(), 40, 21, "黑体", 10, context.Request["color"] == null ? "#FCFCFC" : context.Request["color"]);
    }
    /// <summary>
    /// 
    /// </summary>
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="VcodeNum"></param>
    /// <returns>返回一个随机数字符串</returns>
    public string RandNum(int VcodeNum)
    {
        string Vchar = "2,3,4,5,6,7,8,9,A,,C,D,E,F,G,H,G,H,M,N,V,Q,R,S,T,U,V,W,X,Y,Z";
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
    /// <summary>
    /// 生成图片并写入字符
    /// </summary>
    /// <param name="context"></param>
    /// <param name="VNum"></param>
    /// <param name="w"></param>
    /// <param name="h"></param>
    /// <param name="font"></param>
    /// <param name="fontSize"></param>
    /// <param name="bgColor"></param>
    public void ValidateCode(HttpContext context, string VNum, int w, int h, string font, int fontSize, string bgColor)
    {
        System.Drawing.Bitmap Img = new System.Drawing.Bitmap(w, h);//生成图像的实例
        System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(Img);//从Img对象生成新的Graphics对象
        g.Clear(System.Drawing.ColorTranslator.FromHtml(bgColor));//背景颜色
        System.Drawing.Font f = new System.Drawing.Font(font, fontSize);//生成Font类的实例
        System.Drawing.SolidBrush s = new System.Drawing.SolidBrush(System.Drawing.Color.Black);//生成笔刷类的实例
        g.DrawString(VNum, f, s, 3, 3);//将VNum写入图片中
        Img.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);//将此图像以Jpeg图像文件的格式保存到流中
        context.Response.ContentType = "image/Jpeg";
        g.Dispose();//回收资源
        Img.Dispose();
        context.Response.End();
    }
}