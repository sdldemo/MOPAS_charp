using System;

namespace Mopas.Tests
{
    public partial class Xss : System.Web.UI.Page
    {
        /// <summary>
        /// 3.
        /// Cross-Site Scripting
        /// MOPAS
        /// Contains 1 vulnerability
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Params["name"];
            //string name = Request.Params["name"];  //Request.Unvalidated().Params["name"];
            
            Response.Write("<b>Hello, " + name + "!</b>");
        }
    }
}