using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 相册表
	/// </summary>
	[Serializable]
	public partial class ROYcms_Synonyms
	{
		public ROYcms_Synonyms()
		{}
		#region Model
		private int _id;
		private string _find;
		private string _replace;
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
		public string find
		{
			set{ _find=value;}
			get{return _find;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REPLACE
		{
			set{ _replace=value;}
			get{return _replace;}
		}
		#endregion Model

	}
}

