using System;
using System.Web;

namespace Mopas.Tests
{
    public partial class CSRF : System.Web.UI.Page
    {
        private string password = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            //Get user ID
            HttpContext context = HttpContext.Current;

            string userId = context.Session["user_id"].ToString();

            //Change password for that user
            string userPass = Request.Params["userpass"];
            ChangePassword(userId, userPass);
        }

        public void ChangePassword(string userId, string userPass)
        {
            //Change pass for user with userId
            if (userPass != null)
            {
                password = userPass;
            }
            
        }
    }
}