using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 39.
    /// Leftover Debug Code
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class DebugCode : System.Web.UI.Page
    {
        private string userNameCheck = "name";
        private string userPasswordCheck = "pass";

        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.Params["user_name"];
            string userPass = Request.Params["user_pass"];
            int debug = int.Parse(Request.Params["debug"]);
            bool authenticated = false;

            if (userName.Equals(userNameCheck) && userPass.Equals(userPasswordCheck))
                authenticated = true;

            if (debug == 1 || authenticated)
            {
                //Do something
            }
            else
            {
                Response.Write("You are not authenticated");
            }
        }
    }
}