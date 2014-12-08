using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using System.Web.UI.WebControls;
using ROYcms.Sys.DAL;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ҵ���߼���ROYcms_product ��ժҪ˵����
	/// </summary>
	public class ROYcms_product
	{
		private readonly ROYcms.Sys.DAL.ROYcms_product dal=new ROYcms.Sys.DAL.ROYcms_product();
		public ROYcms_product()
		{}
		#region  ��Ա����
        /// <summary>
        /// ��������Ϣ����ת��
        /// </summary>
        public void GoToClass(int go, int to)
        {
            dal.GoToClass(go,to);
        }
        /// <summary>
        /// ��Ϣ����ת�� ����BH
        /// </summary>
        public void ToClass(int to_class, int bh)
        {
            dal.ToClass(to_class, bh);
        }
        /// <summary>
        /// �Ƿ���ڸü�¼ ���ݱ���
        /// </summary>
        public bool Exists_title(string title)
        {
            return dal.Exists_title(title);
        }
        /// <summary>
        /// �Զ���SQL��䷵��DATESET
        /// </summary>
        public DataSet GetDataSet(string SQL)
        {
            return dal._GetDataSet(SQL);
        }
        /// <summary>
        /// ��ȡһ����Ϣ ���� Tops the product.
        /// </summary>
        /// <returns></returns>
        public ROYcms.Sys.Model.ROYcms_product TopProduct(string where)
        {
            return dal.TopProduct(where);
        }
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int bh)
		{
			return dal.Exists(bh);
		}
          /// <summary>
        /// ������±���
        /// </summary>
        public string GetTitle(int bh)
        {
            return dal.GetTitle(bh);
        }
        /// <summary>
        /// ��ȡ ����ֵ  �����ֶ�
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(int Id, string Field)
        {
            return dal.GetField(Id, Field);
        }
        /// <summary>
        /// ���ClassKind
        /// </summary>
        public string GetClassKind(int bh)
        {
            return dal.GetClassKind(bh);
        }
        /// <summary>
        /// ������·���
        /// </summary>
        public string GetClassName(int bh)
        {
            return dal.GetClassName(bh);
        }
        /// <summary>
        /// ���һ�� ����һ�������¼
        /// </summary>
        public void Hits_product(int bh)
        {
            dal.Hits_product(bh);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_product model)
		{
            int news_id = dal.Add(model);

            //
            //��������
            //
            if (news_id != 1) 
            {
                ROYcms.Sys.BLL.ROYcms_Class_News ROYcms_Class_product_bll = new ROYcms.Sys.BLL.ROYcms_Class_News();
                ROYcms.Sys.Model.ROYcms_Class_News ROYcms_Class_product_model = new ROYcms.Sys.Model.ROYcms_Class_News();
                ROYcms.Sys.BLL.ROYcms_class ROYcms_Class_bll = new ROYcms.Sys.BLL.ROYcms_class();
                ROYcms.Sys.Model.ROYcms_class ROYcms_Class_model = ROYcms_Class_bll._GetModel(model.classname.ToString());

                ROYcms_Class_product_model.news_id = news_id;
                ROYcms_Class_product_model.Class = Convert.ToInt32(model.classname);
                ROYcms_Class_product_model.class_id = ROYcms_Class_model.ClassId;
                ROYcms_Class_product_model.class_list = ROYcms_Class_model.ClassList;
                ROYcms_Class_product_model.Time = DateTime.Now;
                ROYcms_Class_product_model.GUID = model.GUID;
                ROYcms_Class_product_bll.Add(ROYcms_Class_product_model);

            }
			return news_id;
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_product model)
        {


            //
            //��������  ɾ����ǰ�ķ������  �½�һ���������
            //

            ROYcms.Sys.BLL.ROYcms_Class_News ROYcms_Class_product_bll = new ROYcms.Sys.BLL.ROYcms_Class_News();
            ROYcms.Sys.Model.ROYcms_Class_News ROYcms_Class_product_model = new ROYcms.Sys.Model.ROYcms_Class_News();
            ROYcms.Sys.BLL.ROYcms_class ROYcms_Class_bll = new ROYcms.Sys.BLL.ROYcms_class();
            ROYcms.Sys.Model.ROYcms_class ROYcms_Class_model = ROYcms_Class_bll._GetModel(model.classname.ToString());

            //ɾ��
            ROYcms_Class_product_bll.Delete(" (news_id=" + model.bh + ") AND (Class=" + GetClassName(model.bh) + ") ");
            //����
            ROYcms_Class_product_model.news_id = model.bh;
            ROYcms_Class_product_model.Class = Convert.ToInt32(model.classname);
            ROYcms_Class_product_model.class_id = ROYcms_Class_model.ClassId;
            ROYcms_Class_product_model.class_list = ROYcms_Class_model.ClassList;
            ROYcms_Class_product_model.Time = DateTime.Now;
            ROYcms_Class_product_model.GUID = model.GUID;
            ROYcms_Class_product_bll.Add(ROYcms_Class_product_model);

            dal.Update(model);

        }

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int bh)
		{
			dal.Delete(bh);

            //����ɾ���������
            ROYcms.Sys.BLL.ROYcms_Class_News ROYcms_Class_product_bll = new ROYcms.Sys.BLL.ROYcms_Class_News();
            ROYcms.Sys.BLL.ROYcms_New_User ROYcms_New_User_bll = new ROYcms.Sys.BLL.ROYcms_New_User();
            //ɾ��
            ROYcms_Class_product_bll.Delete(" news_id=" + bh);
            ROYcms_New_User_bll.Delete(" new_id=" + bh);
		}
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(string strWhere)
        {
            int bh = dal.Delete(strWhere);
            return bh;
        }
        /// <summary>
        /// �޸�һ�������Ƿ��ö�
        /// </summary>
        public void Ding_product(int bh,int ding)
        {

            dal.Ding_product(bh,ding);
        }
        /// <summary>
        /// �޸�һ�������Ƿ��Ƽ�
        /// </summary>
        public void Tuijian_product(int bh, int tuijian)
        {

            dal.Tuijian_product(bh, tuijian);
        }
        /// <summary>
        /// ���ƿ��� �� �͹ر�һ������
        /// </summary>
        public void K_product(int bh,int switchs)
        {

            dal.K_product(bh, switchs);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_product GetModel(int bh)
		{
			
			return dal.GetModel(bh);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_product GetModelByCache(int bh)
		{
			
			string CacheKey = PubConstant.date_prefix + "productModel-" + bh;
			object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(bh);
					if (objModel != null)
					{
						int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
						ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Sys.Model.ROYcms_product)objModel;
		}

        /// <summary>
        /// ��һҳ��Ϣ
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="classname">The classname.</param>
        /// <returns>id,����,ʱ��</returns>
        public string PgUp(int id, string classname)
        {
            ROYcms.Sys.Model.ROYcms_product Model = dal.TopProduct(" bh<" + id + " and classname='" + classname + "' order by bh ");
            if (Model != null)
            {
                return Model.bh.ToString() + "," + Model.title + "," + Model.time;
            }
            else { return ""; }
        }
        /// <summary>
        /// ��һҳ��Ϣ
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="classname">The classname.</param>
        /// <returns>id,����,ʱ��</returns>
        public string PgDn(int id,string classname)
        {
            ROYcms.Sys.Model.ROYcms_product Model = dal.TopProduct(" bh>" + id + " and classname='" + classname + "' order by bh desc ");
            if (Model != null)
            {
                return Model.bh.ToString() + "," + Model.title + "," + Model.time;
            }
            else { return ""; }
        }

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        /// <summary>
        /// ��������б� SQL���ض���
        /// </summary>
        public DataSet GetList_(string strSql)
        {
            return dal.GetList_(strSql);
        }
        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
       
        /// <summary>
        /// ��������б� + ��ҳ �洢����
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize,PageIndex,strWhere);
        }
        /// <summary>
        /// ��������б� + ��ҳ �洢����
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, int OrderType)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, OrderType);
        }
        /// <summary>
        /// �����������
        /// </summary>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
		
		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}
