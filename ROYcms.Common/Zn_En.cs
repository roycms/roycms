using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ROYcms.Common
{
    /// <summary>
    /// 自定义部分数据
    /// </summary>
    public class Zn_En
    {
        /// <summary>
        /// Fies the specified en. 将标签的字段是名字翻译成中文 可支持中文的字段标签
        /// </summary>
        /// <param name="En">The en.</param>
        /// <returns></returns>
        public static string Fy(string En)
        {
            En = En.Replace("类别", "classname");
            En = En.Replace("标题", "title");
            En = En.Replace("推荐", "tuijian");
            En = En.Replace("开关", "switchs");
            En = En.Replace("出处", "infor");
            En = En.Replace("作者", "author");
            En = En.Replace("浏览量", "hits");
            En = En.Replace("顶次数", "dig");
            En = En.Replace("关键字", "keyword");
            En = En.Replace("描述", "zhaiyao");
            En = En.Replace("形象图", "pic");
            En = En.Replace("地址", "url");
            En = En.Replace("标签", "tag");
            En = En.Replace("内容", "contents");
            En = En.Replace("链接", "ShowLink");
            En = En.Replace("栏目名称", "ClassName");
            En = En.Replace("栏目链接", "ClassLink");
            En = En.Replace("列表链接", "ListLink");
            return En;
        }
        /// <summary>
        /// 系统主信息表news 默认的字段返回字段的数组
        /// </summary>
        /// <returns></returns>
        public static string[] MainField()
        {
            string[] Str = "bh,pic,title,keyword,zhaiyao,classname,contents,jumpurl,infor,author,url,ding,dig,tag,hits,time,orders,tuijian,switchs,link,type,isurl,GUID".Split(',');

            return Str;
        }
    }
}
