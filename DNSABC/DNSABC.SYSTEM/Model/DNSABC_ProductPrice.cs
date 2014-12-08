using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 产品价格表
	/// </summary>
	[Serializable]
	public partial class DNSABC_ProductPrice
	{
		public DNSABC_ProductPrice()
		{}
		#region Model
		private int _id;
		private int _productid;
		private int _gradeid=0;
		private int _userid=0;
		private int _realprice=0;
		private int _price=0;
		private int _month=1;
		private DateTime? _updatetime;
		private DateTime? _createtime;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 产品ID 产品ID必须存在
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 等级ID 等级ID和用户ID必须有一个为0
		/// </summary>
		public int GradeID
		{
			set{ _gradeid=value;}
			get{return _gradeid;}
		}
		/// <summary>
		/// 用户ID 等级ID和用户ID必须有一个为0
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 原价 产品原价
		/// </summary>
		public int RealPrice
		{
			set{ _realprice=value;}
			get{return _realprice;}
		}
		/// <summary>
		/// 价格 销售价格
		/// </summary>
		public int Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 月数 产品订购时限
		/// </summary>
		public int MONTH
		{
			set{ _month=value;}
			get{return _month;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

