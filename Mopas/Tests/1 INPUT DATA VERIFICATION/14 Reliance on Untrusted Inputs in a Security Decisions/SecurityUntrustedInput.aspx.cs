using System;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 14.
    /// Reliance on Untrusted Inputs in a Security Decisions
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class SecurityUntrustedInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int authenticated = 0;

            foreach (HttpCookie cook in Request.Cookies)
            {
                if (cook.Name.Equals("auth"))
                {
                    authenticated = int.Parse(cook.Value);
                }
            }

            if (authenticated == 1)
            {
                Response.Write("You are logged in");
            }
            else
            {
                Response.Write("Please log in");
            }
        }
    }
}