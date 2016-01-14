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
                // TODO: AI issue #2, High, Arbitrary File Reading, https://github.com/sdldemo/MOPAS_charp/issues/2
                // GET /Tests/5 CODE ERROR/1 NULL Pointer Dereference/NullDereference.aspx?file_name=Default.aspx HTTP/1.1
                // Host:localhost
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