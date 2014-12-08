using System.Text;

/// <summary>
///Tag 的摘要说明
/// </summary>
namespace ROYcms.Templet
{
    /// <summary>
    /// 
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// 列表数据
        /// </summary>
        private string _NewsCount;
        private string _TitleNum;
        private string _NewsType;
        private string _Ding;
        private string _Tuijian;
        private string _Templet;
        private string _PageSize;
        private string _SQL;
        public bool pg = false;

        public string NewsCount
        {
            get { return _NewsCount; }
            set { _NewsCount = value; }
        }
        public string TitleNum
        {
            get { return _TitleNum; }
            set { _TitleNum = value; }
        }
        public string NewsType
        {
            get { return _NewsType; }
            set { _NewsType = value; }
        }
        public string Ding
        {
            get { return _Ding; }
            set { _Ding = value; }
        }
        public string Tuijian
        {
            get { return _Tuijian; }
            set { _Tuijian = value; }
        }
        public string Templet
        {
            get { return _Templet; }
            set { _Templet = value; }
        }
        public string PageSize
        {
            get { return _PageSize; }
            set { _PageSize = value; }
        }
        public string SQL
        {
            get { return _SQL; }
            set { _SQL = value; }
        }
        /// <summary>
        /// Get_s the TA g2.//获取标签(第三方通用模式)
        /// </summary>
        /// <param name="LIST">The LIST.</param>
        /// <returns></returns>
        public string get_TAG()
        {
            StringBuilder strHTML = new StringBuilder();
            if (pg)
            {
                strHTML.Append("<!--TAG标签-->\n\n\n[SG:loopPage");
            }
            else
            {

                strHTML.Append("<!--TAG标签-->\n\n\n[SG:loop");
            }
            if (NewsCount != null)
            {
                strHTML.Append(" NewsCount=\"" + NewsCount + "\"");
            }
            if (TitleNum != null)
            {
                strHTML.Append(" TitleNum=\"" + TitleNum + "\"");
            }
            if (NewsType != null)
            {
                strHTML.Append(" NewsType=\"" + NewsType + "\"");
            }
            if (Ding != null)
            {
                strHTML.Append(" Ding=\"" + Ding + "\"");
            }
            if (Tuijian != null)
            {
                strHTML.Append(" Tuijian=\"" + Tuijian + "\"");
            }
            if (Templet != null)
            {
                strHTML.Append(" Templet=\"" + Templet + "\"");
            }
            if (PageSize != null)
            {
                strHTML.Append(" PageSize=\"" + PageSize + "\"");
            }
            if (SQL != null)
            {
                strHTML.Append(" SQL=\"" + SQL + "\"");
            }
            strHTML.Append("]");
            strHTML.Append("\n\n<a href='[SG:Link]'>[SG:Title] </a>\n[SG:Time]\n\n");
            if (pg)
            {
                strHTML.Append("[/SG:loopPage]");
                strHTML.Append("\n\n页的数据总数[SG:Page]");
            }
            else
            {
                strHTML.Append("[/SG:loop]");
            }
            return strHTML.ToString();
        }
    }
}