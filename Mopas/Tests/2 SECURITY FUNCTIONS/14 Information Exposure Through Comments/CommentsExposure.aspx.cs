using System;
using System.Data.SqlClient;
using System.Security;

namespace Mopas.Tests
{
    public partial class CommentsExposure : System.Web.UI.Page
    {
        /// <summary>
        /// 28.
        /// Information Exposure Through Comments
        /// MOPAS
        /// Contains 1 vulnerability
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Root password is "tiger"
            string userId = "root";
            string passString = "tiger";
            SecureString password = new SecureString();
            foreach (char c in passString)
                password.AppendChar(c);


            using (var connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, new SqlCredential(userId, password)))
            
            Response.Write("<b>Connected</b>");
        }
    }
}