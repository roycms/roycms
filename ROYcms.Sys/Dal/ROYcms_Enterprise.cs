using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Enterprise。
	/// </summary>
	public class ROYcms_Enterprise
	{
		public ROYcms_Enterprise()
		{}
		#region  成员方法


        /// <summary>
        /// 修改一条数据是否推荐  修改switchs 为2
        /// </summary>
        public void Tuijian_Enterprise(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ["+ PubConstant.date_prefix + "Enterprise] set ");
            strSql.Append("switchs=@switchs");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4)
                                        };
            parameters[0].Value = bh;
            parameters[1].Value = (object)2;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "Enterprise] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }

        /// <summary>
        /// 修改一条数据 打开 控制开关 修改switchs 为1
        /// </summary>
        public void on_Enterprise(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ["+ PubConstant.date_prefix + "Enterprise] set ");
            strSql.Append("switchs=@switchs");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4)
                                        };
            parameters[0].Value = bh;
            parameters[1].Value = (object)1;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Enterprise model)
		{
            //StringBuilder strSql=new StringBuilder();
            //strSql.Append("insert into "+ PubConstant.date_prefix + "Enterprise(");
            //strSql.Append("user_id,keyword,description,introduces,business_scope,intelligence_honor,contacts_us,enterprise_culture,marketing_network,other_1,other_2,other_3,other_4)");
            //strSql.Append(" values (");
            //strSql.Append("@user_id,@keyword,@description,@introduces,@business_scope,@intelligence_honor,@contacts_us,@enterprise_culture,@marketing_network,@other_1,@other_2,@other_3,@other_4)");
            //strSql.Append(";select @@IDENTITY");
            //SqlParameter[] parameters = {
            //        new SqlParameter("@user_id", SqlDbType.Int,4),
            //        new SqlParameter("@keyword", SqlDbType.NVarChar,100),
            //        new SqlParameter("@description", SqlDbType.NVarChar,800),
            //        new SqlParameter("@introduces", SqlDbType.Text),
            //        new SqlParameter("@business_scope", SqlDbType.Text),
            //        new SqlParameter("@intelligence_honor", SqlDbType.Text),
            //        new SqlParameter("@contacts_us", SqlDbType.Text),
            //        new SqlParameter("@enterprise_culture", SqlDbType.Text),
            //        new SqlParameter("@marketing_network", SqlDbType.Text),
            //        new SqlParameter("@other_1", SqlDbType.Text),
            //        new SqlParameter("@other_2", SqlDbType.Text),
            //        new SqlParameter("@other_3", SqlDbType.Text),
            //        new SqlParameter("@other_4", SqlDbType.Text)};
            //parameters[0].Value = model.user_id;
            //parameters[1].Value = model.keyword;
            //parameters[2].Value = model.description;
            //parameters[3].Value = model.introduces;
            //parameters[4].Value = model.business_scope;
            //parameters[5].Value = model.intelligence_honor;
            //parameters[6].Value = model.contacts_us;
            //parameters[7].Value = model.enterprise_culture;
            //parameters[8].Value = model.marketing_network;
            //parameters[9].Value = model.other_1;
            //parameters[10].Value = model.other_2;
            //parameters[11].Value = model.other_3;
            //parameters[12].Value = model.other_4;


            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "Enterprise(");
            strSql.Append("user_id,keyword,description,gs_name,gs_tel,gs_address,gs_web,gs_email,classname,huangye_classname,introduces,business_scope,intelligence_honor,contacts_us,enterprise_culture,marketing_network,other_1,other_2,other_3,other_4,time,switchs,template_id)");
            strSql.Append(" values (");
            strSql.Append("@user_id,@keyword,@description,@gs_name,@gs_tel,@gs_address,@gs_web,@gs_email,@classname,@huangye_classname,@introduces,@business_scope,@intelligence_honor,@contacts_us,@enterprise_culture,@marketing_network,@other_1,@other_2,@other_3,@other_4,@time,@switchs,@template_id)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@description", SqlDbType.NVarChar,800),
					new SqlParameter("@gs_name", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_tel", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_address", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_web", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_email", SqlDbType.NVarChar,50),
					new SqlParameter("@classname", SqlDbType.Int,4),
                    new SqlParameter("@huangye_classname", SqlDbType.Int,4),
					new SqlParameter("@introduces", SqlDbType.Text),
					new SqlParameter("@business_scope", SqlDbType.Text),
					new SqlParameter("@intelligence_honor", SqlDbType.Text),
					new SqlParameter("@contacts_us", SqlDbType.Text),
					new SqlParameter("@enterprise_culture", SqlDbType.Text),
					new SqlParameter("@marketing_network", SqlDbType.Text),
					new SqlParameter("@other_1", SqlDbType.Text),
					new SqlParameter("@other_2", SqlDbType.Text),
					new SqlParameter("@other_3", SqlDbType.Text),
					new SqlParameter("@other_4", SqlDbType.Text),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@switchs", SqlDbType.Int,4),
					new SqlParameter("@template_id", SqlDbType.Int,4)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.keyword;
            parameters[2].Value = model.description;
            parameters[3].Value = model.gs_name;
            parameters[4].Value = model.gs_tel;
            parameters[5].Value = model.gs_address;
            parameters[6].Value = model.gs_web;
            parameters[7].Value = model.gs_email;
            parameters[8].Value = model.classname;
            parameters[9].Value = model.huangye_classname;
            parameters[10].Value = model.introduces;
            parameters[11].Value = model.business_scope;
            parameters[12].Value = model.intelligence_honor;
            parameters[13].Value = model.contacts_us;
            parameters[14].Value = model.enterprise_culture;
            parameters[15].Value = model.marketing_network;
            parameters[16].Value = model.other_1;
            parameters[17].Value = model.other_2;
            parameters[18].Value = model.other_3;
            parameters[19].Value = model.other_4;
            parameters[20].Value = model.time;
            parameters[21].Value = model.switchs;
            parameters[22].Value = model.template_id;





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
        public void _Update(ROYcms.Sys.Model.ROYcms_Enterprise model)
		{
            //StringBuilder strSql=new StringBuilder();
            //strSql.Append("update "+ PubConstant.date_prefix + "Enterprise set ");
            ////strSql.Append("user_id=@user_id,");
            //strSql.Append("keyword=@keyword,");
            //strSql.Append("description=@description,");
            //strSql.Append("introduces=@introduces,");
            //strSql.Append("business_scope=@business_scope,");
            //strSql.Append("intelligence_honor=@intelligence_honor,");
            //strSql.Append("contacts_us=@contacts_us,");
            //strSql.Append("enterprise_culture=@enterprise_culture,");
            //strSql.Append("marketing_network=@marketing_network,");
            //strSql.Append("other_1=@other_1,");
            //strSql.Append("other_2=@other_2,");
            //strSql.Append("other_3=@other_3,");
            //strSql.Append("other_4=@other_4");
            //strSql.Append(" where user_id=@user_id ");
            //SqlParameter[] parameters = {
            //        //new SqlParameter("@bh", SqlDbType.Int,4),
            //        new SqlParameter("@user_id", SqlDbType.Int,4),
            //         new SqlParameter("@keyword", SqlDbType.NVarChar,100),
            //        new SqlParameter("@description", SqlDbType.NVarChar,800),
            //        new SqlParameter("@introduces", SqlDbType.Text),
            //        new SqlParameter("@business_scope", SqlDbType.Text),
            //        new SqlParameter("@intelligence_honor", SqlDbType.Text),
            //        new SqlParameter("@contacts_us", SqlDbType.Text),
            //        new SqlParameter("@enterprise_culture", SqlDbType.Text),
            //        new SqlParameter("@marketing_network", SqlDbType.Text),
            //        new SqlParameter("@other_1", SqlDbType.Text),
            //        new SqlParameter("@other_2", SqlDbType.Text),
            //        new SqlParameter("@other_3", SqlDbType.Text),
            //        new SqlParameter("@other_4", SqlDbType.Text)};
            ////parameters[0].Value = model.bh;
            //parameters[0].Value = model.user_id;
            //parameters[1].Value = model.keyword;
            //parameters[2].Value = model.description;
            //parameters[3].Value = model.introduces;
            //parameters[4].Value = model.business_scope;
            //parameters[5].Value = model.intelligence_honor;
            //parameters[6].Value = model.contacts_us;
            //parameters[7].Value = model.enterprise_culture;
            //parameters[8].Value = model.marketing_network;
            //parameters[9].Value = model.other_1;
            //parameters[10].Value = model.other_2;
            //parameters[11].Value = model.other_3;
            //parameters[12].Value = model.other_4;



            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Enterprise set ");
            //strSql.Append("user_id=@user_id,");
            strSql.Append("keyword=@keyword,");
            strSql.Append("description=@description,");
            strSql.Append("gs_name=@gs_name,");
            strSql.Append("gs_tel=@gs_tel,");
            strSql.Append("gs_address=@gs_address,");
            strSql.Append("gs_web=@gs_web,");
            strSql.Append("gs_email=@gs_email,");
            strSql.Append("classname=@classname,");
            strSql.Append("huangye_classname=@huangye_classname,");
            strSql.Append("introduces=@introduces,");
            strSql.Append("business_scope=@business_scope,");
            strSql.Append("intelligence_honor=@intelligence_honor,");
            strSql.Append("contacts_us=@contacts_us,");
            strSql.Append("enterprise_culture=@enterprise_culture,");
            strSql.Append("marketing_network=@marketing_network,");
            strSql.Append("other_1=@other_1,");
            strSql.Append("other_2=@other_2,");
            strSql.Append("other_3=@other_3,");
            strSql.Append("other_4=@other_4,");
            strSql.Append("time=@time,");
            strSql.Append("switchs=@switchs,");
            strSql.Append("template_id=@template_id");
            strSql.Append(" where user_id=@user_id ");
            SqlParameter[] parameters = {
                    //new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@description", SqlDbType.NVarChar,800),
					new SqlParameter("@gs_name", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_tel", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_address", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_web", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_email", SqlDbType.NVarChar,50),
					new SqlParameter("@classname", SqlDbType.Int,4),
                    new SqlParameter("@huangye_classname", SqlDbType.Int,4),
					new SqlParameter("@introduces", SqlDbType.Text),
					new SqlParameter("@business_scope", SqlDbType.Text),
					new SqlParameter("@intelligence_honor", SqlDbType.Text),
					new SqlParameter("@contacts_us", SqlDbType.Text),
					new SqlParameter("@enterprise_culture", SqlDbType.Text),
					new SqlParameter("@marketing_network", SqlDbType.Text),
					new SqlParameter("@other_1", SqlDbType.Text),
					new SqlParameter("@other_2", SqlDbType.Text),
					new SqlParameter("@other_3", SqlDbType.Text),
					new SqlParameter("@other_4", SqlDbType.Text),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@switchs", SqlDbType.Int,4),
					new SqlParameter("@template_id", SqlDbType.Int,4)};
            //parameters[0].Value = model.bh;
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.keyword;
            parameters[2].Value = model.description;
            parameters[3].Value = model.gs_name;
            parameters[4].Value = model.gs_tel;
            parameters[5].Value = model.gs_address;
            parameters[6].Value = model.gs_web;
            parameters[7].Value = model.gs_email;
            parameters[8].Value = model.classname;
            parameters[9].Value = model.huangye_classname;
            parameters[10].Value = model.introduces;
            parameters[11].Value = model.business_scope;
            parameters[12].Value = model.intelligence_honor;
            parameters[13].Value = model.contacts_us;
            parameters[14].Value = model.enterprise_culture;
            parameters[15].Value = model.marketing_network;
            parameters[16].Value = model.other_1;
            parameters[17].Value = model.other_2;
            parameters[18].Value = model.other_3;
            parameters[19].Value = model.other_4;
            parameters[20].Value = model.time;
            parameters[21].Value = model.switchs;
            parameters[22].Value = model.template_id;





            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_Enterprise model)
        {
            //StringBuilder strSql = new StringBuilder();
            //strSql.Append("update "+ PubConstant.date_prefix + "Enterprise set ");
            //strSql.Append("user_id=@user_id,");
            //strSql.Append("keyword=@keyword,");
            //strSql.Append("description=@description,");
            //strSql.Append("introduces=@introduces,");
            //strSql.Append("business_scope=@business_scope,");
            //strSql.Append("intelligence_honor=@intelligence_honor,");
            //strSql.Append("contacts_us=@contacts_us,");
            //strSql.Append("enterprise_culture=@enterprise_culture,");
            //strSql.Append("marketing_network=@marketing_network,");
            //strSql.Append("other_1=@other_1,");
            //strSql.Append("other_2=@other_2,");
            //strSql.Append("other_3=@other_3,");
            //strSql.Append("other_4=@other_4");
            //strSql.Append(" where bh=@bh ");
            //SqlParameter[] parameters = {
            //        new SqlParameter("@bh", SqlDbType.Int,4),
            //        new SqlParameter("@user_id", SqlDbType.Int,4),
            //         new SqlParameter("@keyword", SqlDbType.NVarChar,100),
            //        new SqlParameter("@description", SqlDbType.NVarChar,800),
            //        new SqlParameter("@introduces", SqlDbType.Text),
            //        new SqlParameter("@business_scope", SqlDbType.Text),
            //        new SqlParameter("@intelligence_honor", SqlDbType.Text),
            //        new SqlParameter("@contacts_us", SqlDbType.Text),
            //        new SqlParameter("@enterprise_culture", SqlDbType.Text),
            //        new SqlParameter("@marketing_network", SqlDbType.Text),
            //        new SqlParameter("@other_1", SqlDbType.Text),
            //        new SqlParameter("@other_2", SqlDbType.Text),
            //        new SqlParameter("@other_3", SqlDbType.Text),
            //        new SqlParameter("@other_4", SqlDbType.Text)};
            //parameters[0].Value = model.bh;
            //parameters[1].Value = model.user_id;
            //parameters[2].Value = model.keyword;
            //parameters[3].Value = model.description;
            //parameters[4].Value = model.introduces;
            //parameters[5].Value = model.business_scope;
            //parameters[6].Value = model.intelligence_honor;
            //parameters[7].Value = model.contacts_us;
            //parameters[8].Value = model.enterprise_culture;
            //parameters[9].Value = model.marketing_network;
            //parameters[10].Value = model.other_1;
            //parameters[11].Value = model.other_2;
            //parameters[12].Value = model.other_3;
            //parameters[13].Value = model.other_4;



            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Enterprise set ");
            strSql.Append("user_id=@user_id,");
            strSql.Append("keyword=@keyword,");
            strSql.Append("description=@description,");
            strSql.Append("gs_name=@gs_name,");
            strSql.Append("gs_tel=@gs_tel,");
            strSql.Append("gs_address=@gs_address,");
            strSql.Append("gs_web=@gs_web,");
            strSql.Append("gs_email=@gs_email,");
            strSql.Append("classname=@classname,");
            strSql.Append("huangye_classname=@huangye_classname,");
            strSql.Append("introduces=@introduces,");
            strSql.Append("business_scope=@business_scope,");
            strSql.Append("intelligence_honor=@intelligence_honor,");
            strSql.Append("contacts_us=@contacts_us,");
            strSql.Append("enterprise_culture=@enterprise_culture,");
            strSql.Append("marketing_network=@marketing_network,");
            strSql.Append("other_1=@other_1,");
            strSql.Append("other_2=@other_2,");
            strSql.Append("other_3=@other_3,");
            strSql.Append("other_4=@other_4,");
            strSql.Append("time=@time,");
            strSql.Append("switchs=@switchs,");
            strSql.Append("template_id=@template_id");
            strSql.Append(" where bh=@bh ");
            SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@description", SqlDbType.NVarChar,800),
					new SqlParameter("@gs_name", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_tel", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_address", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_web", SqlDbType.NVarChar,50),
					new SqlParameter("@gs_email", SqlDbType.NVarChar,50),
					new SqlParameter("@classname", SqlDbType.Int,4),
                    new SqlParameter("@huangye_classname", SqlDbType.Int,4),
					new SqlParameter("@introduces", SqlDbType.Text),
					new SqlParameter("@business_scope", SqlDbType.Text),
					new SqlParameter("@intelligence_honor", SqlDbType.Text),
					new SqlParameter("@contacts_us", SqlDbType.Text),
					new SqlParameter("@enterprise_culture", SqlDbType.Text),
					new SqlParameter("@marketing_network", SqlDbType.Text),
					new SqlParameter("@other_1", SqlDbType.Text),
					new SqlParameter("@other_2", SqlDbType.Text),
					new SqlParameter("@other_3", SqlDbType.Text),
					new SqlParameter("@other_4", SqlDbType.Text),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@switchs", SqlDbType.Int,4),
					new SqlParameter("@template_id", SqlDbType.Int,4)};
            parameters[0].Value = model.bh;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.keyword;
            parameters[3].Value = model.description;
            parameters[4].Value = model.gs_name;
            parameters[5].Value = model.gs_tel;
            parameters[6].Value = model.gs_address;
            parameters[7].Value = model.gs_web;
            parameters[8].Value = model.gs_email;
            parameters[9].Value = model.classname;
            parameters[10].Value = model.huangye_classname;
            parameters[11].Value = model.introduces;
            parameters[12].Value = model.business_scope;
            parameters[13].Value = model.intelligence_honor;
            parameters[14].Value = model.contacts_us;
            parameters[15].Value = model.enterprise_culture;
            parameters[16].Value = model.marketing_network;
            parameters[17].Value = model.other_1;
            parameters[18].Value = model.other_2;
            parameters[19].Value = model.other_3;
            parameters[20].Value = model.other_4;
            parameters[21].Value = model.time;
            parameters[22].Value = model.switchs;
            parameters[23].Value = model.template_id;




            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Enterprise ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public ROYcms.Sys.Model.ROYcms_Enterprise GetModel(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 * from " + PubConstant.date_prefix + "Enterprise ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

            ROYcms.Sys.Model.ROYcms_Enterprise model = new ROYcms.Sys.Model.ROYcms_Enterprise();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                if (ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                model.keyword = ds.Tables[0].Rows[0]["keyword"].ToString();
                model.description = ds.Tables[0].Rows[0]["description"].ToString();
                model.gs_name = ds.Tables[0].Rows[0]["gs_name"].ToString();
                model.gs_tel = ds.Tables[0].Rows[0]["gs_tel"].ToString();
                model.gs_address = ds.Tables[0].Rows[0]["gs_address"].ToString();
                model.gs_web = ds.Tables[0].Rows[0]["gs_web"].ToString();
                model.gs_email = ds.Tables[0].Rows[0]["gs_email"].ToString();
                if (ds.Tables[0].Rows[0]["classname"].ToString() != "")
                {
                    model.classname = int.Parse(ds.Tables[0].Rows[0]["classname"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huangye_classname"].ToString() != "")
                {
                    model.huangye_classname = int.Parse(ds.Tables[0].Rows[0]["huangye_classname"].ToString());
                }
                model.introduces = ds.Tables[0].Rows[0]["introduces"].ToString();
                model.business_scope = ds.Tables[0].Rows[0]["business_scope"].ToString();
                model.intelligence_honor = ds.Tables[0].Rows[0]["intelligence_honor"].ToString();
                model.contacts_us = ds.Tables[0].Rows[0]["contacts_us"].ToString();
                model.enterprise_culture = ds.Tables[0].Rows[0]["enterprise_culture"].ToString();
                model.marketing_network = ds.Tables[0].Rows[0]["marketing_network"].ToString();
                model.other_1 = ds.Tables[0].Rows[0]["other_1"].ToString();
                model.other_2 = ds.Tables[0].Rows[0]["other_2"].ToString();
                model.other_3 = ds.Tables[0].Rows[0]["other_3"].ToString();
                model.other_4 = ds.Tables[0].Rows[0]["other_4"].ToString();
                if (ds.Tables[0].Rows[0]["time"].ToString() != "")
                {
                    model.time = DateTime.Parse(ds.Tables[0].Rows[0]["time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["switchs"].ToString() != "")
                {
                    model.switchs = int.Parse(ds.Tables[0].Rows[0]["switchs"].ToString());
                }
                if (ds.Tables[0].Rows[0]["template_id"].ToString() != "")
                {
                    model.template_id = int.Parse(ds.Tables[0].Rows[0]["template_id"].ToString());
                }
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
        public ROYcms.Sys.Model.ROYcms_Enterprise _GetModel(int user_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from " + PubConstant.date_prefix + "Enterprise ");
            strSql.Append(" where user_id=@user_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Int,4)};
            parameters[0].Value = user_id;

            ROYcms.Sys.Model.ROYcms_Enterprise model = new ROYcms.Sys.Model.ROYcms_Enterprise();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                if (ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                model.keyword = ds.Tables[0].Rows[0]["keyword"].ToString();
                model.description = ds.Tables[0].Rows[0]["description"].ToString();
                model.gs_name = ds.Tables[0].Rows[0]["gs_name"].ToString();
                model.gs_tel = ds.Tables[0].Rows[0]["gs_tel"].ToString();
                model.gs_address = ds.Tables[0].Rows[0]["gs_address"].ToString();
                model.gs_web = ds.Tables[0].Rows[0]["gs_web"].ToString();
                model.gs_email = ds.Tables[0].Rows[0]["gs_email"].ToString();
                if (ds.Tables[0].Rows[0]["classname"].ToString() != "")
                {
                    model.classname = int.Parse(ds.Tables[0].Rows[0]["classname"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huangye_classname"].ToString() != "")
                {
                    model.huangye_classname = int.Parse(ds.Tables[0].Rows[0]["huangye_classname"].ToString());
                }
                model.introduces = ds.Tables[0].Rows[0]["introduces"].ToString();
                model.business_scope = ds.Tables[0].Rows[0]["business_scope"].ToString();
                model.intelligence_honor = ds.Tables[0].Rows[0]["intelligence_honor"].ToString();
                model.contacts_us = ds.Tables[0].Rows[0]["contacts_us"].ToString();
                model.enterprise_culture = ds.Tables[0].Rows[0]["enterprise_culture"].ToString();
                model.marketing_network = ds.Tables[0].Rows[0]["marketing_network"].ToString();
                model.other_1 = ds.Tables[0].Rows[0]["other_1"].ToString();
                model.other_2 = ds.Tables[0].Rows[0]["other_2"].ToString();
                model.other_3 = ds.Tables[0].Rows[0]["other_3"].ToString();
                model.other_4 = ds.Tables[0].Rows[0]["other_4"].ToString();
                if (ds.Tables[0].Rows[0]["time"].ToString() != "")
                {
                    model.time = DateTime.Parse(ds.Tables[0].Rows[0]["time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["switchs"].ToString() != "")
                {
                    model.switchs = int.Parse(ds.Tables[0].Rows[0]["switchs"].ToString());
                }
                if (ds.Tables[0].Rows[0]["template_id"].ToString() != "")
                {
                    model.template_id = int.Parse(ds.Tables[0].Rows[0]["template_id"].ToString());
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
			strSql.Append(" from " + PubConstant.date_prefix + "Enterprise ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
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
			strSql.Append(" from " + PubConstant.date_prefix + "Enterprise ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
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
			parameters[0].Value = PubConstant.date_prefix + "Enterprise";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  成员方法
	}
}

