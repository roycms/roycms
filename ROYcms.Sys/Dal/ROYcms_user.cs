using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_user。
	/// </summary>
    public class ROYcms_user
	{
		public ROYcms_user()
		{}


        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(int Id, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "user");
            strSql.Append(" where bh='" + Id + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 获取 单个值  根据Email
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetUserName(string email)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select name from " + PubConstant.date_prefix + "user");
            strSql.Append(" where email='" + email + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 获取 单个值  单个字段 根据用户名
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(string name, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "user");
            strSql.Append(" where name='" + name + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        #region  成员方法
        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "user] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }
        /// <summary>
        /// 验证该用户
        /// </summary>
        public bool Exists(string username, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [" + PubConstant.date_prefix + "user]");
            strSql.Append(" where name=@username and password=@password ");
            SqlParameter[] parameters = {
                    new SqlParameter("@username", SqlDbType.NChar,50),
                    new SqlParameter("@password", SqlDbType.NChar,50)};
            parameters[0].Value = username;
            parameters[1].Value = password;
            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
        }
      
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "user");
            strSql.Append(" where name=@name ");
            SqlParameter[] parameters = {
                    new SqlParameter("@name", SqlDbType.VarChar,50)};
            parameters[0].Value = name;

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "user");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "user(");
            strSql.Append("RoleID,UgroupID,name,password,money,qq,email,age,login_time,sex,pic,quanxian,username,GUID,IP)");
            strSql.Append(" values (");
            strSql.Append("@RoleID,@UgroupID,@name,@password,@money,@qq,@email,@age,@login_time,@sex,@pic,@quanxian,@username,@GUID,@IP)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@UgroupID", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@password", SqlDbType.VarChar,50),
					new SqlParameter("@money", SqlDbType.Int,4),
					new SqlParameter("@qq", SqlDbType.VarChar,50),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@login_time", SqlDbType.DateTime),
					new SqlParameter("@sex", SqlDbType.VarChar,10),
					new SqlParameter("@pic", SqlDbType.VarChar,100),
					new SqlParameter("@quanxian", SqlDbType.VarChar,50),
					new SqlParameter("@username", SqlDbType.VarChar,50),
                    new SqlParameter("@GUID", SqlDbType.VarChar,50),
					new SqlParameter("@IP", SqlDbType.VarChar,50)};
            parameters[0].Value = model.RoleID;
            parameters[1].Value = model.UgroupID;
            parameters[2].Value = model.name;
            parameters[3].Value = model.password;
            parameters[4].Value = model.money;
            parameters[5].Value = model.qq;
            parameters[6].Value = model.email;
            parameters[7].Value = model.age;
            parameters[8].Value = model.login_time;
            parameters[9].Value = model.sex;
            parameters[10].Value = model.pic;
            parameters[11].Value = model.quanxian;
            parameters[12].Value = model.username;
            parameters[13].Value = model.GUID;
            parameters[14].Value = model.ip;

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
        public void Update(ROYcms.Sys.Model.ROYcms_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "user set ");
            strSql.Append("RoleID=@RoleID,");
            strSql.Append("UgroupID=@UgroupID,");
            strSql.Append("name=@name,");
            strSql.Append("password=@password,");
            strSql.Append("money=@money,");
            strSql.Append("qq=@qq,");
            strSql.Append("email=@email,");
            strSql.Append("age=@age,");
            strSql.Append("login_time=@login_time,");
            strSql.Append("sex=@sex,");
            strSql.Append("pic=@pic,");
            strSql.Append("quanxian=@quanxian,");
            strSql.Append("username=@username,");
            strSql.Append("GUID=@GUID,");
            strSql.Append("IP=@IP");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@UgroupID", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@password", SqlDbType.VarChar,50),
					new SqlParameter("@money", SqlDbType.Int,4),
					new SqlParameter("@qq", SqlDbType.VarChar,50),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@login_time", SqlDbType.DateTime),
					new SqlParameter("@sex", SqlDbType.VarChar,10),
					new SqlParameter("@pic", SqlDbType.VarChar,100),
					new SqlParameter("@quanxian", SqlDbType.VarChar,50),
					new SqlParameter("@username", SqlDbType.VarChar,50),
					 new SqlParameter("@GUID", SqlDbType.VarChar,50),
					new SqlParameter("@IP", SqlDbType.VarChar,50)};
            parameters[0].Value = model.bh;
            parameters[1].Value = model.RoleID;
            parameters[2].Value = model.UgroupID;
            parameters[3].Value = model.name;
            parameters[4].Value = model.password;
            parameters[5].Value = model.money;
            parameters[6].Value = model.qq;
            parameters[7].Value = model.email;
            parameters[8].Value = model.age;
            parameters[9].Value = model.login_time;
            parameters[10].Value = model.sex;
            parameters[11].Value = model.pic;
            parameters[12].Value = model.quanxian;
            parameters[13].Value = model.username;
            parameters[14].Value = (model.GUID == null ? GetModel(model.bh).GUID : model.GUID);
            parameters[15].Value = (model.ip == null ? GetModel(model.bh).ip : model.ip);


            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "user ");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        public void Delete(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete  ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "user] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }
        /// <summary>
        /// 更改用户为普通用户 无权限用户
        /// </summary>
        public void Update(string ugroup_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update  ");
            strSql.Append(" [" + PubConstant.date_prefix + "user] SET UgroupID = null where  UgroupID='" + ugroup_id + "' ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }
        /// <summary>
        /// 更改用户密码
        /// </summary>
        public void Update_password(int id,string password)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update  ");
            strSql.Append(" [" + PubConstant.date_prefix + "user] SET password = '" + password + "' where  bh='" +id + "' ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }
        /// <summary>
        /// 更改用户密码 根据用户名
        /// </summary>
        public void Update_password(string user, string password)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update  ");
            strSql.Append(" [" + PubConstant.date_prefix + "user] SET password = '" + password + "' where  name='" + user + "' ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }
        /// <summary>
        /// 更改用户积分
        /// </summary>
        public void Update_moneys(int id, int money)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ");
            strSql.Append("["+ PubConstant.date_prefix + "user] SET money='" + money + "' where bh=" + id);
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_user GetModel(int bh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 bh,RoleID,UgroupID,name,password,money,qq,email,age,login_time,sex,pic,quanxian,username,GUID,IP from " + PubConstant.date_prefix + "user ");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            ROYcms.Sys.Model.ROYcms_user model = new ROYcms.Sys.Model.ROYcms_user();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                model.RoleID = ds.Tables[0].Rows[0]["RoleID"].ToString();
                model.UgroupID = ds.Tables[0].Rows[0]["UgroupID"].ToString();
                model.name = ds.Tables[0].Rows[0]["name"].ToString();
                model.password = ds.Tables[0].Rows[0]["password"].ToString();
                if (ds.Tables[0].Rows[0]["money"].ToString() != "")
                {
                    model.money = int.Parse(ds.Tables[0].Rows[0]["money"].ToString());
                }
                model.qq = ds.Tables[0].Rows[0]["qq"].ToString();
                model.email = ds.Tables[0].Rows[0]["email"].ToString();
                if (ds.Tables[0].Rows[0]["age"].ToString() != "")
                {
                    model.age = int.Parse(ds.Tables[0].Rows[0]["age"].ToString());
                }
                if (ds.Tables[0].Rows[0]["login_time"].ToString() != "")
                {
                    model.login_time = DateTime.Parse(ds.Tables[0].Rows[0]["login_time"].ToString());
                }
                model.sex = ds.Tables[0].Rows[0]["sex"].ToString();
                model.pic = ds.Tables[0].Rows[0]["pic"].ToString();
                model.quanxian = ds.Tables[0].Rows[0]["quanxian"].ToString();
                model.username = ds.Tables[0].Rows[0]["username"].ToString();
                model.GUID = ds.Tables[0].Rows[0]["GUID"].ToString();
                model.ip = ds.Tables[0].Rows[0]["IP"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_user GetModel(string username)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 bh,RoleID,UgroupID,name,password,money,qq,email,age,login_time,sex,pic,quanxian,username,GUID,IP from " + PubConstant.date_prefix + "user ");
            strSql.Append(" where name=@username  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@username", SqlDbType.VarChar,255)};
            parameters[0].Value = username;

            ROYcms.Sys.Model.ROYcms_user model = new ROYcms.Sys.Model.ROYcms_user();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                model.RoleID = ds.Tables[0].Rows[0]["RoleID"].ToString();
                model.UgroupID = ds.Tables[0].Rows[0]["UgroupID"].ToString();
                model.name = ds.Tables[0].Rows[0]["name"].ToString();
                model.password = ds.Tables[0].Rows[0]["password"].ToString();
                if (ds.Tables[0].Rows[0]["money"].ToString() != "")
                {
                    model.money = int.Parse(ds.Tables[0].Rows[0]["money"].ToString());
                }
                model.qq = ds.Tables[0].Rows[0]["qq"].ToString();
                model.email = ds.Tables[0].Rows[0]["email"].ToString();
                if (ds.Tables[0].Rows[0]["age"].ToString() != "")
                {
                    model.age = int.Parse(ds.Tables[0].Rows[0]["age"].ToString());
                }
                if (ds.Tables[0].Rows[0]["login_time"].ToString() != "")
                {
                    model.login_time = DateTime.Parse(ds.Tables[0].Rows[0]["login_time"].ToString());
                }
                model.sex = ds.Tables[0].Rows[0]["sex"].ToString();
                model.pic = ds.Tables[0].Rows[0]["pic"].ToString();
                model.quanxian = ds.Tables[0].Rows[0]["quanxian"].ToString();
                model.username = ds.Tables[0].Rows[0]["username"].ToString();
                model.GUID = ds.Tables[0].Rows[0]["GUID"].ToString();
                model.ip = ds.Tables[0].Rows[0]["IP"].ToString();
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
            strSql.Append("select bh,RoleID,UgroupID,name,password,money,qq,email,age,login_time,sex,pic,quanxian,username,GUID,IP ");
            strSql.Append(" from " + PubConstant.date_prefix + "user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
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
            strSql.Append(" bh,RoleID,UgroupID,name,password,money,qq,email,age,login_time,sex,pic,quanxian,username,GUID,IP ");
            strSql.Append(" from " + PubConstant.date_prefix + "user ");
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
            parameters[0].Value = PubConstant.date_prefix + "user";
            parameters[1].Value = "bh";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = OrderType;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }

        #endregion  成员方法
        /// <summary>
        /// 
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return GetList(PageSize, PageIndex, strWhere,1);
        }
    }
}

