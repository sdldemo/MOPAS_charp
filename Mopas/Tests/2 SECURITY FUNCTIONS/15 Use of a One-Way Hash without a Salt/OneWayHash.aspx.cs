using System;
using System.Security.Cryptography;
using System.Text;

namespace Mopas.Tests
{
    /// <summary>
    /// 29.
    /// Use of One-Way Hash without a Salt
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class OneWayHash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string source = Request.Params["password"];
            using (MD5 md5Hash = MD5.Create())
            {
                string result = "";

                //Get hash
                byte[] hash = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(source));

                //Puth hash in response
                foreach (byte value in hash)
                    result += value.ToString("x2");

                // TODO: AI issue #3, High, Cross-site Scripting, https://github.com/sdldemo/MOPAS_charp/issues/3
                // GET /Tests/2 SECURITY FUNCTIONS/15 Use of a One-Way Hash without a Salt/OneWayHash.aspx HTTP/1.1
                // Host:localhost
                // (System.Security.Cryptography.MD5.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(this.Request.Params["password"])).GetEnumerator().MoveNext() && (System.Security.Cryptography.MD5.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(this.Request.Params["password"])).GetEnumerator().Current.ToString("x2") == "<script>alert(0)</script>"))
                Response.Write(result);
            }
        }
    }
}