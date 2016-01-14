using System;
using System.IO;

namespace Mopas.Tests
{
    /// <summary>
    /// 11.
    /// Path Traversal
    /// MOPAS
    /// Contains 1 Vulnerability
    /// </summary>
    public partial class PathTraversal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = Request.Params["report"];

            if (fileName != null)
            {
                // TODO: AI issue #2, High, Arbitrary File Reading, https://github.com/sdldemo/MOPAS_charp/issues/2
                // GET /Tests/1 INPUT DATA VERIFICATION/11 Path Traversal/PathTraversal.aspx?report=Default.aspx HTTP/1.1
                // Host:localhost
                using (var file = new StreamReader("D:\\AI\\Reports\\" + fileName))
                {
                    string reportLines = "";
                    foreach (var line in file.ReadLine())
                    {
                        reportLines += line;
                    }

                    Response.Write("<b>Report:</b></br>" + reportLines);
                }
            }
        }
    }
}