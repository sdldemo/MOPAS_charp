using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 42.
    /// Public Data Assigned to Private Array-Typed Field
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class PrivateDataSet : System.Web.UI.Page
    {
        private string[] userRoles = new string[]{};

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] roles = Request.Params["roles"].Split(';');

            SetRoles(roles);
        }

        public void SetRoles(string[] roles)
        {
            userRoles = roles;
        }
    }
}