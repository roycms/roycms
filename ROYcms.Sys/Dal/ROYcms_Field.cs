using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类:ROYcms_Field
	/// </summary>
	public partial class ROYcms_Field
	{
		public ROYcms_Field()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Field");
			strSql.Append(" where Id="+Id+" ");
			return DbHelperSQL.Exists(strSql.ToString());
		}
        /// <summary>
        /// 初始化一模型必有的默认字段
        /// </summary>
        public int FieldInitialization(int Rid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "Field(Rid,Name,Lable,Len,FieldType,IsNull,IsKey,DefaultVal,Display,Expression,InputType,InputLen,OrderBy,TIME) ");
            strSql.Append(" values(" + Rid + ",'_RTitle','标题',100,0,0,0,'',1,'',1,420,0,'" + DateTime.Now + "'); ");

            strSql.Append("  insert into "+ PubConstant.date_prefix + "Field(Rid,Name,Lable,Len,FieldType,IsNull,IsKey,DefaultVal,Display,Expression,InputType,InputLen,OrderBy,TIME) ");
            strSql.Append(" values(" + Rid + ",'_RContent','内容',100,0,0,0,'',1,'',6,600,999,'" + DateTime.Now + "') ");

            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Field model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.Rid != null)
			{
				strSql1.Append("Rid,");
				strSql2.Append(""+model.Rid+",");
			}
			if (model.Name != null)
			{
				strSql1.Append("Name,");
				strSql2.Append("'"+model.Name+"',");
			}
			if (model.Lable != null)
			{
				strSql1.Append("Lable,");
				strSql2.Append("'"+model.Lable+"',");
			}
			if (model.Len != null)
			{
				strSql1.Append("Len,");
				strSql2.Append(""+model.Len+",");
			}
			if (model.FieldType != null)
			{
				strSql1.Append("FieldType,");
				strSql2.Append(""+model.FieldType+",");
			}
			if (model.IsNull != null)
			{
				strSql1.Append("IsNull,");
				strSql2.Append(""+model.IsNull+",");
			}
			if (model.IsKey != null)
			{
				strSql1.Append("IsKey,");
				strSql2.Append(""+model.IsKey+",");
			}
			if (model.DefaultVal != null)
			{
				strSql1.Append("DefaultVal,");
				strSql2.Append("'"+model.DefaultVal+"',");
			}
			if (model.Display != null)
			{
				strSql1.Append("Display,");
				strSql2.Append(""+model.Display+",");
			}
			if (model.Expression != null)
			{
				strSql1.Append("Expression,");
				strSql2.Append("'"+model.Expression+"',");
			}
			if (model.InputType != null)
			{
				strSql1.Append("InputType,");
				strSql2.Append("'"+model.InputType+"',");
			}
			if (model.InputLen != null)
			{
				strSql1.Append("InputLen,");
				strSql2.Append(""+model.InputLen+",");
			}
			if (model.OrderBy != null)
			{
				strSql1.Append("OrderBy,");
				strSql2.Append(""+model.OrderBy+",");
			}
			if (model.TIME != null)
			{
				strSql1.Append("TIME,");
				strSql2.Append("'"+model.TIME+"',");
			}
			strSql.Append("insert into "+ PubConstant.date_prefix + "Field(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			strSql.Append(";select @@IDENTITY");
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Field model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Field set ");
			if (model.Rid != null)
			{
				strSql.Append("Rid="+model.Rid+",");
			}
			else
			{
				strSql.Append("Rid= null ,");
			}
			if (model.Name != null)
			{
				strSql.Append("Name='"+model.Name+"',");
			}
			else
			{
				strSql.Append("Name= null ,");
			}
			if (model.Lable != null)
			{
				strSql.Append("Lable='"+model.Lable+"',");
			}
			else
			{
				strSql.Append("Lable= null ,");
			}
			if (model.Len != null)
			{
				strSql.Append("Len="+model.Len+",");
			}
			else
			{
				strSql.Append("Len= null ,");
			}
			if (model.FieldType != null)
			{
				strSql.Append("FieldType="+model.FieldType+",");
			}
			else
			{
				strSql.Append("FieldType= null ,");
			}
			if (model.IsNull != null)
			{
				strSql.Append("IsNull="+model.IsNull+",");
			}
			else
			{
				strSql.Append("IsNull= null ,");
			}
			if (model.IsKey != null)
			{
				strSql.Append("IsKey="+model.IsKey+",");
			}
			else
			{
				strSql.Append("IsKey= null ,");
			}
			if (model.DefaultVal != null)
			{
				strSql.Append("DefaultVal='"+model.DefaultVal+"',");
			}
			else
			{
				strSql.Append("DefaultVal= null ,");
			}
			if (model.Display != null)
			{
				strSql.Append("Display="+model.Display+",");
			}
			else
			{
				strSql.Append("Display= null ,");
			}
			if (model.Expression != null)
			{
				strSql.Append("Expression='"+model.Expression+"',");
			}
			else
			{
				strSql.Append("Expression= null ,");
			}
			if (model.InputType != null)
			{
				strSql.Append("InputType='"+model.InputType+"',");
			}
			else
			{
				strSql.Append("InputType= null ,");
			}
			if (model.InputLen != null)
			{
				strSql.Append("InputLen="+model.InputLen+",");
			}
			else
			{
				strSql.Append("InputLen= null ,");
			}
			if (model.OrderBy != null)
			{
				strSql.Append("OrderBy="+model.OrderBy+",");
			}
			else
			{
				strSql.Append("OrderBy= null ,");
			}
			if (model.TIME != null)
			{
				strSql.Append("TIME='"+model.TIME+"',");
			}
			else
			{
				strSql.Append("TIME= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where Id="+ model.Id+"");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
        /// <summary>
        /// 修改字段的排列顺序
        /// </summary>
        public bool UpdateOrderBy(int Id, int OrderBy)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Field set OrderBy=" + OrderBy.ToString());
            strSql.Append(" where Id=" + Id + "");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Field ");
			strSql.Append(" where Id="+Id+"" );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
        /// <summary>
        /// 删除一条数据 根据模型ID
        /// </summary>
        public bool MidDelete(int Mid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Field ");
            strSql.Append(" where Rid=" + Mid + "");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Field ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Field GetModel(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" Id,Rid,Name,Lable,Len,FieldType,IsNull,IsKey,DefaultVal,Display,Expression,InputType,InputLen,OrderBy,TIME ");
			strSql.Append(" from " + PubConstant.date_prefix + "Field ");
			strSql.Append(" where Id="+Id+"" );
			ROYcms.Sys.Model.ROYcms_Field model=new ROYcms.Sys.Model.ROYcms_Field();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Rid"]!=null && ds.Tables[0].Rows[0]["Rid"].ToString()!="")
				{
					model.Rid=int.Parse(ds.Tables[0].Rows[0]["Rid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null && ds.Tables[0].Rows[0]["Name"].ToString()!="")
				{
					model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Lable"]!=null && ds.Tables[0].Rows[0]["Lable"].ToString()!="")
				{
					model.Lable=ds.Tables[0].Rows[0]["Lable"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Len"]!=null && ds.Tables[0].Rows[0]["Len"].ToString()!="")
				{
					model.Len=int.Parse(ds.Tables[0].Rows[0]["Len"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FieldType"]!=null && ds.Tables[0].Rows[0]["FieldType"].ToString()!="")
				{
					model.FieldType=int.Parse(ds.Tables[0].Rows[0]["FieldType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsNull"]!=null && ds.Tables[0].Rows[0]["IsNull"].ToString()!="")
				{
					model.IsNull=int.Parse(ds.Tables[0].Rows[0]["IsNull"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsKey"]!=null && ds.Tables[0].Rows[0]["IsKey"].ToString()!="")
				{
					model.IsKey=int.Parse(ds.Tables[0].Rows[0]["IsKey"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DefaultVal"]!=null && ds.Tables[0].Rows[0]["DefaultVal"].ToString()!="")
				{
					model.DefaultVal=ds.Tables[0].Rows[0]["DefaultVal"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Display"]!=null && ds.Tables[0].Rows[0]["Display"].ToString()!="")
				{
					model.Display=int.Parse(ds.Tables[0].Rows[0]["Display"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Expression"]!=null && ds.Tables[0].Rows[0]["Expression"].ToString()!="")
				{
					model.Expression=ds.Tables[0].Rows[0]["Expression"].ToString();
				}
				if(ds.Tables[0].Rows[0]["InputType"]!=null && ds.Tables[0].Rows[0]["InputType"].ToString()!="")
				{
					model.InputType=ds.Tables[0].Rows[0]["InputType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["InputLen"]!=null && ds.Tables[0].Rows[0]["InputLen"].ToString()!="")
				{
					model.InputLen=int.Parse(ds.Tables[0].Rows[0]["InputLen"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OrderBy"]!=null && ds.Tables[0].Rows[0]["OrderBy"].ToString()!="")
				{
					model.OrderBy=int.Parse(ds.Tables[0].Rows[0]["OrderBy"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TIME"]!=null && ds.Tables[0].Rows[0]["TIME"].ToString()!="")
				{
					model.TIME=DateTime.Parse(ds.Tables[0].Rows[0]["TIME"].ToString());
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" from " + PubConstant.date_prefix + "Field ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" from " + PubConstant.date_prefix + "Field ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Field ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from " + PubConstant.date_prefix + "Field T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
	}
}

