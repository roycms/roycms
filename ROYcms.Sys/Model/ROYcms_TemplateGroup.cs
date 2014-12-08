using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Sys.Model
{
  public  class ROYcms_TemplateGroup
    {
        public ROYcms_TemplateGroup()
        { }
        #region Model
        private int _bh;
        private string _z_name;
        private string _z_path;
        private string _z_url;
        private string _z_content;
        private DateTime? _z_time;
        /// <summary>
        /// 编号
        /// </summary>
        public int bh
        {
            set { _bh = value; }
            get { return _bh; }
        }
        /// <summary>
        /// 模板组名称
        /// </summary>
        public string z_name
        {
            set { _z_name = value; }
            get { return _z_name; }
        }
        /// <summary>
        /// 模板组地址
        /// </summary>
        public string z_path
        {
            set { _z_path = value; }
            get { return _z_path; }
        }
        /// <summary>
        /// 模板组URL
        /// </summary>
        public string z_url
        {
            set { _z_url = value; }
            get { return _z_url; }
        }
        /// <summary>
        /// 模板组 内容
        /// </summary>
        public string z_content
        {
            set { _z_content = value; }
            get { return _z_content; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? z_time
        {
            set { _z_time = value; }
            get { return _z_time; }
        }
        #endregion Model

    }
}
