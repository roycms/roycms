using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using ROYcms.Sys.BLL;
using System.Data;
namespace ROYcms.Templet
{
   public class TemplateZone
    {
      
        /// <summary>
        /// Templates the zpath. //返回绑定的URL
        /// </summary>
        /// <param name="Host">The host.</param>
        /// <returns></returns>
       public static string TemplateZpath(string Host)
       {
           string _template_name = "default";
           if (Host != null)
           {
               ROYcms.Sys.BLL.ROYcms_TemplateGroup BLL = new ROYcms.Sys.BLL.ROYcms_TemplateGroup();
               DataTable _Table = BLL.GetAllList().Tables[0];
               for (int i = 0; i < _Table.Rows.Count; i++)
               {
                   if (Host.Contains(_Table.Rows[i]["z_url"].ToString().Trim()))
                   {
                       _template_name = _Table.Rows[i]["z_path"].ToString().Trim();
                   }
               }
           }
           return _template_name;
       }
       /// <summary>
       /// Zpathes the specified host.
       /// </summary>
       /// <param name="Host">The host.</param>
       /// <returns></returns>
       public static string Zpath(string Host) 
       {
           if (TemplateZpath(Host) == "default")
           {
               return null;
           }
           else {
               return TemplateZpath(Host) + "/";
           }
       }
    }
}
