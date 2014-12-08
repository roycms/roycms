using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
//using System.Web.UI.WebControls;//请先添加引用
namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类ROYcms_product
    /// </summary>
    public class ROYcms_product
    {
        public ROYcms_product()
        { }
        #region  成员方法
        /// <summary>
        /// 信息批量转移
        /// </summary>
        public void GoToClass(int go,int to)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + PubConstant.date_prefix + "product set ");
            strSql.Append("classname="+to);
            strSql.Append(" where classname=@go ");
            SqlParameter[] parameters = {
					new SqlParameter("@go", SqlDbType.Int,4)
                                        };
            parameters[0].Value = go;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 信息批量转移 根据BH
        /// </summary>
        public void ToClass(int to_class, int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + PubConstant.date_prefix + "product set ");
            strSql.Append("classname=" + to_class);
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)
                                        };
            parameters[0].Value = bh;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该记录 根据标题
        /// </summary>
        public bool Exists_title(string title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "product");
            strSql.Append(" where title=@title ");
            SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,100)};
            parameters[0].Value = title;

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from "+PubConstant.date_prefix+"product");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 获得数据列表 SQL语句地定义
        /// </summary>
        public DataSet GetList_(string strSql)
        {
            return ROYcms.DB.DbHelpers.GetDataSet(strSql);
        }
        /// <summary>
        /// 获取一条信息 条件 Tops the product.
        /// </summary>
        /// <returns></returns>
        public ROYcms.Sys.Model.ROYcms_product TopProduct(string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "product] ");
            if (where.Trim() != "")
            {
                strSql.Append(" where " + where);
            }

            ROYcms.Sys.Model.ROYcms_product model = new ROYcms.Sys.Model.ROYcms_product();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                model.pic = ds.Tables[0].Rows[0]["pic"].ToString();
                model.title = ds.Tables[0].Rows[0]["title"].ToString();
                model.keyword = ds.Tables[0].Rows[0]["keyword"].ToString();
                model.zhaiyao = ds.Tables[0].Rows[0]["zhaiyao"].ToString();
                if (ds.Tables[0].Rows[0]["classname"].ToString() != "")
                {
                    model.classname = int.Parse(ds.Tables[0].Rows[0]["classname"].ToString());
                }
                model.contents = ds.Tables[0].Rows[0]["contents"].ToString();
                model.jumpurl = ds.Tables[0].Rows[0]["jumpurl"].ToString();
                model.infor = ds.Tables[0].Rows[0]["infor"].ToString();
                model.author = ds.Tables[0].Rows[0]["author"].ToString();
                model.url = ds.Tables[0].Rows[0]["url"].ToString();
                if (ds.Tables[0].Rows[0]["ding"].ToString() != "")
                {
                    model.ding = int.Parse(ds.Tables[0].Rows[0]["ding"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dig"].ToString() != "")
                {
                    model.dig = int.Parse(ds.Tables[0].Rows[0]["dig"].ToString());
                }
                model.tag = ds.Tables[0].Rows[0]["tag"].ToString();
                if (ds.Tables[0].Rows[0]["hits"].ToString() != "")
                {
                    model.hits = int.Parse(ds.Tables[0].Rows[0]["hits"].ToString());
                }
                if (ds.Tables[0].Rows[0]["time"].ToString() != "")
                {
                    model.time = DateTime.Parse(ds.Tables[0].Rows[0]["time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["orders"].ToString() != "")
                {
                    model.orders = int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian"].ToString() != "")
                {
                    model.tuijian = int.Parse(ds.Tables[0].Rows[0]["tuijian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["switchs"].ToString() != "")
                {
                    model.switchs = int.Parse(ds.Tables[0].Rows[0]["switchs"].ToString());
                }
                if (ds.Tables[0].Rows[0]["link"].ToString() != "")
                {
                    model.link = ds.Tables[0].Rows[0]["link"].ToString();
                }
                if (ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    model.type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["GUID"].ToString() != "")
                {
                    model.GUID = ds.Tables[0].Rows[0]["GUID"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得文章标题
        /// </summary>
        public string GetTitle(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select title from " + PubConstant.date_prefix + "product");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString(), parameters));
        }
        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(int Id, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "product");
            strSql.Append(" where bh='" + Id + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 获得ClassKind
        /// </summary>
        public string GetClassKind(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select type from " + PubConstant.date_prefix + "product");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString(), parameters));
        }
        /// <summary>
        /// 获得文章分类
        /// </summary>
        public string GetClassName(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select classname from " + PubConstant.date_prefix + "product");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString(), parameters));
        }
        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM ["+PubConstant.date_prefix+"product] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }
        /// <summary>
        /// 修改一条数据是否置顶
        /// </summary>
        public void Ding_product(int bh, int ding)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+PubConstant.date_prefix+"product set ");
            strSql.Append("ding=@ding");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@ding", SqlDbType.Int,4)
                                        };
            parameters[0].Value = bh;
            parameters[1].Value = ding;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 浏览一次 增加一次浏览记录
        /// </summary>
        public void Hits_product(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + PubConstant.date_prefix + "product set ");
            strSql.Append("hits=hits+1");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)
                                        };
            parameters[0].Value = bh;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 修改一条数据是否推荐
        /// </summary>
        public void Tuijian_product(int bh, int tuijian)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ["+PubConstant.date_prefix+"product] set ");
            strSql.Append("tuijian=@tuijian");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@tuijian", SqlDbType.Int,4)
                                        };
            parameters[0].Value = bh;
            parameters[1].Value = tuijian;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 控制开关 打开 和关闭一条数据
        /// </summary>
        public void K_product(int bh, int switchs)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+PubConstant.date_prefix+"product set ");
            strSql.Append("switchs=@switchs");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4)
                                        };
            parameters[0].Value = bh;
            parameters[1].Value = switchs;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
       
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public int Add(ROYcms.Sys.Model.ROYcms_product model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+PubConstant.date_prefix+"product(");
            strSql.Append("pic,title,keyword,zhaiyao,classname,contents,jumpurl,infor,author,url,ding,dig,tag,hits,orders,tuijian,switchs,link,type,GUID)");
            strSql.Append(" values (");
            strSql.Append("@pic,@title,@keyword,@zhaiyao,@classname,@contents,@jumpurl,@infor,@author,@url,@ding,@dig,@tag,@hits,@orders,@tuijian,@switchs,@link,@type,@GUID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@pic", SqlDbType.VarChar,500),
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@keyword", SqlDbType.VarChar,100),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,1000),
					new SqlParameter("@classname", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.Text),
					new SqlParameter("@jumpurl", SqlDbType.VarChar,100),
					new SqlParameter("@infor", SqlDbType.VarChar,50),
					new SqlParameter("@author", SqlDbType.VarChar,50),
					new SqlParameter("@url", SqlDbType.VarChar,100),
					new SqlParameter("@ding", SqlDbType.Int,4),
					new SqlParameter("@dig", SqlDbType.Int,4),
					new SqlParameter("@tag", SqlDbType.VarChar,100),
					new SqlParameter("@hits", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@tuijian", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4),
                    new SqlParameter("@link", SqlDbType.VarChar,50),
                    new SqlParameter("@type", SqlDbType.VarChar,50),
                    new SqlParameter("@GUID", SqlDbType.VarChar,50)};
            parameters[0].Value = model.pic;
            parameters[1].Value = model.title;
            parameters[2].Value = model.keyword;
            parameters[3].Value = model.zhaiyao;
            parameters[4].Value = model.classname;
            parameters[5].Value = model.contents;
            parameters[6].Value = model.jumpurl;
            parameters[7].Value = model.infor;
            parameters[8].Value = model.author;
            parameters[9].Value = model.url;
            parameters[10].Value = model.ding;
            parameters[11].Value = model.dig;
            parameters[12].Value = model.tag;
            parameters[13].Value = model.hits;
            parameters[14].Value = model.orders;
            parameters[15].Value = model.tuijian;
            parameters[16].Value = model.switchs;
            parameters[17].Value = model.link;
            parameters[18].Value = model.type;
            parameters[19].Value = model.GUID;
            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_product model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+PubConstant.date_prefix+"product set ");
            strSql.Append("pic=@pic,");
            strSql.Append("title=@title,");
            strSql.Append("keyword=@keyword,");
            strSql.Append("zhaiyao=@zhaiyao,");
            strSql.Append("classname=@classname,");
            strSql.Append("contents=@contents,");
            strSql.Append("jumpurl=@jumpurl,");
            strSql.Append("infor=@infor,");
            strSql.Append("author=@author,");
            strSql.Append("url=@url,");
            strSql.Append("ding=@ding,");
            strSql.Append("dig=@dig,");
            strSql.Append("tag=@tag,");
            strSql.Append("hits=@hits,");
            strSql.Append("time=@time,");
            strSql.Append("orders=@orders,");
            strSql.Append("tuijian=@tuijian,");
            strSql.Append("switchs=@switchs,");
            strSql.Append("link=@link,");
            strSql.Append("type=@type,");
            strSql.Append("GUID=@GUID");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@pic", SqlDbType.VarChar,500),
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@keyword", SqlDbType.VarChar,100),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,1000),
					new SqlParameter("@classname", SqlDbType.Int,4),
					new SqlParameter("@contents", SqlDbType.Text),
					new SqlParameter("@jumpurl", SqlDbType.VarChar,100),
					new SqlParameter("@infor", SqlDbType.VarChar,50),
					new SqlParameter("@author", SqlDbType.VarChar,50),
					new SqlParameter("@url", SqlDbType.VarChar,100),
					new SqlParameter("@ding", SqlDbType.Int,4),
					new SqlParameter("@dig", SqlDbType.Int,4),
					new SqlParameter("@tag", SqlDbType.VarChar,100),
					new SqlParameter("@hits", SqlDbType.Int,4),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@tuijian", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4),
                    new SqlParameter("@link", SqlDbType.VarChar,50),
                    new SqlParameter("@type", SqlDbType.VarChar,50),
                    new SqlParameter("@GUID", SqlDbType.VarChar,50)};
            parameters[0].Value = model.bh;
            parameters[1].Value = model.pic;
            parameters[2].Value = model.title;
            parameters[3].Value = model.keyword;
            parameters[4].Value = model.zhaiyao;
            parameters[5].Value = model.classname;
            parameters[6].Value = model.contents;
            parameters[7].Value = model.jumpurl;
            parameters[8].Value = model.infor;
            parameters[9].Value = model.author;
            parameters[10].Value = model.url;
            parameters[11].Value = model.ding;
            parameters[12].Value = model.dig;
            parameters[13].Value = model.tag;
            parameters[14].Value = model.hits;
            parameters[15].Value = model.time;
            parameters[16].Value = model.orders;
            parameters[17].Value = model.tuijian;
            parameters[18].Value = model.switchs;
            parameters[19].Value = model.link;
            parameters[20].Value = model.type;
            parameters[21].Value = model.GUID;


            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete "+PubConstant.date_prefix+"product ");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete " + PubConstant.date_prefix + "product ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_product GetModel(int bh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from "+PubConstant.date_prefix+"product ");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            ROYcms.Sys.Model.ROYcms_product model = new ROYcms.Sys.Model.ROYcms_product();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                model.pic = ds.Tables[0].Rows[0]["pic"].ToString();
                model.title = ds.Tables[0].Rows[0]["title"].ToString();
                model.keyword = ds.Tables[0].Rows[0]["keyword"].ToString();
                model.zhaiyao = ds.Tables[0].Rows[0]["zhaiyao"].ToString();
                if (ds.Tables[0].Rows[0]["classname"].ToString() != "")
                {
                    model.classname = int.Parse(ds.Tables[0].Rows[0]["classname"].ToString());
                }
                model.contents = ds.Tables[0].Rows[0]["contents"].ToString();
                model.jumpurl = ds.Tables[0].Rows[0]["jumpurl"].ToString();
                model.infor = ds.Tables[0].Rows[0]["infor"].ToString();
                model.author = ds.Tables[0].Rows[0]["author"].ToString();
                model.url = ds.Tables[0].Rows[0]["url"].ToString();
                if (ds.Tables[0].Rows[0]["ding"].ToString() != "")
                {
                    model.ding = int.Parse(ds.Tables[0].Rows[0]["ding"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dig"].ToString() != "")
                {
                    model.dig = int.Parse(ds.Tables[0].Rows[0]["dig"].ToString());
                }
                model.tag = ds.Tables[0].Rows[0]["tag"].ToString();
                if (ds.Tables[0].Rows[0]["hits"].ToString() != "")
                {
                    model.hits = int.Parse(ds.Tables[0].Rows[0]["hits"].ToString());
                }
                if (ds.Tables[0].Rows[0]["time"].ToString() != "")
                {
                    model.time = DateTime.Parse(ds.Tables[0].Rows[0]["time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["orders"].ToString() != "")
                {
                    model.orders = int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian"].ToString() != "")
                {
                    model.tuijian = int.Parse(ds.Tables[0].Rows[0]["tuijian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["switchs"].ToString() != "")
                {
                    model.switchs = int.Parse(ds.Tables[0].Rows[0]["switchs"].ToString());
                }
                if (ds.Tables[0].Rows[0]["link"].ToString() != "")
                {
                    model.link = ds.Tables[0].Rows[0]["link"].ToString();
                }
                if (ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    model.type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["GUID"].ToString() != "")
                {
                    model.GUID = ds.Tables[0].Rows[0]["GUID"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM "+PubConstant.date_prefix+"product ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }

        /// <summary>
        /// 自定义SQL语句返回DataSet
        /// </summary>
        public DataSet _GetDataSet(string SQL)
        {
            return ROYcms.DB.DbHelpers.GetDataSet(SQL);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" from " + PubConstant.date_prefix + "product ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="PageSize">Size of the page.</param>
        /// <param name="PageIndex">Index of the page.</param>
        /// <param name="strWhere">The STR where.</param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, int OrderType)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = ""+PubConstant.date_prefix+"product";
            parameters[1].Value = "bh";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = OrderType;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="PageSize">Size of the page.</param>
        /// <param name="PageIndex">Index of the page.</param>
        /// <param name="strWhere">The STR where.</param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
         return  GetList(PageSize, PageIndex, strWhere, 0);
        }

        #endregion  成员方法
    }


}

