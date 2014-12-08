using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// FormRewriter 的摘要说明
/// </summary>
namespace URLRewriter.Form111
{
    /// <summary>
    /// 
    /// </summary>
    public class FormRewriterControlAdapter : System.Web.UI.Adapters.ControlAdapter
    {
        public FormRewriterControlAdapter()
        {
        }

        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(new RewriteFormHtmlTextWriter(writer));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class RewriteFormHtmlTextWriter : HtmlTextWriter
    {
        public RewriteFormHtmlTextWriter(HtmlTextWriter writer)
            : base(writer)
        {
            base.InnerWriter = writer.InnerWriter;
        }
        public RewriteFormHtmlTextWriter(System.IO.TextWriter writer)
            : base(writer)
        {
            base.InnerWriter = writer;
        }

        public override void WriteAttribute(string name, string value, bool fEncode)
        {
            //If the attribute we are writing is the "action" attribute, and we are not on a sub-control, 
            //then replace the value to write with the raw URL of the request - which ensures that we'll
            //preserve the PathInfo value on postback scenarios
            if (name == "action")
            {
                HttpContext context = HttpContext.Current;
                if (context.Items["ActionAlreadyWritten"] == null)
                {
                    //We will use the Request.RawUrl property within ASP.NET to retrieve the origional 
                    //URL before it was re-written.
                    value = context.Request.RawUrl;
                    //Indicate that we've already rewritten the <form>'s action attribute to prevent
                    //us from rewriting a sub-control under the <form> control
                    context.Items["ActionAlreadyWritten"] = true;
                }
            }
            base.WriteAttribute(name, value, fEncode);
        }
    }

}