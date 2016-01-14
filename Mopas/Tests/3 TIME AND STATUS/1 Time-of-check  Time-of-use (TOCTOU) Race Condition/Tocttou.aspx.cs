using System;
using System.IO;

namespace Mopas.Tests
{
    /// <summary>
    /// 31.
    /// Time of Check to Time of Use Race Condition
    /// MOPAS
    /// Contains 1 Vulnerability
    /// </summary>
    public partial class Tocttou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get file name
            string fileName = Request.Params["file_name"];

            //Check if file exists
            if (File.Exists(fileName))
            {
                //.... 
                //Do something
                //....

                //Open File
                FileStream fs = File.Open(fileName, FileMode.Open);

                //....
                //Do something
                //....

                //Close file
                fs.Close();

            }

        }
    }
}