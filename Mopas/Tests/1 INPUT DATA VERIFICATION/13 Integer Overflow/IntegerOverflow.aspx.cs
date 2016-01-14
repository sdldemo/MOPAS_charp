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

            Response.Write("Your appartment size is <b>" + size + "</b>");
        }
    }
}