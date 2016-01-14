using System;
using System.IO;
using System.Security.Cryptography;

namespace Mopas.Tests
{
    public partial class HardcodedKey : System.Web.UI.Page
    {
        /// <summary>
        /// 24. Use of Hard-coded PCryptographic Key
        /// MOPAS
        /// Contains 1 vulnerability
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            //Set key size
            TDES.KeySize = 10;

            //Generate keys
            TDES.Key = new byte[] { 0x35, 0x35, 0x43, 0x52, 0x39, 0x32, 0x36, 0x41 };
            TDES.IV = new byte[] { 0x36, 0x35, 0x42, 0x55, 0x33, 0x42, 0x39, 0x50 };

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