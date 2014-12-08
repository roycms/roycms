using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_user 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class ROYcms_user
	{
		public ROYcms_user()
		{}
        #region Model
        private int _bh;
        private string _roleid;
        private string _ugroupid;
        private string _name;
        private string _password;
        private int? _money;
        private string _qq;
        private string _email;
        private int? _age;
        private DateTime? _login_time;
        private string _sex;
        private string _pic;
        private string _quanxian;
        private string _username;
        private string _guid;
        private string _ip;
        /// <summary>
        /// 唯一标识
        /// </summary>
        public int bh
        {
            set { _bh = value; }
            get { return _bh; }
        }
        /// <summary>
        /// 权限ID
        /// </summary>
        public string RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 分组ID
        /// </summary>
        public string UgroupID
        {
            set { _ugroupid = value; }
            get { return _ugroupid; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 金币
        /// </summary>
        public int? money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// qq
        /// </summary>
        public string qq
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public int? age
        {
            set { _age = value; }
            get { return _age; }
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? login_time
        {
            set { _login_time = value; }
            get { return _login_time; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 形象图/头像
        /// </summary>
        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
        /// <summary>
        /// 权限标识
        /// </summary>
        public string quanxian
        {
            set { _quanxian = value; }
            get { return _quanxian; }
        }
        /// <summary>
        /// 昵称
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// GUID站群全局标示
        /// </summary>
        public string GUID
        {
            set { _guid = value; }
            get { return _guid; }
        }
        /// <summary>
        /// ip地址
        /// </summary>
        public string ip
        {
            set { _ip = value; }
            get { return _ip; }
        }
        #endregion Model

	}
}

