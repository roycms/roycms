using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Net;
using System.Collections.Specialized;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace ROYcms.UI.Admin.UCenter
{
    public partial class QQLogin : System.Web.UI.Page
    {
        /// <summary>
        /// 填写你申请的登录资料
        /// </summary>
        private string appKey = "";
        private string appSecret = "";
        /// <summary>
        /// 页面加载方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["oauth_token"] != null)
            {
                string oauth_token = Request.QueryString["oauth_token"];
                string oauth_vericode = Request.QueryString["oauth_vericode"];
                string error = string.Empty;
                try
                {
                    //换取访问令牌
                    string openID = GetAccessToken(oauth_token, oauth_vericode, Session["oauth_token_secret"].ToString());
                    if (openID != string.Empty)
                    {
                        //登陆成功，进行自我网站业务逻辑的处理
                        Session["OpenID"] = openID;
                        Response.Redirect("/Default.aspx");
                    }
                    else
                    {
                        error = "不存在该用户";
                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message.ToString();
                }
                //错误处理，返回登录页，并且提示错误
                if (error != string.Empty)
                {
                    Response.Redirect("/Default.aspx?Error=" + error);
                }
            }
            else
            {
                //获取临时令牌
                string result = GetRequestToken();
                //获取授权令牌
                if (result != string.Empty)
                {
                    string oauth_token = result.Split('|')[0];
                    string oauth_token_secret = result.Split('|')[1];
                    Session["oauth_token_secret"] = oauth_token_secret;
                    string callBackUrl = "http://" + Request.ServerVariables["Http_Host"] + "/Login.aspx";
                    Response.Redirect("http://openapi.qzone.qq.com/oauth/qzoneoauth_authorize?oauth_consumer_key=" + appKey + "&oauth_token=" + oauth_token + "&oauth_callback=" + callBackUrl);
                }
            }
        }
        /// <summary>
        /// 获取未授权的临时令牌
        /// </summary>
        private string GetRequestToken()
        {
            string url = "http://openapi.qzone.qq.com/oauth/qzoneoauth_request_token";
            string[] parameters ={
                "oauth_consumer_key="+appKey,
                "oauth_nonce="+this.GenerateNonce(),
                "oauth_timestamp="+this.GenerateTimeStamp(),
                "oauth_version=1.0",
                "oauth_signature_method=HMAC-SHA1",            
                "oauth_client_ip=1"
            };
            //生成签名
            string sign = GenerateSign(url, parameters, "GET", appSecret + "&");
            string tempParameters = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                tempParameters += parameters[i] + "&";
            }
            url = url + "?" + tempParameters + "oauth_signature=" + UrlEncode(sign);
            //请求临时令牌
            string response = WebRequestGet(url);
            string oauth_token = string.Empty;//5+1+a+s+p+x
            string oauth_token_secret = string.Empty;
            if (response.Length > 0)
            {
                NameValueCollection qs = HttpUtility.ParseQueryString(response);
                if (qs["oauth_token"] != null)
                {
                    oauth_token = qs["oauth_token"];
                    oauth_token_secret = qs["oauth_token_secret"];
                }
            }
            return oauth_token + "|" + oauth_token_secret;
        }
        /// <summary>
        /// 换取访问令牌
        /// </summary>
        private string GetAccessToken(string oauth_token, string oauth_vericode, string oauth_token_secret)
        {
            string url = "http://openapi.qzone.qq.com/oauth/qzoneoauth_access_token";
            string[] parameters ={
                "oauth_consumer_key="+appKey,
                "oauth_token="+oauth_token,
                "oauth_nonce="+this.GenerateNonce(),
                "oauth_timestamp="+this.GenerateTimeStamp(),
                "oauth_version=1.0",
                "oauth_signature_method=HMAC-SHA1",   
                "oauth_vericode="+oauth_vericode,   
                "oauth_client_ip=1"
            };
            //生成url
            string sign = GenerateSign(url, parameters, "GET", appSecret + "&" + oauth_token_secret);
            string tempParameters = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                tempParameters += parameters[i] + "&";
            }
            url = url + "?" + tempParameters + "oauth_signature=" + UrlEncode(sign);
            //换取访问令牌
            string response = WebRequestGet(url);
            string openID = string.Empty;
            if (response.Length > 0)
            {
                NameValueCollection qs = HttpUtility.ParseQueryString(response);
                if (qs["openid"] != null)
                {
                    openID = qs["openid"];
                }
            }
            return openID;
        }
        /// <summary>
        /// 生成时间戳
        /// </summary>
        /// <returns></returns>
        private string GenerateTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();//5+1+a+s+p+x
        }
        /// <summary>
        /// 生成随机数
        /// </summary>
        /// <returns></returns>
        private string GenerateNonce()
        {
            Random random = new Random();
            return random.Next(123400, 9999999).ToString();
        }
        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <param name="method"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        private string GenerateSign(string url, string[] parameters, string method, string secret)
        {
            string[] sortParameters = BubbleSortASC(parameters);
            string tempParameters = string.Empty;
            for (int i = 0; i < parameters.Length; i++)
            {
                if (tempParameters == string.Empty)
                {
                    tempParameters = parameters[i];
                }
                else
                {
                    tempParameters += "&" + parameters[i];
                }
            }
            string source = method + "&" + UrlEncode(url) + "&" + UrlEncode(tempParameters);
            return Convert.ToBase64String(HMACSHA1(source, secret));
        }
        /// <summary>
        /// url编码
        /// </summary>
        /// <param name="value">The value to Url encode</param>
        /// <returns>Returns a Url encoded string</returns>
        private string UrlEncode(string value)
        {
            string unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";
            StringBuilder result = new StringBuilder();
            foreach (char symbol in value)
            {
                if (unreservedChars.IndexOf(symbol) != -1)
                {
                    result.Append(symbol);
                }
                else
                {
                    result.Append('%' + String.Format("{0:X2}", (int)symbol));
                }
            }
            return result.ToString();
        }
        /// <summary>
        /// HMACSHA1加密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private byte[] HMACSHA1(string content, string key)
        {
            HMACSHA1 hmacsha = new HMACSHA1();
            hmacsha.Key = Encoding.ASCII.GetBytes(key);
            byte[] bytes = Encoding.ASCII.GetBytes(content);
            return hmacsha.ComputeHash(bytes);
        }
        /// <summary>
        /// 排序算法
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        private string[] BubbleSortASC(string[] r)
        {
            for (int i = 0; i < r.Length; i++)
            {
                bool flag = false;
                for (int j = r.Length - 2; j >= i; j--)
                {
                    if (string.CompareOrdinal(r[j + 1], r[j]) < 0)
                    {
                        string str = r[j + 1];
                        r[j + 1] = r[j];
                        r[j] = str;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    return r;
                }
            }
            return r;
        }
        /// <summary>
        /// Get请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string WebRequestGet(string url)
        {
            HttpWebRequest webRequest = WebRequest.Create(url) as HttpWebRequest;
            webRequest.Method = "GET";
            webRequest.ServicePoint.Expect100Continue = false;
            string str = WebResponseGet(webRequest);
            webRequest = null;
            return str;
        }
        /// <summary>
        /// 数据返回
        /// </summary>
        /// <param name="webRequest"></param>
        /// <returns></returns>
        private static string WebResponseGet(HttpWebRequest webRequest)
        {
            StreamReader reader = null;
            string str = string.Empty;
            try
            {
                reader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                str = reader.ReadToEnd();
            }
            catch
            {
                throw;
            }
            finally
            {
                webRequest.GetResponse().GetResponseStream().Close();
                reader.Close();
                reader = null;
            }
            return str;
        }       
    }
}
