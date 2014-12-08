using System;
using System.Reflection;
using System.Configuration;
using DNSABC.IDAL;
using ROYcms.Common;
namespace DNSABC.DALFactory
{
	/// <summary>
	/// 抽象工厂模式创建DAL。
	/// web.config 需要加入配置：(利用工厂模式+反射机制+缓存机制,实现动态创建不同的数据层对象接口)  
	/// DataCache类在导出代码的文件夹里
	/// <appSettings>  
	/// <add key="DAL" value="DNSABC.SQLServerDAL" /> (这里的命名空间根据实际情况更改为自己项目的命名空间)
	/// </appSettings> 
	/// </summary>
	public sealed class DataAccess
	{
        private static readonly string AssemblyPath = "DNSABC.SQLServerDAL";
		/// <summary>
		/// 创建对象或从缓存获取
		/// </summary>
		public static object CreateObject(string AssemblyPath,string ClassNamespace)
		{
			object objType = DataCache.GetCache(ClassNamespace);//从缓存读取
			if (objType == null)
			{
                //try
                //{
					objType = Assembly.Load(AssemblyPath).CreateInstance(ClassNamespace);//反射创建
					DataCache.SetCache(ClassNamespace, objType);// 写入缓存
                //}
                //catch
                //{}
			}
			return objType;
		}
		/// <summary>
		/// 创建DNSABC_Cdn数据层接口。主机业务表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Cdn CreateDNSABC_Cdn()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Cdn";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Cdn)objType;
		}

		/// <summary>
		/// 创建DNSABC_Dns数据层接口。域名业务表 注意：N
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Dns CreateDNSABC_Dns()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Dns";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Dns)objType;
		}


		/// <summary>
		/// 创建DNSABC_Invoice数据层接口。发票记录表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Invoice CreateDNSABC_Invoice()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Invoice";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Invoice)objType;
		}


		/// <summary>
		/// 创建DNSABC_Log数据层接口。日志表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Log CreateDNSABC_Log()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Log";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Log)objType;
		}


		/// <summary>
		/// 创建DNSABC_Messages数据层接口。消息表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Messages CreateDNSABC_Messages()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Messages";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Messages)objType;
		}


		/// <summary>
		/// 创建DNSABC_MessagesResult数据层接口。消息回复表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_MessagesResult CreateDNSABC_MessagesResult()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_MessagesResult";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_MessagesResult)objType;
		}


		/// <summary>
		/// 创建DNSABC_Order数据层接口。订单表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Order CreateDNSABC_Order()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Order";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Order)objType;
		}


		/// <summary>
		/// 创建DNSABC_Payment数据层接口。在线支付记录表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Payment CreateDNSABC_Payment()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Payment";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Payment)objType;
		}


		/// <summary>
		/// 创建DNSABC_ProductInfo数据层接口。产品信息表 添加产品的时候需要添加用户等级ID为1的价格信息（0元/月）。删除产品的时候需要删除对应的价格信息和产品扩展信息。添加产品的时候需要添加对应类型的产品扩展信息。删除产品的时候
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_ProductInfo CreateDNSABC_ProductInfo()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_ProductInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_ProductInfo)objType;
		}


		/// <summary>
		/// 创建DNSABC_ProductModelCdn数据层接口。产品主机扩展表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_ProductModelCdn CreateDNSABC_ProductModelCdn()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_ProductModelCdn";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_ProductModelCdn)objType;
		}


		/// <summary>
		/// 创建DNSABC_ProductModelDns数据层接口。产品域名扩展表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_ProductModelDns CreateDNSABC_ProductModelDns()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_ProductModelDns";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_ProductModelDns)objType;
		}


		/// <summary>
		/// 创建DNSABC_ProductPrice数据层接口。产品价格表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_ProductPrice CreateDNSABC_ProductPrice()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_ProductPrice";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_ProductPrice)objType;
		}


		/// <summary>
		/// 创建DNSABC_Transaction数据层接口。交易记录表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_Transaction CreateDNSABC_Transaction()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_Transaction";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_Transaction)objType;
		}


		/// <summary>
		/// 创建DNSABC_UserApi数据层接口。用户接口数据表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_UserApi CreateDNSABC_UserApi()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_UserApi";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_UserApi)objType;
		}


		/// <summary>
		/// 创建DNSABC_UserGrade数据层接口。用户等级扩展表 编号为1的用户等级为初始化数据
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_UserGrade CreateDNSABC_UserGrade()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_UserGrade";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_UserGrade)objType;
		}


		/// <summary>
		/// 创建DNSABC_UserInfo数据层接口。用户信息扩展表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_UserInfo CreateDNSABC_UserInfo()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_UserInfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_UserInfo)objType;
		}


		/// <summary>
		/// 创建DNSABC_UserPerson数据层接口。用户联系人表
		/// </summary>
		public static DNSABC.IDAL.IDNSABC_UserPerson CreateDNSABC_UserPerson()
		{

			string ClassNamespace = AssemblyPath +".DNSABC_UserPerson";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (DNSABC.IDAL.IDNSABC_UserPerson)objType;
		}


        /// <summary>
        /// 创建View_user数据层接口。
        /// </summary>
        public static DNSABC.IDAL.IView_user CreateView_user()
        {

            string ClassNamespace = AssemblyPath + ".View_user";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (DNSABC.IDAL.IView_user)objType;
        }

}
}