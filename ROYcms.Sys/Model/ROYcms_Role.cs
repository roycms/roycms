using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Role 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Role
	{
		public ROYcms_Role()
		{}
        #region Model
        private int _id;
        private string _name;
        private string _zhaiyao;
        private DateTime? _time;
        private string _guid;
        /// <summary>
        /// 编号
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 权限描述
        /// </summary>
        public string zhaiyao
        {
            set { _zhaiyao = value; }
            get { return _zhaiyao; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        /// <summary>
        /// 全局标识
        /// </summary>
        public string GUID
        {
            set { _guid = value; }
            get { return _guid; }
        }
        #endregion Model

	}
}

