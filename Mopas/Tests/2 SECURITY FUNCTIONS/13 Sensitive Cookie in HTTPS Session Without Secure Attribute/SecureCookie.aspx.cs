using System;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 27.
    /// Sensitive Cookie in HTTPS Session Withou 'Secure' Attribute
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class SecureCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get account id
            string accountId = Request.Params["acct_id"];

            //Set cookie with account id
            HttpCookie c = new HttpCookie("account", accountId);
            
            //Response with authenticated account id
            Response.Write("Your account is valid");
        }
    }
}