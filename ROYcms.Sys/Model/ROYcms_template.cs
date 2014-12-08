using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_template 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class ROYcms_template
	{
		public ROYcms_template()
		{}
		#region Model
        private int _bh;
        private int _z_id;
		private string _name;
		private string _tag;
		private string _htmlcontent;
        private int? _y;
		private DateTime? _htmltimes;
        private string _class_name;
		/// <summary>
		/// 编号        
		/// </summary>
		public int bh
		{
			set{ _bh=value;}
			get{return _bh;}
        }	
        /// <summary>
        /// 模板组ID
        /// </summary>
        public int z_id
        {
            set { _z_id = value; }
            get { return _z_id; }
        }
		/// <summary>
		/// 模板名称
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 标签
		/// </summary>
		public string tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// HTML 内容
		/// </summary>
		public string htmlcontent
		{
			set{ _htmlcontent=value;}
			get{return _htmlcontent;}
		}
        /// <summary>
        /// 类 name
        /// </summary>
        public string class_name
        {
            set { _class_name = value; }
            get { return _class_name; }
        }
        /// <summary>
        /// 状态标识
        /// </summary>
        public int? y
        {
            set { _y = value; }
            get { return _y; }
        }
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? htmltimes
		{
			set{ _htmltimes=value;}
			get{return _htmltimes;}
		}
		#endregion Model

	}
}

