using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
    /// 数据访问类ROYcms_Custom
	/// </summary>
	public class ROYcms_Custom
	{
        ROYcms.Sys.Model.ROYcms_Custom model = new ROYcms.Sys.Model.ROYcms_Custom();
        /// <summary>
        /// 成员方法
        /// </summary>
        public ROYcms_Custom()
		{}
		#region  成员方法

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="Id"></param>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public ROYcms.Sys.Model.ROYcms_Custom SetVal(System.Web.UI.Page page,int Id,int Cid) 
        {
            //循环得到表单所有数据 
            model.Tlist = null;
            model.InsertList = null;
            model.UpdateList = null;
            model.newid = Id;
            model.Cid = Cid;

            for (int i = 0; i < page.Request.Form.Count; i++)
            {
                if (page.Request.Form.GetKey(i).Contains("ROYcms_") && !page.Request.Form.GetKey(i).Contains("ROYcms__R"))
                {
                    model.Tlist += page.Request.Form.GetKey(i).Replace("ROYcms_", "") + ","; //列的集合
                    model.InsertList += "'" + page.Request.Form.Get(i) + "',";//Insert值的集合
                    model.UpdateList += page.Request.Form.GetKey(i).Replace("ROYcms_", "") + "='" + page.Request.Form.Get(i) + "',";//Upadate键值对集合
                }
            }
            //增加默认字段赋值
            if (model.UpdateList != null)
            {
                model.UpdateList = model.UpdateList + "Id='" + model.newid + "',Cid='" + model.Cid + "'";
            }
            if (model.InsertList != null)
            {
                model.InsertList = model.InsertList + "'" + model.newid + "','" + model.Cid + "'";
            }
            if (model.Tlist != null)
            {
                model.Tlist = model.Tlist + "Id,Cid";
             
            }
            return model;
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id,string TableName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + TableName);
            strSql.Append(" where Id="+Id);

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString());
        }
        /// <summary>
        /// 创建数据表格
        /// </summary>
        /// <param name="TableName">表格名称</param>
        /// <param name="Tablelist">列序列 例子：Id INTEGER,a1 VARCHAR(4000),a2 VARCHAR(4000)</param>
        /// <returns></returns>
        public int CreateTable(string TableName, string Tablelist)
        {
            //判断数据库表是否存在语句 select * from master.dbo.sysdatabases where name='表名'

            model.TableName = TableName;
            string CreateTableSql = "create table " + TableName + " (" + Tablelist + ");";
            return DbHelperSQL.ExecuteSql(CreateTableSql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int CreateTable(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            //判断数据库表是否存在语句 select * from master.dbo.sysdatabases where name='表名'
            string CreateTableSql = "create table " + models.TableName + " (" + models.Tablelist + ");";
            return DbHelperSQL.ExecuteSql(CreateTableSql);
        }
        /// <summary>
        /// 创建主键约束
        /// </summary>
        /// <param name="TableName">表格名字</param>
        /// <param name="Key">字段</param>
        /// <returns>返回受影响的行</returns>
        public int Key(string TableName,string Key)
        {
            string CreateTableSql = " alter  table " + TableName + " add constraint PK_" + TableName + "_Id primary key ("+Key+")";
            return DbHelperSQL.ExecuteSql(CreateTableSql);
        }
	    /// <summary>
        ///  增加一条数据
	    /// </summary>
        /// <param name="TableName"> 表名称 </param>
        /// <param name="Tlist">字段顺序 例如：a1,a2</param>
        /// <param name="InsertList">值顺序 例如：var1,var2</param>
	    /// <returns></returns>
        public int Add(string TableName, string Tlist, string InsertList)
		{
            string InsertSql = "insert into " + TableName + " (" + Tlist + ") values (" + InsertList + ")";
            return DbHelperSQL.ExecuteSql(InsertSql);
		}
        /// <summary>
        ///  插入一条数据根据表单结构
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Add(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            string InsertSql = "insert into " + models.TableName + " (" + models.Tlist + ") values (" + models.InsertList + ")";
            return DbHelperSQL.ExecuteSql(InsertSql);
        }
        /// <summary>
        /// 返回一个字段
        /// </summary>
        /// <param name="Id">文章ID</param>
        /// <param name="Cid">分类ID</param>
        /// <param name="Name">字段名字</param>
        /// <returns></returns>
        public string GetVal(int Id,int Cid,string Name)
        {
            string Val = null;
              
                string TableName = GetTableName(Cid);  //得到表名
                if (TableName != null) 
                {
                    string Sql = "select " + Name + " from " + TableName + " where Id=" + Id;
                    object obj = ROYcms.DB.DbHelpers.GetSingle(Sql);
                    if (obj != null) { Val = Convert.ToString(obj); }
                }
                return Val;
            
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回字段数组
        /// </summary>
        /// <param name="Cid"></param>
        /// <param name="Field"></param>
        /// <returns></returns>
        public string[] GetTableList(int Cid,string Field) {
            string[] TableLists = null;
            string TableList = null;
            string Mid = new ROYcms.Sys.BLL.ROYcms_Class_Model().CidGetP("Mid", "Cid=" + Cid);
            if (Mid != null)
            {
                DataSet FieldDs = new ROYcms.Sys.BLL.ROYcms_Field().GetList("Rid=" + Mid);
                if (FieldDs.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow Dr in FieldDs.Tables[0].Rows)
                    {
                        string Name = Dr["Name"].ToString();//字段名字
                        string NameC = Dr[Field].ToString();//字段名字
                        if (!Name.Contains("_R"))//去除默认的字段进行表的创建
                        {
                            TableList += NameC + ",";
                        }
                    }
                }
            }
            if (TableList != null)
            {
                TableList = TableList.Substring(0, TableList.Length - 1);
                TableLists = TableList.Split(',');//列表数组
            }
            return TableLists;
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回智能关联表的表名
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string GetTableName(int Cid)
        {
            //得到表名
            string TableName = null;
            string Mid = new ROYcms.Sys.BLL.ROYcms_Class_Model().CidGetP("Mid", "Cid=" + Cid);//得到模型ID
            if (new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Mid)) != null)
            {
                TableName = new ROYcms.Sys.BLL.ROYcms_Model().GetModel(Convert.ToInt32(Mid)).TableName;
            }
            return TableName;
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
        /// <param name="id">更新条件，关联的文章ID </param>
        /// <param name="UpdateList">更新格式如下 a1=11,a2=22,a3=33 </param>
        /// <param name="TableName"> 表名称 </param>
        public int Update(int id, string UpdateList, string TableName)
		{
            string UpdateSql = "update " + TableName + " set " + UpdateList + " where Id =" + id;
            return DbHelperSQL.ExecuteSql(UpdateSql);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Update(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            string UpdateSql = "update " + models.TableName + " set " + models.UpdateList + " where Id =" + models.newid;
            return DbHelperSQL.ExecuteSql(UpdateSql);
        }

		#endregion  成员方法
	}
}

