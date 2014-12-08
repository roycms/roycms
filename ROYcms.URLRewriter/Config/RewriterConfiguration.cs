using System;
using System.Web;
using System.Web.Caching;
using System.Configuration;
using System.Xml.Serialization;
using System.Xml;
using System.Data;
using System.IO;

namespace ROYcms.URLRewriter.Config
{
	/// <summary>
	/// Specifies the configuration settings in the Web.config for the RewriterRule.
	/// </summary>
	/// <remarks>This class defines the structure of the Rewriter configuration file in the Web.config file.
	/// Currently, it allows only for a set of rewrite rules; however, this approach allows for customization.
	/// For example, you could provide a ruleset that <i>doesn't</i> use regular expression matching; or a set of
	/// constant names and values, which could then be referenced in rewrite rules.
	/// <p />
	/// The structure in the Web.config file is as follows:
	/// <code>
	/// &lt;configuration&gt;
	/// 	&lt;configSections&gt;
	/// 		&lt;section name="RewriterConfig" 
	/// 		            type="URLRewriter.Config.RewriterConfigSerializerSectionHandler, URLRewriter" /&gt;
	///		&lt;/configSections&gt;
	///		
	///		&lt;RewriterConfig&gt;
	///			&lt;Rules&gt;
	///				&lt;RewriterRule&gt;
	///					&lt;LookFor&gt;<i>pattern</i>&lt;/LookFor&gt;
	///					&lt;SendTo&gt;<i>replace with</i>&lt;/SendTo&gt;
	///				&lt;/RewriterRule&gt;
	///				&lt;RewriterRule&gt;
	///					&lt;LookFor&gt;<i>pattern</i>&lt;/LookFor&gt;
	///					&lt;SendTo&gt;<i>replace with</i>&lt;/SendTo&gt;
	///				&lt;/RewriterRule&gt;
	///				...
	///				&lt;RewriterRule&gt;
	///					&lt;LookFor&gt;<i>pattern</i>&lt;/LookFor&gt;
	///					&lt;SendTo&gt;<i>replace with</i>&lt;/SendTo&gt;
	///				&lt;/RewriterRule&gt;
	///			&lt;/Rules&gt;
	///		&lt;/RewriterConfig&gt;
	///		
	///		&lt;system.web&gt;
	///			...
	///		&lt;/system.web&gt;
	///	&lt;/configuration&gt;
	/// </code>
	/// </remarks>
	[Serializable()]
	[XmlRoot("RewriterConfig")]
	public class RewriterConfiguration
	{
		// private member variables
		private RewriterRuleCollection rules;			// an instance of the RewriterRuleCollection class...

		/// <summary>
		/// GetConfig() returns an instance of the <b>RewriterConfiguration</b> class with the values populated from
		/// the Web.config file.  It uses XML deserialization to convert the XML structure in Web.config into
		/// a <b>RewriterConfiguration</b> instance.
		/// </summary>
		/// <returns>A <see cref="RewriterConfiguration"/> instance.</returns>
        public static RewriterConfiguration GetConfig()
        {
            if (HttpContext.Current.Cache["RewriterConfig"] == null)
                HttpContext.Current.Cache.Insert("RewriterConfig", ConfigurationManager.GetSection("RewriterConfig"));

            return (RewriterConfiguration)HttpContext.Current.Cache["RewriterConfig"];
        }
        //public static RewriterConfiguration GetConfig()
        //{
        //    if (HttpContext.Current.Cache["RewriterConfig"] == null)
        //        HttpContext.Current.Cache.Insert("RewriterConfig", (object)ReadNodes(HttpContext.Current.Server.MapPath("~/administrator/app_config/urls.config"), "RewriterConfig/Rules"));


        //    return (DataView)HttpContext.Current.Cache["RewriterConfig"];
        //}
		#region Public Properties
		/// <summary>
		/// A <see cref="RewriterRuleCollection"/> instance that provides access to a set of <see cref="RewriterRule"/>s.
		/// </summary>
		public RewriterRuleCollection Rules
		{
			get
			{
				return rules;
			}
			set
			{
				rules = value;
			}
		}
		#endregion

        #region 扩展方法===================================================
        /// <summary>
        /// 读取XML的所有子节点
        /// </summary>
        /// <param name="filePath">XML文件绝对路径</param>
        /// <param name="xPath">范例: @"Skill/First/SkillItem"</param>
        /// <returns></returns>
        public static DataView ReadNodes(string filePath, string xPath)
        {
            try
            {
                XmlDocument doc = new XmlDocument(); 
                DataSet _ds = new DataSet();
                doc.Load(filePath);
                XmlNode xn = doc.SelectSingleNode(xPath);
                //XmlNodeList xnList = xn.ChildNodes;  //得到该节点的子节点
                //return xnList;
                StringReader _read = new StringReader(xn.OuterXml);
                _ds.ReadXml(_read);
                return _ds.Tables[0].DefaultView;
            }
            catch
            {
                return null;
            }
        }

        #endregion 扩展方法
	}
}
