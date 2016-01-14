using System;
using System.Data.SqlClient;

namespace Mopas.Tests
{
    /// <summary>
    /// 37.
    /// Improper Resource Shutdown or Release
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class ImproperResourceShutdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM users");

            //Connect to db
            cmd.Connection = conn;
            conn.Open();

            //Execute query
            SqlDataReader rdr = cmd.ExecuteReader();
            
            //...
            //Do something with data
            //...
            
            conn.Close();
        }
    }
}