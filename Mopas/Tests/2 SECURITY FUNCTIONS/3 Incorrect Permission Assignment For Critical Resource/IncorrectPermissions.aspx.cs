using System;
using System.Diagnostics;
using System.IO;

namespace Mopas.Tests
{
    /// <summary>
    /// 15.
    /// Incorrect Permission Assignment for Critical Resource
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class IncorrectPermissions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = "..\\tmp\\";
            string fileName = Request.Params["fileName"];

            if (fileName == null)
                fileName = "test.txt";

            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

            //New proccess with vulnerable parameters
            File.Create(Path.Combine(filePath, fileName)).Close();

            myProcess.StartInfo = new ProcessStartInfo(@"cacls ", Path.Combine(filePath, fileName) + " /p apache:f");

            myProcess.Start();

            myProcess.Close();
        }
    }
}