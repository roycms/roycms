using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ROYcms.Sys.Model;
using System.Data.SqlClient;
namespace ROYcms.Sys.DAL
{
  public  class ROYcms_class
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
      public bool Exists(string FilePath, string DefaultFile)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  " + PubConstant.date_prefix + "Class");
            strSql.Append(" where FilePath='" + FilePath + "' and DefaultFile='" + DefaultFile + "'");

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString());
        }
        /// <summary>
        /// 获取ClassId的包含菜单列表
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public DataSet GetClassListByClassId(string ClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ClassList,ClassTj from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where ClassID=" + ClassId + " ");
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }
        /// <summary>
        /// 获取ClassTitle
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassTitle(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ClassName from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where Id='" + Id + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 获取GetIdForClassId
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public int GetIdForClassId(string ClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where ClassId='" + ClassId + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassField(int Id, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where Id='" + Id + "' ");
            //GetDataSet(strSql.ToString());
            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString());
            return obj != null ? Convert.ToString(obj) : null;

        }
        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassField(string where, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where " + where + " ");
            //GetDataSet(strSql.ToString());
            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString());
            return obj != null ? Convert.ToString(obj) : null;

        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassSql(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where " + strWhere + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
      
        /// <summary>
        /// 根据路径获取 ID
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetId(string Path)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where FilePath='" + Path + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 获取ClassId
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassId(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ClassId from "+PubConstant.date_prefix+"Class");
            strSql.Append(" where Id='" + Id + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 添加一个菜单项
        /// </summary>
        /// <param name="ClassId"></param>
        /// <param name="ClassName"></param>
        /// <param name="ClassList"></param>
        /// <param name="ClassPre"></param>
        /// <param name="ClassTj"></param>
        /// <returns></returns>
        public bool ClassAdd(ROYcms.Sys.Model.ROYcms_class model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "class(");
            strSql.Append("ClassId,ClassName,ClassList,ClassPre,ClassTj,ClassOrder,ClassKind,ContentType,FilePath,ListType,GoType,DefaultFile,ColumnsType,WebsiteUrl,TemplateIndex,TemplateList,TemplateShow,ListeRules,ShowRules,keyword,Description,contents)");
            strSql.Append(" values (");
            strSql.Append("@ClassId,@ClassName,@ClassList,@ClassPre,@ClassTj,@ClassOrder,@ClassKind,@ContentType,@FilePath,@ListType,@GoType,@DefaultFile,@ColumnsType,@WebsiteUrl,@TemplateIndex,@TemplateList,@TemplateShow,@ListeRules,@ShowRules,@keyword,@Description,@contents)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ClassId", SqlDbType.NVarChar,30),
					new SqlParameter("@ClassName", SqlDbType.NVarChar,50),
					new SqlParameter("@ClassList", SqlDbType.NVarChar,300),
					new SqlParameter("@ClassPre", SqlDbType.NVarChar,50),
					new SqlParameter("@ClassTj", SqlDbType.Int,4),
					new SqlParameter("@ClassOrder", SqlDbType.Int,4),
					new SqlParameter("@ClassKind", SqlDbType.Int,4),
					new SqlParameter("@ContentType", SqlDbType.Int,4),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@ListType", SqlDbType.Int,4),
					new SqlParameter("@GoType", SqlDbType.Int,4),
					new SqlParameter("@DefaultFile", SqlDbType.NVarChar,50),
					new SqlParameter("@ColumnsType", SqlDbType.NVarChar,50),
					new SqlParameter("@WebsiteUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateIndex", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateList", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateShow", SqlDbType.NVarChar,50),
					new SqlParameter("@ListeRules", SqlDbType.NVarChar,50),
					new SqlParameter("@ShowRules", SqlDbType.NVarChar,50),
					new SqlParameter("@keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@Description", SqlDbType.NVarChar,100),
					new SqlParameter("@contents", SqlDbType.Text)};
            parameters[0].Value = model.ClassId;
            parameters[1].Value = model.ClassName;
            parameters[2].Value = model.ClassList;
            parameters[3].Value = model.ClassPre;
            parameters[4].Value = model.ClassTj;
            parameters[5].Value = model.ClassOrder;
            parameters[6].Value = model.ClassKind;
            parameters[7].Value = model.ContentType;
            parameters[8].Value = model.FilePath;
            parameters[9].Value = model.ListType;
            parameters[10].Value = model.GoType;
            parameters[11].Value = model.DefaultFile;
            parameters[12].Value = model.ColumnsType;
            parameters[13].Value = model.WebsiteUrl;
            parameters[14].Value = model.TemplateIndex;
            parameters[15].Value = model.TemplateList;
            parameters[16].Value = model.TemplateShow;
            parameters[17].Value = model.ListeRules;
            parameters[18].Value = model.ShowRules;
            parameters[19].Value = model.keyword;
            parameters[20].Value = model.Description;
            parameters[21].Value = model.contents;

            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// 编辑一个菜单项
        /// </summary>
        /// <param name="ClassId"></param>
        /// <param name="ClassName"></param>
        /// <param name="ClassList"></param>
        /// <param name="ClassPre"></param>
        /// <param name="ClassTj"></param>
        /// <returns></returns>
        public bool ClassUpdate(ROYcms.Sys.Model.ROYcms_class model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "class set ");
            strSql.Append("ClassId=@ClassId,");
            strSql.Append("ClassName=@ClassName,");
            strSql.Append("ClassList=@ClassList,");
            strSql.Append("ClassPre=@ClassPre,");
            strSql.Append("ClassTj=@ClassTj,");
            strSql.Append("ClassOrder=@ClassOrder,");
            strSql.Append("ContentType=@ContentType,");
            strSql.Append("FilePath=@FilePath,");
            strSql.Append("ListType=@ListType,");
            strSql.Append("GoType=@GoType,");
            strSql.Append("DefaultFile=@DefaultFile,");
            strSql.Append("ColumnsType=@ColumnsType,");
            strSql.Append("WebsiteUrl=@WebsiteUrl,");
            strSql.Append("TemplateIndex=@TemplateIndex,");
            strSql.Append("TemplateList=@TemplateList,");
            strSql.Append("TemplateShow=@TemplateShow,");
            strSql.Append("ListeRules=@ListeRules,");
            strSql.Append("ShowRules=@ShowRules,");
            strSql.Append("keyword=@keyword,");
            strSql.Append("Description=@Description,");
            strSql.Append("contents=@contents");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@ClassId", SqlDbType.NVarChar,30),
					new SqlParameter("@ClassName", SqlDbType.NVarChar,50),
					new SqlParameter("@ClassList", SqlDbType.NVarChar,300),
					new SqlParameter("@ClassPre", SqlDbType.NVarChar,50),
					new SqlParameter("@ClassTj", SqlDbType.Int,4),
					new SqlParameter("@ClassOrder", SqlDbType.Int,4),
					new SqlParameter("@ClassKind", SqlDbType.Int,4),
					new SqlParameter("@ContentType", SqlDbType.Int,4),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@ListType", SqlDbType.Int,4),
					new SqlParameter("@GoType", SqlDbType.Int,4),
					new SqlParameter("@DefaultFile", SqlDbType.NVarChar,50),
					new SqlParameter("@ColumnsType", SqlDbType.NVarChar,50),
					new SqlParameter("@WebsiteUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateIndex", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateList", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateShow", SqlDbType.NVarChar,50),
					new SqlParameter("@ListeRules", SqlDbType.NVarChar,50),
					new SqlParameter("@ShowRules", SqlDbType.NVarChar,50),
					new SqlParameter("@keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@Description", SqlDbType.NVarChar,100),
					new SqlParameter("@contents", SqlDbType.Text)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.ClassId;
            parameters[2].Value = model.ClassName;
            parameters[3].Value = model.ClassList;
            parameters[4].Value = model.ClassPre;
            parameters[5].Value = model.ClassTj;
            parameters[6].Value = model.ClassOrder;
            parameters[7].Value = model.ClassKind;
            parameters[8].Value = model.ContentType;
            parameters[9].Value = model.FilePath;
            parameters[10].Value = model.ListType;
            parameters[11].Value = model.GoType;
            parameters[12].Value = model.DefaultFile;
            parameters[13].Value = model.ColumnsType;
            parameters[14].Value = model.WebsiteUrl;
            parameters[15].Value = model.TemplateIndex;
            parameters[16].Value = model.TemplateList;
            parameters[17].Value = model.TemplateShow;
            parameters[18].Value = model.ListeRules;
            parameters[19].Value = model.ShowRules;
            parameters[20].Value = model.keyword;
            parameters[21].Value = model.Description;
            parameters[22].Value = model.contents;

            //同步更新子菜单项
            DataSet ds = this.GetSubClassList(model.ClassId);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string SubClassList = model.ClassList + dr["ClassId"].ToString().Trim() + ",";

                    model.ClassId = dr["ClassId"].ToString().Trim();
                    model.ClassName = dr["ClassName"].ToString().Trim();
                    model.ClassList = SubClassList.ToString().Trim();
                    model.ClassPre = model.ClassId;
                    model.ClassTj = model.ClassTj + 1;
                    model.ClassOrder = Convert.ToInt32(dr["ClassOrder"].ToString());
                    model.ClassKind = Convert.ToInt32(dr["ClassKind"].ToString());
                    model.ContentType = Convert.ToInt32(dr["ContentType"].ToString());
                    model.FilePath = dr["FilePath"].ToString();
                    model.ListType = Convert.ToInt32(dr["ListType"].ToString());
                    model.GoType = Convert.ToInt32(dr["GoType"].ToString());
                    model.DefaultFile = dr["DefaultFile"].ToString();
                    model.ColumnsType = Convert.ToInt32(dr["ColumnsType"].ToString());
                    model.WebsiteUrl = dr["WebsiteUrl"].ToString();
                    model.TemplateIndex = dr["TemplateIndex"].ToString();
                    model.TemplateList = dr["TemplateList"].ToString();
                    model.TemplateShow = dr["TemplateShow"].ToString();
                    model.ListeRules = dr["ListeRules"].ToString();
                    model.ShowRules = dr["ShowRules"].ToString();
                    model.keyword = dr["keyword"].ToString();
                    model.Description = dr["Description"].ToString();
                    model.contents = dr["contents"].ToString();

                    ClassUpdate(model);
                }
            }

            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_class GetModel(string ClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Id,ClassId,ClassName,ClassList,ClassPre,ClassTj,ClassOrder,ClassKind,ContentType,FilePath,ListType,GoType,DefaultFile,ColumnsType,WebsiteUrl,TemplateIndex,TemplateList,TemplateShow,ListeRules,ShowRules,keyword,Description,contents ");
            strSql.Append(" from " + PubConstant.date_prefix + "class ");
            strSql.Append(" where ClassId=" + ClassId + " ");
            ROYcms.Sys.Model.ROYcms_class model = new ROYcms.Sys.Model.ROYcms_class();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                model.ClassId = ds.Tables[0].Rows[0]["ClassId"].ToString();
                model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                model.ClassList = ds.Tables[0].Rows[0]["ClassList"].ToString();
                model.ClassPre = ds.Tables[0].Rows[0]["ClassPre"].ToString();
                if (ds.Tables[0].Rows[0]["ClassTj"].ToString() != "")
                {
                    model.ClassTj = int.Parse(ds.Tables[0].Rows[0]["ClassTj"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassOrder"].ToString() != "")
                {
                    model.ClassOrder = int.Parse(ds.Tables[0].Rows[0]["ClassOrder"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassKind"].ToString() != "")
                {
                    model.ClassKind = int.Parse(ds.Tables[0].Rows[0]["ClassKind"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ContentType"].ToString() != "")
                {
                    model.ContentType = int.Parse(ds.Tables[0].Rows[0]["ContentType"].ToString());
                }
                model.FilePath = ds.Tables[0].Rows[0]["FilePath"].ToString();
                if (ds.Tables[0].Rows[0]["ListType"].ToString() != "")
                {
                    model.ListType = int.Parse(ds.Tables[0].Rows[0]["ListType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GoType"].ToString() != "")
                {
                    model.GoType = int.Parse(ds.Tables[0].Rows[0]["GoType"].ToString());
                }
                model.DefaultFile = ds.Tables[0].Rows[0]["DefaultFile"].ToString();
                model.ColumnsType = int.Parse(ds.Tables[0].Rows[0]["ColumnsType"].ToString());
                model.WebsiteUrl = ds.Tables[0].Rows[0]["WebsiteUrl"].ToString();
                model.TemplateIndex = ds.Tables[0].Rows[0]["TemplateIndex"].ToString();
                model.TemplateList = ds.Tables[0].Rows[0]["TemplateList"].ToString();
                model.TemplateShow = ds.Tables[0].Rows[0]["TemplateShow"].ToString();
                model.ListeRules = ds.Tables[0].Rows[0]["ListeRules"].ToString();
                model.ShowRules = ds.Tables[0].Rows[0]["ShowRules"].ToString();
                model.keyword = ds.Tables[0].Rows[0]["keyword"].ToString();
                model.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                model.contents = ds.Tables[0].Rows[0]["contents"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体  根据ID
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_class _GetModel(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Id,ClassId,ClassName,ClassList,ClassPre,ClassTj,ClassOrder,ClassKind,ContentType,FilePath,ListType,GoType,DefaultFile,ColumnsType,WebsiteUrl,TemplateIndex,TemplateList,TemplateShow,ListeRules,ShowRules,keyword,Description,contents ");
            strSql.Append(" from " + PubConstant.date_prefix + "class ");
            strSql.Append(" where Id="+ Id + " ");
            ROYcms.Sys.Model.ROYcms_class model = new ROYcms.Sys.Model.ROYcms_class();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                model.ClassId = ds.Tables[0].Rows[0]["ClassId"].ToString();
                model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                model.ClassList = ds.Tables[0].Rows[0]["ClassList"].ToString();
                model.ClassPre = ds.Tables[0].Rows[0]["ClassPre"].ToString();
                if (ds.Tables[0].Rows[0]["ClassTj"].ToString() != "")
                {
                    model.ClassTj = int.Parse(ds.Tables[0].Rows[0]["ClassTj"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassOrder"].ToString() != "")
                {
                    model.ClassOrder = int.Parse(ds.Tables[0].Rows[0]["ClassOrder"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassKind"].ToString() != "")
                {
                    model.ClassKind = int.Parse(ds.Tables[0].Rows[0]["ClassKind"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ContentType"].ToString() != "")
                {
                    model.ContentType = int.Parse(ds.Tables[0].Rows[0]["ContentType"].ToString());
                }
                model.FilePath = ds.Tables[0].Rows[0]["FilePath"].ToString();
                if (ds.Tables[0].Rows[0]["ListType"].ToString() != "")
                {
                    model.ListType = int.Parse(ds.Tables[0].Rows[0]["ListType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GoType"].ToString() != "")
                {
                    model.GoType = int.Parse(ds.Tables[0].Rows[0]["GoType"].ToString());
                }
                model.DefaultFile = ds.Tables[0].Rows[0]["DefaultFile"].ToString();
                model.ColumnsType = int.Parse(ds.Tables[0].Rows[0]["ColumnsType"].ToString());
                model.WebsiteUrl = ds.Tables[0].Rows[0]["WebsiteUrl"].ToString();
                model.TemplateIndex = ds.Tables[0].Rows[0]["TemplateIndex"].ToString();
                model.TemplateList = ds.Tables[0].Rows[0]["TemplateList"].ToString();
                model.TemplateShow = ds.Tables[0].Rows[0]["TemplateShow"].ToString();
                model.ListeRules = ds.Tables[0].Rows[0]["ListeRules"].ToString();
                model.ShowRules = ds.Tables[0].Rows[0]["ShowRules"].ToString();
                model.keyword = ds.Tables[0].Rows[0]["keyword"].ToString();
                model.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                model.contents = ds.Tables[0].Rows[0]["contents"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取该菜单项的所有子菜单项
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public DataSet GetSubClassList(string ClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from "+PubConstant.date_prefix+"Class");
            strSql.Append(" where ClassPre='" + ClassId + "' ");
            strSql.Append(" Order By ClassList Asc,ClassOrder Asc");
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetClassList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from " + PubConstant.date_prefix + "Class");
            strSql.Append(" Order By ClassList,ClassOrder,Id Asc");
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetClassList(int ClassKind)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from "+PubConstant.date_prefix+"Class");
            strSql.Append(" where ClassKind=" + ClassKind + "");
            strSql.Append(" order by ClassList,ClassOrder,Id Asc ");
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetClassList(int Top, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM " + PubConstant.date_prefix + "Class");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by ClassList,ClassOrder,Id Asc ");
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }
        /// <summary>
        /// 获取菜单列表 按层筛选
        /// </summary>
        /// <returns></returns>
        public DataSet GetClassList(int ClassKind, int ClassTj)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where ClassKind=" + ClassKind + " and ClassTj="+ ClassTj + "");
            strSql.Append(" Order By ClassList,ClassOrder,Id Asc");
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }
        public string GetPreClassId(string ClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select top 1 ClassPre From "+PubConstant.date_prefix+"Class");
            strSql.Append(" Where ClassId='" + ClassId + "'");
            strSql.Append(" Order By ClassList Asc,ClassOrder Asc");
            return ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()).ToString();
        }

        /// <summary>
        /// 删除一个菜单项
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public bool DelByClassId(string ClassId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From "+PubConstant.date_prefix+"Class");
            strSql.Append(" where ClassId='" + ClassId + "'");
            //批量删除分类下的所有子类
            DataTable dt = GetSubClassList(ClassId).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DelById(Convert.ToInt32(dr["Id"]));
            }

            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString()) > 0;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + PubConstant.date_prefix + "Class  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());
        }

        public bool DelById(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Delete From " + PubConstant.date_prefix + "Class");
            strSql.Append(" where Id=" + Id + "");
            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString()) > 0;
        }
        /// <summary>
        /// 更新排序
        /// </summary>
        /// <param name="ClassId"></param>
        /// <param name="ClassOrder"></param>
        /// <returns></returns>
        public bool UpdateClassOrder(string ClassId, int ClassOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Update " + PubConstant.date_prefix + "Class Set ");
            if (_GetField(ClassId, "ClassPre") != "0")
            {
                strSql.Append("ClassOrder=" + Convert.ToInt32(_GetField(_GetField(ClassId, "ClassPre"), "ClassOrder").ToString() + ClassOrder.ToString()) + " ");
            }
            else {
                strSql.Append("ClassOrder=" + ClassOrder + " ");
            }
            strSql.Append(" where ClassId='" + ClassId + "'");
            return ROYcms.DB.DbHelpers.NonQuery(strSql.ToString()) > 0;

        }
        public string _GetField(string ClassId, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "Class");
            strSql.Append(" where ClassId='" + ClassId + "' ");
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
    }
}
