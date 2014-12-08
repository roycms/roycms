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
///AdSortInfo 广告栏目
/// </summary>
public class AdSortInfo
{
	public AdSortInfo()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
    }
    #region ModelAdSortInfo
    private int _id;
    private string _sortname;
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
    public string sortname
    {
        set { _sortname = value; }
        get { return _sortname; }
    }
    #endregion ModelAdSortInfo
}
