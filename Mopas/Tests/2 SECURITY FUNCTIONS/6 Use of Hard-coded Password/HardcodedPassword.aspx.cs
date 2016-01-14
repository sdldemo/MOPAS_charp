using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 20.
    /// Use of Hard-Coded Password
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class HardcodedPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.Params["id"];
            string pass = Request.Params["pass"];
            bool is_authenticated = false;

            if (pass.Equals("admin_p@ssword"))
            {
                is_authenticated = true;
            }


            if (is_authenticated)
            {
                Response.Write("<b>Admin panel</b>");
            }
        }
    }
}