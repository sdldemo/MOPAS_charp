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

                Response.Write(result);
            }
        }
    }
}