using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Sys.Model
{
    public class ROYcmsConfig
    {
        private string _GUID;
        private string _UcenterWebserver;
        private string _UcenterPassword;


        private string _web_host;
        private string _web_forge;
        private string _web_name;
        private string _templet_language;
        private string _templet_root;
        private string _templet_file;
        private string _HTML_zip;
        private string _date_prefix;
        private string _FileManager_file_type;
        private string _FileManager_root;
        private string _password;
        private string _WEBSITE_UP_FILES;
        private string _HTML;

        private string _logo;      
        private string _title;     
        private string _keyword;
        private string _Description;
        private string _Copyright;
        /// <summary>
        /// GUID
        /// </summary>
        public string GUID
        {
            set { _GUID = value; }
            get { return _GUID; }
        }
        /// <summary>
        /// UcenterWebserver  API接口地址
        /// </summary>
        public string UcenterWebserver
        {
            set { _UcenterWebserver = value; }
            get { return _UcenterWebserver; }
        }
        /// <summary>
        /// UcenterWebserver  API接口地址
        /// </summary>
        public string UcenterPassword
        {
            set { _UcenterPassword = value; }
            get { return _UcenterPassword; }
        }
        /// <summary>
        /// logo
        /// </summary>
        public string logo
        {
            set { _logo = value; }
            get { return _logo; }
        }
        /// <summary>
        /// title
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// keyword
        /// </summary>
        public string keyword
        {
            set { _keyword = value; }
            get { return _keyword; }
        }
        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            set { _Description = value; }
            get { return _Description; }
        }
        /// <summary>
        /// 主域名
        /// </summary>
        public string web_host
        {
            set { _web_host = value; }
            get { return _web_host; }
        }
        /// <summary>
        /// 文件扩展名
        /// </summary>
        public string web_forge
        {
            set { _web_forge = value; }
            get { return _web_forge; }
        }
        /// <summary>
        /// 网站名称
        /// </summary>
        public  string web_name
        {
            set { _web_name = value; }
            get { return _web_name; }
        }
        /// <summary>
        /// 模板编码 GB2312 | utf-8
        /// </summary>
        public  string templet_language
        {
            set { _templet_language = value; }
            get { return _templet_language; }
        }
        /// <summary>
        /// 模板文件夹
        /// </summary>
        public string templet_root
        {
            set { _templet_root = value; }
            get { return _templet_root; }
        }
        /// <summary>
        /// 当前模板组文件夹
        /// </summary>
        public string templet_file
        {
            set { _templet_file = value; }
            get { return _templet_file; }
        }
        /// <summary>
        /// 网站输出压缩
        /// </summary>
        public  string HTML_zip
        {
            set { _HTML_zip = value; }
            get { return _HTML_zip; }
        }
        /// <summary>
        /// 数据库前缀
        /// </summary>
        public  string date_prefix
        {
            set { _date_prefix = value; }
            get { return _date_prefix; }
        }
        /// <summary>
        /// 文件管理可编辑的文件扩展名
        /// </summary>
        public  string FileManager_file_type
        {
            set { _FileManager_file_type = value; }
            get { return _FileManager_file_type; }
        }
        /// <summary>
        /// 文件管理的根目录
        /// </summary>
        public  string FileManager_root
        {
            set { _FileManager_root = value; }
            get { return _FileManager_root; }
        }
        /// <summary>
        /// 系统管理员密码
        /// </summary>
        public  string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        ///上传目录
        /// </summary>
        public  string WEBSITE_UP_FILES
        {
            set { _WEBSITE_UP_FILES = value; }
            get { return _WEBSITE_UP_FILES; }
        }
        /// <summary>
        ///静态生成 开关
        /// </summary>
        public  string HTML
        {
            set { _HTML = value; }
            get { return _HTML; }
        }
        /// <summary>
        ///版权信息
        /// </summary>
        public string Copyright
        {
            set { _Copyright = value; }
            get { return _Copyright; }
        }
    }

}
