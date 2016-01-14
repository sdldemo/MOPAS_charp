using System;
using System.IO;

namespace Mopas.Tests
{
    /// <summary>
    /// 40.
    /// Exposure of System Data to an Unauthorized Control Sphere
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class ExposureSystemData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "test.log";

            try
            {
                FileStream fs = File.OpenRead(fileName);

                //Do something

                fs.Close();
            }
            catch (Exception ex)
            {
                //Write text of exception if it occurs
                Response.Write(ex.Message);
                throw;
            }
        }
    }
}