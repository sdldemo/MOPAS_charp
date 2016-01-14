using System;
using System.IO;

namespace Mopas.Tests
{
    /// <summary>
    /// 34.
    /// Detection of Error Condition Without Action
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class NoActionError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "test.log";

            try
            {
                //Open file
                FileStream fs = File.OpenRead(fileName);

                //.....
                //Do something
                //.....

                //Close file
                fs.Close();
            }
            catch (Exception)
            {
                //There is no error catching
                
                throw;
            }
        }
    }
}