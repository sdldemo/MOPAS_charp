using System;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 12.
    /// HTTP Response Splitting
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class ResponseSplitting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/html";

            string author = Request.Params["author"];

            if (author != null)
            {
                HttpCookie cookie = new HttpCookie("author", author);
                Response.Cookies.Add(cookie);
            }
        }
    }
}