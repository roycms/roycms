using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
    /// 数据访问类ROYcms_Custom
	/// </summary>
	public class ROYcms_Custom
	{
         private readonly ROYcms.Sys.DAL.ROYcms_Custom dal = new ROYcms.Sys.DAL.ROYcms_Custom();
        /// <summary>
        /// 成员方法
        /// </summary>
        public ROYcms_Custom()
		{}
        #region  成员方法


        public ROYcms.Sys.Model.ROYcms_Custom SetVal(System.Web.UI.Page page,int Id,int Cid)
        {
            //循环得到表单所有数据 
           return dal.SetVal(page,Id,Cid);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id, string TableName)
        {
            return dal.Exists(Id, TableName);
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
            return dal.CreateTable(TableName, Tablelist);
        }
        /// <summary>
        /// 创建数据表格
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int CreateTable(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            //判断数据库表是否存在语句 select * from master.dbo.sysdatabases where name='表名'
            return dal.CreateTable(models);
        }
        /// <summary>
        /// 创建主键约束
        /// </summary>
        /// <param name="TableName">表格名字</param>
        /// <param name="Key">字段</param>
        /// <returns>返回受影响的行</returns>
        public int Key(string TableName, string Key)
        {
            return dal.Key(TableName, Key);
        }
        /// <summary>
        ///  增加一条数据
        /// </summary>
        /// <param name="TableName"> 表名称 </param>
        /// <param name="Tlist">字段顺序 例如：a1,a2</param>
        /// <param name="InsertList">值顺序 例如：var1,var2</param>
        /// <returns></returns>
        public int Add(string TableName,string Tlist, string InsertList)
        {
           return dal.Add( TableName,Tlist, InsertList);
        }
        /// <summary>
        /// 返回一个字段
        /// </summary>
        /// <param name="Id">文章ID</param>
        /// <param name="Cid">分类ID</param>
        /// <param name="Name">字段名字</param>
        /// <returns></returns>
        public string GetVal(int Id, int Cid, string Name)
        {
            return dal.GetVal(Id, Cid, Name);
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回字段数组
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetTableList(int Cid) 
        {
            return dal.GetTableList(Cid,"Name");
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回字段类型
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetInputTypeList(int Cid)
        {
            return dal.GetTableList(Cid, "InputType");
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回字段IsNull
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetIsNullList(int Cid)
        {
            return dal.GetTableList(Cid, "IsNull");
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回字段Len
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetLenList(int Cid)
        {
            return dal.GetTableList(Cid, "Len");
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回字段FieldType
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string[] GetFieldTypeList(int Cid)
        {
            return dal.GetTableList(Cid, "FieldType");
        }
        /// <summary>
        /// 根据分类Cid 分类ID返回智能关联表的表名
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string GetTableName(int Cid)
        {
            return dal.GetTableName(Cid);
        }
        /// <summary>
        ///  插入一条数据根据表单结构
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Add(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            return dal.Add(models);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="id">更新条件，关联的文章ID </param>
        /// <param name="UpdateList">更新格式如下 a1=11,a2=22,a3=33 </param>
        /// <param name="TableName"> 表名称 </param>
        public int Update(int id, string UpdateList, string TableName)
        {
            return dal.Update(id, UpdateList, TableName);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public int Update(ROYcms.Sys.Model.ROYcms_Custom models)
        {
            return dal.Update(models);
        }

        #endregion  成员方法
	}
}

