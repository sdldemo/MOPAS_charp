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
                // TODO: AI issue #6, High, Open Redirect, https://github.com/sdldemo/MOPAS_charp/issues/6
                // GET /Tests/1 INPUT DATA VERIFICATION/6 URL Redirection to Untrusted Site/OpenRedirect.aspx?nurl=http%3a%2f%2flocalhost HTTP/1.1
                // Host:localhost
                Response.Redirect(nurl);
            }
            else
            {
                Response.Write("<b>page under construct</b>");
            }
        }
    }
}