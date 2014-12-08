using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ROYcms.Templet
{
    /// <summary>
    /// 自定义部分数据
    /// </summary>
   public class Xml
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="ID">bh  标识 The ID.</param>
        /// <param name="ClassKind">Kind of the class.</param>
        /// <param name="name">项的名称 The name.</param>
        /// <returns></returns>
       public static string GetValue(int ID, string ClassKind, string name) 
       {
           try
           {
               ROYcms.Common.XmlControl XmlControl = new ROYcms.Common.XmlControl(HttpContext.Current.Server.MapPath("~/APP_XML/" + ClassKind + "/" + ID + ".xml"));
               return XmlControl.GetText("ROYcms/News/" + name);
           }
           catch
           {
               return "";
           }
       }
       /// <summary>
       /// Gets the value.
       /// </summary>
       /// <param name="ID">bh  标识 The ID.</param>
       /// <param name="ClassKind">Kind of the class.</param>
       /// <param name="name">项的名称 The name.</param>
       /// <returns></returns>
       public static string GetClassValue(int ID, string name)
       {
           try
           {
               ROYcms.Common.XmlControl XmlControl = new ROYcms.Common.XmlControl(HttpContext.Current.Server.MapPath("~/APP_data/Class/" + ID + ".xml"));
               return XmlControl.GetText("ROYcms/Class/" + name);
           }
           catch
           {
               return "";
           }
       }
       /// <summary>
       /// Gets the organization value.
       /// </summary>
       /// <param name="userid">The userid.</param>
       /// <param name="name">项的名称 The name.</param>
       /// <returns></returns>
       public static string GetUserValue(int userid, string name)
       {
           try
           {
               ROYcms.Common.XmlControl XmlControl = new ROYcms.Common.XmlControl(HttpContext.Current.Server.MapPath("~/APP_XML/UserXml/" + userid + ".xml"));
               return XmlControl.GetText("ROYcms/User/" + name);
           }
           catch
           {
               return "";
           }
       }
       /// <summary>
       /// Gets the organization value.
       /// </summary>
       /// <param name="ID">id 标识 The ID.</param>
       /// <param name="name">项的名称 The name.</param>
       /// <returns></returns>
       public static string GetOrganizationValue(int ID, string name)
       {
           try
           {
               ROYcms.Common.XmlControl XmlControl = new ROYcms.Common.XmlControl(HttpContext.Current.Server.MapPath("~/APP_XML/Organization/" + ID + ".xml"));
               return XmlControl.GetText("ROYcms/Organization/" + name);
           }
           catch
           {
               return "";
           }
       }
    }
}
