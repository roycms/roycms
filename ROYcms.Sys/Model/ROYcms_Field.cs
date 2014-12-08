using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 自定义字段的字段表 ROYcms_Field 自定义字段的字段表 ROYcms_Field
	/// </summary>
	[Serializable]
	public partial class ROYcms_Field
	{
		public ROYcms_Field()
		{}
		#region Model
		private int _id;
		private int? _rid;
		private string _name;
		private string _lable;
		private int? _len;
		private int? _fieldtype;
		private int? _isnull;
		private int? _iskey;
		private string _defaultval;
		private int? _display;
		private string _expression;
		private string _inputtype;
		private int? _inputlen;
		private int? _orderby;
		private DateTime? _time= DateTime.Now;
		/// <summary>
		/// 编号 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 模型ID关联ROYcms_Model的id 模型ID关联ROYcms_Model的id
		/// </summary>
		public int? Rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 字段名称 字段名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 字段的Lable 字段的Lable
		/// </summary>
		public string Lable
		{
			set{ _lable=value;}
			get{return _lable;}
		}
		/// <summary>
		/// 字段的长度 字段的长度
		/// </summary>
		public int? Len
		{
			set{ _len=value;}
			get{return _len;}
		}
		/// <summary>
		/// 字段的类型 字段的类型
		/// </summary>
		public int? FieldType
		{
			set{ _fieldtype=value;}
			get{return _fieldtype;}
		}
		/// <summary>
		/// 是否为空 是否为空
		/// </summary>
		public int? IsNull
		{
			set{ _isnull=value;}
			get{return _isnull;}
		}
		/// <summary>
		/// 是否为主键 是否为主键
		/// </summary>
		public int? IsKey
		{
			set{ _iskey=value;}
			get{return _iskey;}
		}
		/// <summary>
		/// 默认值 默认值
		/// </summary>
		public string DefaultVal
		{
			set{ _defaultval=value;}
			get{return _defaultval;}
		}
		/// <summary>
		/// 显示可见状态 显示可见状态
		/// </summary>
		public int? Display
		{
			set{ _display=value;}
			get{return _display;}
		}
		/// <summary>
		/// 显示表达式 显示表达式
		/// </summary>
		public string Expression
		{
			set{ _expression=value;}
			get{return _expression;}
		}
		/// <summary>
		/// input输入框的类型
		/// </summary>
		public string InputType
		{
			set{ _inputtype=value;}
			get{return _inputtype;}
		}
		/// <summary>
		/// Input的显示长度
		/// </summary>
		public int? InputLen
		{
			set{ _inputlen=value;}
			get{return _inputlen;}
		}
		/// <summary>
		/// OrderBy显示顺序 OrderBy显示顺序
		/// </summary>
		public int? OrderBy
		{
			set{ _orderby=value;}
			get{return _orderby;}
		}
		/// <summary>
		/// 时间 时间
		/// </summary>
		public DateTime? TIME
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

