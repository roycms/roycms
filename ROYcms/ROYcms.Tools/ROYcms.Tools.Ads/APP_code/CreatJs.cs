using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using System.IO;
/// <summary>
///CreatJs 的摘要说明
/// </summary>
public class CreatJs
{
	public CreatJs()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    
    /// <summary>
    /// 生成广告js
    /// </summary>
    /// <param name="type">文件类型，0图片，1FLASH</param>
    /// <returns></returns>
    public static string CreatepicFile(AdMsgInfo minfo)
    {

        //判断是否有当前路径如果有添，如果没有新建目录
        string pathtemp = "/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/";

        string path = HttpContext.Current.Server.MapPath("~" + pathtemp);

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string filename = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".js";




        Encoding code = Encoding.GetEncoding("utf-8");
        // 读取模板文件 
        StringBuilder str = new StringBuilder();

        if (minfo.adtype == 0)
        {
            str.Append("document.write('");
            str.Append("<a href=\"" + minfo.adurl.ToString() + "\" target=\"_blank\">");
            str.Append("<img src=\"" + minfo.adpic.ToString() + "\" border=0 width=\"" + minfo.adwidth.ToString() + "\" height=\"" + minfo.adheight.ToString() + "\" alt=\"" + minfo.adname.ToString() + "\" align=top>");
            str.Append("</a>');");
        }
        else
        {
            str.Append("document.write('<EMBED src=\"" + minfo.adpic.ToString() + "\" quality=high WIDTH=\"" + minfo.adwidth.ToString() + "\" HEIGHT=\"" + minfo.adheight.ToString() + "\" TYPE=\"application/x-shockwave-flash\" PLUGINSPAGE=\"http://www.macromedia.com/go/getflashplayer\"></EMBED>');");
        }

        StreamWriter sw = null;
        // 写文件 
        if (minfo.adjs.ToString().Length > 0)
        {
            try
            {
                sw = new StreamWriter(HttpContext.Current.Server.MapPath("~" + minfo.adjs.ToString()), false, code);
                sw.Write(str);
                sw.Flush();
                return minfo.adjs.ToString();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
                HttpContext.Current.Response.End();
                return "";
            }
            finally
            {
                sw.Close();
            }
        }
        else
        {
            try
            {
                sw = new StreamWriter(path + filename, false, code);
                sw.Write(str);
                sw.Flush();
                return pathtemp + filename;
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message);
                HttpContext.Current.Response.End();
                return "";
            }
            finally
            {
                sw.Close();
            }
        }

        //return "";

    }
}