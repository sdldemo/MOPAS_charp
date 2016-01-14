using System;
using System.Diagnostics;

namespace Mopas.Tests
{
    public partial class OsCommand : System.Web.UI.Page
    {
        /// <summary>
        /// 4.
        /// Os Command Injection
        /// MOPAS
        /// Contains 1 vulnerability
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string version = Request.Params["version"];
            
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

            //New proccess with vulnerable parameters
            myProcess.StartInfo = new ProcessStartInfo(@"C:\db\backup.bat", version);

            myProcess.Start();

            myProcess.Close();

        }
    }
}