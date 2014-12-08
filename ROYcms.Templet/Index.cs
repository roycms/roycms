using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ROYcms.Templet
{
    public class Index
    {
        public IndexModel IndexModels = new IndexModel();
        public IndexDate IndexDates = new IndexDate();
        public string CmsMain()
        {
            string HTML = null;
            //获取页面重写时有效参数
            IndexModels.DoMain = new ROYcms.Templet.IndexDate().GetDoMain(); //域名
            IndexModels.index = ROYcms.Common.Request.GetQueryString("index");
            IndexModels.id = ROYcms.Common.Request.GetQueryInt("id");
            IndexModels.type = ROYcms.Common.Request.GetQueryInt("type");
            IndexModels.page = ROYcms.Common.Request.GetQueryInt("page");
            switch (IndexModels.index)
            {
                case "Channel": HTML = IndexDates.ChannelDate(IndexModels); //频道模型
                    break;
                case "ChannelList": HTML = IndexDates.ChannelListDate(IndexModels); //频道模型
                    break;
                case "Article": HTML = IndexDates.ArticleDate(IndexModels); //文章详细页面
                    break;
                //case "Goods": HTML = IndexDates.GoodsDate(IndexModels); //商品详细页面
                //    break;
                case "Index": HTML = IndexDates.IDate(); //首页
                    break;
                default: HTML = "地址无效！"; 
                    break;
            }

            return HTML;//此处对返回HTML进行格式化
        }
    }
}
