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

                    Response.Write("<b>Report:</b></br>" + reportLines);
                }
            }
        }
    }
}