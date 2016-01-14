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
                using (var file = new StreamReader("D:\\AI\\Reports\\" + fileName))
                {
                    string reportLines = "";
                    foreach (var line in file.ReadLine())
                    {
                        reportLines += line;
                    }

                    // TODO: AI issue #3, High, Cross-site Scripting, https://github.com/sdldemo/MOPAS_charp/issues/3
                    // GET /Tests/1 INPUT DATA VERIFICATION/11 Path Traversal/PathTraversal.aspx?report=__AI_htprljortgejpry HTTP/1.1
                    // Host:localhost
                    // (System.IO.StreamReader.ReadLine().GetEnumerator().MoveNext() && (System.IO.StreamReader.ReadLine().GetEnumerator().Current == "<script>alert(0)</script>"))
                    Response.Write("<b>Report:</b></br>" + reportLines);
                }
            }
        }
    }
}