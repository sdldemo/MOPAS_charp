using System;
using System.IO;
using System.Security.Cryptography;

namespace Mopas.Tests
{
    /// <summary>
    /// 21.
    /// Cryptographic Issues (Insufficient Encryption Key Length)
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class InsufficientKey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            //Set key size
            TDES.KeySize = 10;

            //Generate keys
            TDES.GenerateIV();
            TDES.GenerateKey();

            string data = "p@ssword";

            try
            {
                // Create or open the specified file.
                FileStream fStream = File.Open(@"C:\passwords.txt", FileMode.OpenOrCreate);

                // Create a CryptoStream using the FileStream  
                // and the passed key and initialization vector (IV).
                CryptoStream cStream = new CryptoStream(fStream,
                    new TripleDESCryptoServiceProvider().CreateEncryptor(TDES.Key, TDES.IV),
                    CryptoStreamMode.Write);

                // Create a StreamWriter using the CryptoStream.
                StreamWriter sWriter = new StreamWriter(cStream);

                // Write the data to the stream  
                // to encrypt it.
                sWriter.WriteLine(data);

                // Close the streams and 
                // close the file.
                sWriter.Close();
                cStream.Close();
                fStream.Close();
            }
            catch
            {
                Console.WriteLine("A Cryptographic error occurred");
            }

        }
    }
}