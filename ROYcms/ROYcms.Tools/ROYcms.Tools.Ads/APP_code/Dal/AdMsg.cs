using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ROYcms.DB;
/// <summary>
///AdMsg 的摘要说明
/// </summary>
////

public class AdMsg
{
	public AdMsg()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 修改js路径问题
    /// </summary>
    /// <param name="id"></param>
    /// <param name="jsfile"></param>
    public void AdUpdateJs(int id, string jsfile)
    {
        string sql = "update ROYcms_Ad_Msg set adjs=@adjs where id=@id";
        SqlParameter[] parameters ={
                                       new SqlParameter("@adjs",SqlDbType.VarChar,200),
                                       new SqlParameter("@id",SqlDbType.Int,4)
                                  };
        parameters[0].Value = jsfile.ToString();
        parameters[1].Value = id;

        SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql,parameters);

    }

    /// <summary>
    /// 返回最大ID
    /// </summary>
    /// <returns></returns>
    public int AdMaxid()
    {
        string sql = "select top 1 id from ROYcms_Ad_Msg order by id desc";
        object obj = SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, sql);
        if (obj != null)
        {
            return int.Parse(obj.ToString());
        }
        return 1;
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="minfo"></param>
    public void UpdateAd(AdMsgInfo minfo)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update ROYcms_Ad_Msg set ");
        strSql.Append("sid=@sid,");
        strSql.Append("adname=@adname,");
        strSql.Append("adpic=@adpic,");
        strSql.Append("adurl=@adurl,");
        strSql.Append("adtype=@adtype,");
        strSql.Append("adstop=@adstop,");
        strSql.Append("adwidth=@adwidth,");
        strSql.Append("adheight=@adheight,");
        strSql.Append("adendtime=@adendtime,");
        strSql.Append("adjs=@adjs");
        strSql.Append(" where id=@id");
        SqlParameter[] parameters = {
					new SqlParameter("@sid", SqlDbType.Int,4),
					new SqlParameter("@adname", SqlDbType.VarChar,50),
					new SqlParameter("@adpic", SqlDbType.VarChar,300),
					new SqlParameter("@adurl", SqlDbType.VarChar,300),
					new SqlParameter("@adtype", SqlDbType.Int,4),
					new SqlParameter("@adstop", SqlDbType.Int,4),
					new SqlParameter("@adwidth", SqlDbType.Int,4),
					new SqlParameter("@adheight", SqlDbType.Int,4),					
					new SqlParameter("@adendtime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@adjs", SqlDbType.VarChar,200)};
        parameters[0].Value = minfo.sid;
        parameters[1].Value = minfo.adname;
        parameters[2].Value = minfo.adpic;
        parameters[3].Value = minfo.adurl;
        parameters[4].Value = minfo.adtype;
        parameters[5].Value = minfo.adstop;
        parameters[6].Value = minfo.adwidth;
        parameters[7].Value = minfo.adheight;
        parameters[8].Value = minfo.adendtime;
        parameters[9].Value = minfo.id;
        parameters[10].Value = minfo.adjs;

        SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, strSql.ToString(), parameters);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public int AddAd(AdMsgInfo minfo)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into ROYcms_Ad_Msg(");
        strSql.Append("sid,adname,adpic,adurl,adtype,adstop,adwidth,adheight,adendtime,adcount,adjs)");
        strSql.Append(" values (");
        strSql.Append("@sid,@adname,@adpic,@adurl,@adtype,@adstop,@adwidth,@adheight,@adendtime,@adcount,@adjs)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@sid", SqlDbType.Int,4),
					new SqlParameter("@adname", SqlDbType.VarChar,50),
					new SqlParameter("@adpic", SqlDbType.VarChar,300),
					new SqlParameter("@adurl", SqlDbType.VarChar,300),
					new SqlParameter("@adtype", SqlDbType.Int,4),
					new SqlParameter("@adstop", SqlDbType.Int,4),
					new SqlParameter("@adwidth", SqlDbType.Int,4),
					new SqlParameter("@adheight", SqlDbType.Int,4),					
					new SqlParameter("@adendtime", SqlDbType.DateTime),
					new SqlParameter("@adcount", SqlDbType.Int,4),
					new SqlParameter("@adjs", SqlDbType.VarChar,200)};
        parameters[0].Value = minfo.sid;
        parameters[1].Value = minfo.adname;
        parameters[2].Value = minfo.adpic;
        parameters[3].Value = minfo.adurl;
        parameters[4].Value = minfo.adtype;
        parameters[5].Value = minfo.adstop;
        parameters[6].Value = minfo.adwidth;
        parameters[7].Value = minfo.adheight;
        parameters[8].Value = minfo.adendtime;
        parameters[9].Value = minfo.adcount;
        parameters[10].Value = minfo.adjs;


        return SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, strSql.ToString(), parameters);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public AdMsgInfo GetModelAd(int id)
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append("select  top 1 id,sid,adname,adpic,adurl,adtype,adstop,adwidth,adheight,adcreattime,adendtime,adcount,adjs from ROYcms_Ad_Msg ");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = id;

        AdMsgInfo ainfo = new AdMsgInfo();

        using (SqlDataReader sdr = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, strSql.ToString(), parameters))
        {
            if (sdr.Read())
            {
                if (sdr["id"].ToString() != "")
                {
                    ainfo.id = int.Parse(sdr["id"].ToString());
                }
                if (sdr["sid"].ToString() != "")
                {
                    ainfo.sid = int.Parse(sdr["sid"].ToString());
                }
                ainfo.adname = sdr["adname"].ToString();
                ainfo.adpic = sdr["adpic"].ToString();
                ainfo.adurl = sdr["adurl"].ToString();
                if (sdr["adtype"].ToString() != "")
                {
                    ainfo.adtype = int.Parse(sdr["adtype"].ToString());
                }
                if (sdr["adstop"].ToString() != "")
                {
                    ainfo.adstop = int.Parse(sdr["adstop"].ToString());
                }
                if (sdr["adwidth"].ToString() != "")
                {
                    ainfo.adwidth = int.Parse(sdr["adwidth"].ToString());
                }
                if (sdr["adheight"].ToString() != "")
                {
                    ainfo.adheight = int.Parse(sdr["adheight"].ToString());
                }
                if (sdr["adcreattime"].ToString() != "")
                {
                    ainfo.adcreattime = DateTime.Parse(sdr["adcreattime"].ToString());
                }
                if (sdr["adendtime"].ToString() != "")
                {
                    ainfo.adendtime = DateTime.Parse(sdr["adendtime"].ToString());
                }
                if (sdr["adcount"].ToString() != "")
                {
                    ainfo.adcount = int.Parse(sdr["adcount"].ToString());
                }
                ainfo.adjs = sdr["adjs"].ToString();
            }
            else
            {
                ainfo = null;
            }
        }

        return ainfo;

    }


    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void DeleteAd(int id)
    {

        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete ROYcms_Ad_Msg ");
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
        strSql.Append("select id,sid,adname,adpic,adurl,adtype,adstop,adwidth,adheight,adcreattime,adendtime,adcount,adjs ");
        strSql.Append(" FROM ROYcms_Ad_Msg ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        strSql.Append(" order by adcreattime desc");

        return SqlHelper.ExecuteDataSet(SqlHelper.Conn, strSql.ToString()).Tables[0];        
    }
}
