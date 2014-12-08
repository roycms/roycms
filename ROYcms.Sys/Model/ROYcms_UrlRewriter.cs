using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Sys.Model
{

    /// <summary>
    /// 实体类ROYcms_UrlRewriter 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class ROYcms_UrlRewriter
    {
        public ROYcms_UrlRewriter()
        { }
        #region Model
        private int _id;
        private string _old_url;
        private string _new_url;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string old_url
        {
            set { _old_url = value; }
            get { return _old_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string new_url
        {
            set { _new_url = value; }
            get { return _new_url; }
        }
        #endregion Model

    }
}
