using System;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 5.
    /// Unrestricted Upload of file with Dangerous Type
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class DangerFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<b>Hello! It's ok!</b>");

            if (Request.Files.Count > 0)
            {
                var hFile = Request.Files[0];
                if (hFile.ContentLength > 0)
                    hFile.SaveAs(@"C:\tmp\" + hFile.FileName);
            }

            //foreach (string file in Request.Files)
            //{
            //    var hFile = Request.Files[file] as HttpPostedFile;
            //    if (hFile.ContentLength > 0)
            //        hFile.SaveAs(@"C:\tmp\" + hFile.FileName);
            //}

        }
    }
}