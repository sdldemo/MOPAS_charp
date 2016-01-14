using System;
using System.IO;

namespace Mopas.Tests
{
    /// <summary>
    /// 35.
    /// Improper check for Unusual or Exceptional Conditiions
    /// </summary>
    public partial class ImproperExceptionCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "test.log";

            //Open file
            try
            {
                FileStream fs = File.OpenRead(fileName);

                //...
                //Do something
                //...

                fs.Close();
            }
            catch (FileNotFoundException)
            {
                Response.Write("File not found");
                throw;
            }
        }
    }
}