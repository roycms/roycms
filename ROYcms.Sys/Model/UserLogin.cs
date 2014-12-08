using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类UserLogin
	/// </summary>
    [Serializable]
    public class UserLogin
    {
        public UserLogin()
        { }
        #region Model
        private string _username = null;//用户名
        private string _email = null;   //邮箱
        private string _password = null;//密码
        private string _k = null;       //快捷登陆
        private string _valdates = null;//验证码
        private string _Url = null;     //登陆后返回URL
        /// <summary>
        /// 用户名
        /// </summary>
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// 快捷登录开关
        /// </summary>
        public string k
        {
            get { return _k; }
            set { _k = value; }
        }
        /// <summary>
        /// 验证码
        /// </summary>
        public string valdates
        {
            get { return _valdates; }
            set { _valdates = value; }
        }
        /// <summary>
        /// 登录成功返回的地址
        /// </summary>
        /// <value>The URL.</value>
        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }
        #endregion Model

    }
}

