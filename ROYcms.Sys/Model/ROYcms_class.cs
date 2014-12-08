using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Sys.Model
{    
  [Serializable]
  public class ROYcms_class
    {
        public ROYcms_class()
        { }
        #region Model
        private int _id;
        private string _classid;
        private string _classname;
        private string _classlist;
        private string _classpre;
        private int? _classtj;
        private int? _classorder;
        private int? _classkind;
        private int? _ContentType;
        private string _filepath;
        private int? _listtype;
        private int? _gotype;
        private string _defaultfile;
        private int? _columnstype;
        private string _websiteurl;
        private string _templateindex;
        private string _templatelist;
        private string _templateshow;
        private string _listerules;
        private string _showrules;
        private string _keyword;
        private string _description;
        private string _contents;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 类ID
        /// </summary>
        public string ClassId
        {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName
        {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// 类列表
        /// </summary>
        public string ClassList
        {
            set { _classlist = value; }
            get { return _classlist; }
        }
        /// <summary>
        /// 父类
        /// </summary>
        public string ClassPre
        {
            set { _classpre = value; }
            get { return _classpre; }
        }
        /// <summary>
        /// 栏目深度
        /// </summary>
        public int? ClassTj
        {
            set { _classtj = value; }
            get { return _classtj; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? ClassOrder
        {
            set { _classorder = value; }
            get { return _classorder; }
        }
        /// <summary>
        /// 分类类别
        /// </summary>
        public int? ClassKind
        {
            set { _classkind = value; }
            get { return _classkind; }
        }
        /// <summary>
        /// 类别
        /// </summary>
        public int? ContentType
        {
            set { _ContentType = value; }
            get { return _ContentType; }
        }
        /// <summary>
        /// 文件生成目录路径
        /// </summary>
        public string FilePath
        {
            set { _filepath = value; }
            get { return _filepath; }
        }
        /// <summary>
        /// 列表类型 0文章 1图片 2其他
        /// </summary>
        public int? ListType
        {
            set { _listtype = value; }
            get { return _listtype; }
        }
        /// <summary>
        /// 列表类型 0链接到默认页 1链接到列表第一页 2使用动态页 
        /// </summary>
        public int? GoType
        {
            set { _gotype = value; }
            get { return _gotype; }
        }
        /// <summary>
        /// 默认生成的文件地址
        /// </summary>
        public string DefaultFile
        {
            set { _defaultfile = value; }
            get { return _defaultfile; }
        }
        /// <summary>
        /// 栏目类型0最终列表栏目（允许在本栏目发布文档，并生成文档列表）1 频道封面（栏目本身不允许发布文档）2外部连接（在"文件保存目录"处填写网址） 
        /// </summary>
        public int? ColumnsType
        {
            set { _columnstype = value; }
            get { return _columnstype; }
        }
        /// <summary>
        /// 绑定地址/域名
        /// </summary>
        public string WebsiteUrl
        {
            set { _websiteurl = value; }
            get { return _websiteurl; }
        }
        /// <summary>
        /// 首页模版地址
        /// </summary>
        public string TemplateIndex
        {
            set { _templateindex = value; }
            get { return _templateindex; }
        }
        /// <summary>
        /// 列表模版地址
        /// </summary>
        public string TemplateList
        {
            set { _templatelist = value; }
            get { return _templatelist; }
        }
        /// <summary>
        /// 新闻页模版地址
        /// </summary>
        public string TemplateShow
        {
            set { _templateshow = value; }
            get { return _templateshow; }
        }
        /// <summary>
        /// 列表规则
        /// </summary>
        public string ListeRules
        {
            set { _listerules = value; }
            get { return _listerules; }
        }
        /// <summary>
        /// 文章地址规则
        /// </summary>
        public string ShowRules
        {
            set { _showrules = value; }
            get { return _showrules; }
        }
        /// <summary>
        /// 关键字
        /// </summary>
        public string keyword
        {
            set { _keyword = value; }
            get { return _keyword; }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string contents
        {
            set { _contents = value; }
            get { return _contents; }
        }
        #endregion Model

    }
}
