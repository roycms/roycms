using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
    /// 实体类ROYcms_Class_UGroup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Class_UGroup
	{
        public ROYcms_Class_UGroup()
		{}
        #region Model
        private int _id;
        private int? _class_id;
        private int? _ugroup_id;
        private int? _user_id;
        private DateTime? _time;
        /// <summary>
        /// 编号
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 类编号
        /// </summary>
        public int? Class_id
        {
            set { _class_id = value; }
            get { return _class_id; }
        }
        /// <summary>
        /// 用户组编号
        /// </summary>
        public int? UGroup_id
        {
            set { _ugroup_id = value; }
            get { return _ugroup_id; }
        }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int? User_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        #endregion Model

	}
}

