using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Role 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_New_User
	{
        public ROYcms_New_User()
		{}
        #region Model
        private int _id;
        private int? _new_id;
        private int? _user_id;
        private DateTime? _time;
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
        public int? New_id
        {
            set { _new_id = value; }
            get { return _new_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? User_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        #endregion Model

	}
}

