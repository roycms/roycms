using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Objet 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Objet
	{
		public ROYcms_Objet()
		{}
		#region Model
		private int _id;
        private int _ClassKind;
		private string _title;
		private string _zhaiyao;
		private string _logo;
		private string _appendixconfig;
		private string _appendixpath;
		private int? _visible;
		private string _role;
		private DateTime? _time;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
        /// <summary>
        /// 
        /// </summary>
        public int ClassKind
        {
            set { _ClassKind = value; }
            get { return _ClassKind; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zhaiyao
		{
			set{ _zhaiyao=value;}
			get{return _zhaiyao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AppendixConfig
		{
			set{ _appendixconfig=value;}
			get{return _appendixconfig;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AppendixPath
		{
			set{ _appendixpath=value;}
			get{return _appendixpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Visible
		{
			set{ _visible=value;}
			get{return _visible;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Role
		{
			set{ _role=value;}
			get{return _role;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

