using System;
using System.Data.SqlClient;
using System.Security;

namespace Mopas.Tests
{
    /// <summary>
    /// 23.
    /// Plaintext Storage of a Password
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class PasswordStorage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Root password is "tiger"
            string userId = "root";
            string passString = "tiger";
            SecureString password = new SecureString();
            foreach (char c in passString)
                password.AppendChar(c);


            using (var connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, new SqlCredential(userId, password)))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT into users(user, pass) values('" + userId + "', '" + passString + "')";
                connection.Open();
                command.ExecuteReader();
            }
            Response.Write("<b>Saved</b>");
        }
    }
}