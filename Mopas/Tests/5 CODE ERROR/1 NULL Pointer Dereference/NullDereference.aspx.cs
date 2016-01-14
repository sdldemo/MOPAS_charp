using System;
using System.IO;

namespace Mopas.Tests
{
    /// <summary>
    /// 36.
    /// NULL Pointer dereference
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class NullDereference : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = Request.Params["file_name"];

            try
            {
                FileStream fs = File.OpenRead(fileName);

                //...
                //Do something
                //...

                fs.Close();

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}