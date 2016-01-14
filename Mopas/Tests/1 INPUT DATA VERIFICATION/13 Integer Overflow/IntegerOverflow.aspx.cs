using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 13.
    /// Integer overflow
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class IntegerOverflow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int width = int.Parse(Request.Params["width"]);
            int height = int.Parse(Request.Params["height"]);

            int size = width*height;

            // TODO: AI issue #3, High, Cross-site Scripting, https://github.com/sdldemo/MOPAS_charp/issues/3
            // GET /Tests/1 INPUT DATA VERIFICATION/13 Integer Overflow/IntegerOverflow.aspx HTTP/1.1
            // Host:localhost
            // ((System.Int32.Parse(this.Request.Params["width"]) * System.Int32.Parse(this.Request.Params["height"])) == "<script>alert(0)</script>")
            Response.Write("Your appartment size is <b>" + size + "</b>");
        }
    }
}