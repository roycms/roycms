using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Common
{
    public class StringPlus
    {

        public static string[] GetStrArray(string str)
        {
            return str.Split(new char[',']);
        }

        public static string GetArrayStr(List<string> list,string speater)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    sb.Append(list[i]);
                }
                else
                {
                    sb.Append(list[i]);
                    sb.Append(speater);
                }
            }
            return sb.ToString();
        }
        #region 删除最后一个字符之后的字符

        /// <summary>
        /// 删除最后结尾的一个逗号
        /// </summary>
        public static string DelLastComma(string str)
        {
            return str.Substring(0, str.LastIndexOf(","));
        }
        /// <summary>
        /// 判断字符串是否是中文
        /// </summary>
        public static bool IsZn(string input)
        {
               int code = 0;
        int chfrom = Convert.ToInt32("4e00", 16);    //范围（0x4e00～0x9fff）转换成int（chfrom～chend）
        int chend = Convert.ToInt32("9fff", 16);
        if (input != "")
         {
             //code = Char.ConvertToUtf32(input, index);//参数 待处理字符串，长度
             code = Char.ConvertToUtf32(input, 16);    //获得字符串input中指定索引index处字符unicode编码
            
           if (code >= chfrom && code <= chend)     
             {
                return true;     //当code在中文范围内返回true

             }
            else
            {
                 return false ;    //当code不在中文范围内返回false
             }
         }
          return false;
        }
        /// <summary>
        /// 删除最后结尾的指定字符后的字符
        /// </summary>
        public static string DelLastChar(string str,string strchar)
        {
            return str.Substring(0, str.LastIndexOf(strchar));
        }
        /// <summary>
        /// 生成指定长度的字符串,即生成strLong个str字符串
        /// </summary>
        /// <param name="strLong">生成的长度</param>
        /// <param name="str">以str生成字符串</param>
        /// <returns></returns>
        public static string StringOfChar(int strLong, string str)
        {
            string ReturnStr = "";
            for (int i = 0; i < strLong; i++)
            {
                ReturnStr += str;
            }

            return ReturnStr;
        }

        /// <summary>
        /// 生成日期随机码
        /// </summary>
        /// <returns></returns>
        public static string GetRamCode()
        {
            #region
            return DateTime.Now.ToString("yyyyMMddHHmmssffff");
            #endregion
        }
        /// <summary>
        /// 生成短日期随机码
        /// </summary>
        /// <returns></returns>
        public static string GetRamTimeCode()
        {
            #region
            return DateTime.Now.ToString("MMddHHmmss");
            #endregion
        }
        /// <summary>
        /// 产生一个随机数
        /// </summary>
        /// <param name="VcodeNum">位数</param>
        /// <returns></returns>
        public static string RandNum(int VcodeNum)
        {
            string Vchar = "2,3,4,5,6,7,8,9,A,a,C,D,E,F,G,H,G,H,M,N,V,Q,R,S,T,U,V,W,X,Y,Z,1,a,b,c,d,e,f,g,h,j,k,l,m,n";
            string[] VcArray = Vchar.Split(',');//拆分成数组
            string VNum = "";
            int temp = -1;//记录上次随机数值，尽量避避免生产几个一样的随机数
            Random rand = new Random();
            //采用一个简单的算法以保证生成随机数的不同
            for (int i = 0; i < VcodeNum; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(VcArray.Length - 1);
                if (temp != -1 && temp == t)
                {
                    return RandNum(VcodeNum);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;
        }
        #endregion

    }
}
