using System;
using System.Data;
using System.Configuration;
using ROYcms.DB;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Text;
using System.Data.SqlClient;
/// <summary>
///AdSort 的摘要说明
/// </summary>
public class AdSort
{
	public AdSort()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 增加一条数据
    /// </summary>
    public void AddAdSort(AdSortInfo sinfo)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into ROYcms_Ad_Sort(");
        strSql.Append("id,sortname)");
        strSql.Append(" values (");
        strSql.Append("@id,@sortname)");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@sortname", SqlDbType.VarChar,50)};
        parameters[0].Value = sinfo.id;
        parameters[1].Value = sinfo.sortname;

        SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, strSql.ToString(), parameters);        
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public void UpdateAdSort(AdSortInfo sinfo)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update ROYcms_Ad_Sort set ");
        strSql.Append("sortname=@sortname");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@sortname", SqlDbType.VarChar,50)};
        parameters[0].Value = sinfo.id;
        parameters[1].Value = sinfo.sortname;

        SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, strSql.ToString(), parameters);        
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void DeleteAdSort(int id)
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete ROYcms_Ad_Sort ");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = id;

        SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, strSql.ToString(), parameters);
        
    }

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataTable GetList(string strWhere)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,sortname ");
        strSql.Append(" FROM ROYcms_Ad_Sort ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        strSql.Append(" order by id");
        return SqlHelper.ExecuteDataSet(SqlHelper.Conn,strSql.ToString()).Tables[0];
        
    }
}
