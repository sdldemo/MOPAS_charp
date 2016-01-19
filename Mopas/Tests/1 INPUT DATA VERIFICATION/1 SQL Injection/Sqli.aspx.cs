using System;
using System.Data.SqlClient;

namespace Mopas.Tests
{

    /// <summary>
    /// 1.
    /// SQL Injection
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class Sqli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.Params["id"];

            string str1 = "";

            using (var connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            using (var command = connection.CreateCommand())
            {
                // TODO: AI issue #1, High, SQL Injection, https://github.com/sdldemo/MOPAS_charp/issues/1
                // GET /Tests/1 INPUT DATA VERIFICATION/1 SQL Injection/Sqli.aspx HTTP/1.1
                // Host:localhost
                // (this.Request.Params["id"] == "1' AND '1'='2".StartsWith("SELECT test FROM news where id=") ? "1' AND '1'='2".Substring("SELECT test FROM news where id=".Length) : "1' AND '1'='2")
                command.CommandText = "SELECT test FROM news where id=" + id;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        str1 += reader["ColumnName"].ToString();
                }
            }

            Response.Write("<b>" + str1 + "</b>");
        }
    }
}