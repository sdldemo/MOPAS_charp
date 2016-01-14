using System;
using System.Text.RegularExpressions;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 26.
    /// Information Exposure Through Persistent Cookies
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class PersistentCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cookieExpires = 0;
            int.TryParse(Request.Params["expire_time"], out cookieExpires);

            //Get session ID
            string sessionId = Request.Params["sessionId"];
            Regex regex = new Regex("[A-Za-z0-9=]+");
            Match match = regex.Match(sessionId);

            if (match.Success)
            {
                HttpCookie cookie = new HttpCookie("sessionId", sessionId);
                cookie.Expires = DateTime.Now.AddSeconds(cookieExpires);
            }
        }
    }
}