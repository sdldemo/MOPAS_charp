using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 6.
    /// URL Redirection to Untrusted Site (Open redirect)
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class OpenRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nurl = Request.Params["nurl"];
            if (nurl != null)
            {
                Response.Redirect(nurl);
            }
            else
            {
                Response.Write("<b>page under construct</b>");
            }
        }
    }
}