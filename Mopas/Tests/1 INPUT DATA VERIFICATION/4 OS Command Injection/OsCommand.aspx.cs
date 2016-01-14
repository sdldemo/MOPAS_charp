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
            // TODO: AI issue #5, High, OS commanding, https://github.com/sdldemo/MOPAS_charp/issues/5
            // GET /Tests/1 INPUT DATA VERIFICATION/4 OS Command Injection/OsCommand.aspx?version=+%7c+whoami HTTP/1.1
            // Host:localhost
            myProcess.StartInfo = new ProcessStartInfo(@"C:\db\backup.bat", version);

            // TODO: AI issue #5, High, OS commanding, https://github.com/sdldemo/MOPAS_charp/issues/5
            // GET /Tests/1 INPUT DATA VERIFICATION/4 OS Command Injection/OsCommand.aspx HTTP/1.1
            // Host:localhost
            // (System.Diagnostics.Process == " | whoami")
            myProcess.Start();

            myProcess.Close();

        }
    }
}