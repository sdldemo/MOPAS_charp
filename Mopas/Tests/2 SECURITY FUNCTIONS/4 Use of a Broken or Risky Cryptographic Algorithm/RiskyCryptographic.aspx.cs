using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Mopas.Tests
{
    /// <summary>
    /// 18.
    /// Use of a Broken or Risky Cryptographic Algorithm
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class RyskyCryptographic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pass = "password";

            DESCryptoServiceProvider desProvider = new DESCryptoServiceProvider();
            DES des = DES.Create();
            desProvider.Mode = CipherMode.ECB;
            desProvider.Padding = PaddingMode.PKCS7;
            desProvider.Key = Encoding.ASCII.GetBytes("e5d66cf8");

            using (MemoryStream stream = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(stream, desProvider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] data = Encoding.Default.GetBytes(pass);
                    cs.Write(data, 0, data.Length);
                    Response.Write(stream.ToArray());
                }
            }
        }
    }
}