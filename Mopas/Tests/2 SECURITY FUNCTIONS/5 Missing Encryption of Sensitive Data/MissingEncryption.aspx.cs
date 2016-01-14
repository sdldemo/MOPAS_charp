using System;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 19.
    /// Missing Encryption of Sensitive Data
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class MissingEncryption : System.Web.UI.Page
    {
        private string password = "";
        private string name = "";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            password = TextPassword.Text;
            name = TextUsername.Text;

            //Set user data
            HttpContext context = HttpContext.Current;
            context.Session["username"] = name;
            context.Session["password"] = password;
            Response.Write("Authentication");
        }
    }
}