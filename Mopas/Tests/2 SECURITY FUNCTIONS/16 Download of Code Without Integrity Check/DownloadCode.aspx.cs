using System;
using System.Diagnostics;
using System.Net;

namespace Mopas.Tests
{
    /// <summary>
    /// 30.
    /// Download of Code Without Integrity Check
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class DownloadCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string remoteUri = "http://www.trustedsite.com";
            string fileName = "backup.bat", myStringWebResource = null;

            // Create a new WebClient instance.
            using (WebClient myWebClient = new WebClient())
            {
                myStringWebResource = remoteUri + fileName;
                // Download the Web resource and save it into the current filesystem folder.
                myWebClient.DownloadFile(myStringWebResource, fileName);

                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

                //New proccess with vulnerable parameters
                myProcess.StartInfo = new ProcessStartInfo(fileName);

                myProcess.Start();

                myProcess.Close();
            }
        }
    }
}