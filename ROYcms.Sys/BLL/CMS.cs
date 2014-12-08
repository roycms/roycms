using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// CMS
	/// </summary>
	public partial class CMS
	{
		private readonly ROYcms.Sys.DAL.CMS dal=new ROYcms.Sys.DAL.CMS();
		public CMS()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该表
		/// </summary>
		public bool Exists(string TableName)
		{
            return dal.Exists(TableName);
		}
         /// <summary>
        /// 删除表
        /// </summary>
        public bool DelTable(string TableName)
        {
            return dal.DelTable(TableName);
        }
		#endregion  Method
	}
}

