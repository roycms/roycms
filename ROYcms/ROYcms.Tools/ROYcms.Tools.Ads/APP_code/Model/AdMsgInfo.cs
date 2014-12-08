using System;
using System.Data;
using System.Configuration;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


/// <summary>
///AdMsgInfo 的摘要说明
/// </summary>
public class AdMsgInfo
{
	public AdMsgInfo()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    #region ModelAdMsgInfo
    private int _id;
    private int? _sid;
    private string _adname;
    private string _adpic;
    private string _adurl;
    private int? _adtype;
    private int? _adstop;
    private int? _adwidth;
    private int? _adheight;
    private DateTime? _adcreattime;
    private DateTime? _adendtime;
    private int? _adcount;
    private string _adjs;
    /// <summary>
    /// 
    /// </summary>
    public int id
    {
        set { _id = value; }
        get { return _id; }
    }
    /// <summary>
    /// 所属栏目
    /// </summary>
    public int? sid
    {
        set { _sid = value; }
        get { return _sid; }
    }
    /// <summary>
    /// 广告名称
    /// </summary>
    public string adname
    {
        set { _adname = value; }
        get { return _adname; }
    }
    /// <summary>
    /// 所对应的广告图片地址或动画地址
    /// </summary>
    public string adpic
    {
        set { _adpic = value; }
        get { return _adpic; }
    }
    /// <summary>
    /// 链接地址
    /// </summary>
    public string adurl
    {
        set { _adurl = value; }
        get { return _adurl; }
    }
    /// <summary>
    /// 广告类型(0图片,1动画)
    /// </summary>
    public int? adtype
    {
        set { _adtype = value; }
        get { return _adtype; }
    }
    /// <summary>
    /// 是否停用，0不停,1停
    /// </summary>
    public int? adstop
    {
        set { _adstop = value; }
        get { return _adstop; }
    }
    /// <summary>
    /// 广告宽度
    /// </summary>
    public int? adwidth
    {
        set { _adwidth = value; }
        get { return _adwidth; }
    }
    /// <summary>
    /// 广告高度
    /// </summary>
    public int? adheight
    {
        set { _adheight = value; }
        get { return _adheight; }
    }
    /// <summary>
    /// 发布时间
    /// </summary>
    public DateTime? adcreattime
    {
        set { _adcreattime = value; }
        get { return _adcreattime; }
    }
    /// <summary>
    /// 结束时间
    /// </summary>
    public DateTime? adendtime
    {
        set { _adendtime = value; }
        get { return _adendtime; }
    }
    /// <summary>
    /// 统计
    /// </summary>
    public int? adcount
    {
        set { _adcount = value; }
        get { return _adcount; }
    }
    /// <summary>
    /// 生成JS文件的地址
    /// </summary>
    public string adjs
    {
        set { _adjs = value; }
        get { return _adjs; }
    }
    #endregion ModelAdMsgInfo
}
