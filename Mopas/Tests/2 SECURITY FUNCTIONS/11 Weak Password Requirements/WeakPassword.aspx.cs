using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 25.
    /// Weak Password Requirements
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class WeakPassword : System.Web.UI.Page
    {
        private string username;
        private string password;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //User credentials
            username = TextUsername.Text;
            password = TextPassword.Text;

            int result = AddNewUser(username, password);
            
            //Check if user was added
            if (result == 1)
                Response.Write("New user <i>" + username + "</i> was added");

        }

        protected int AddNewUser(string user, string pass)
        {
            bool isUnique = true;
            if (isUnique)
                return 0;
            else
                return -1;
        }


    }
}