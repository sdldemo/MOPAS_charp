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
            
            // TODO: AI issue #3, High, Cross-site Scripting, https://github.com/sdldemo/MOPAS_charp/issues/3
            // GET /Tests/1 INPUT DATA VERIFICATION/3 Cross-site Scripting/Xss.aspx?name=%3cscript%3ealert(0)%3c%2fscript%3e HTTP/1.1
            // Host:localhost
            Response.Write("<b>Hello, " + name + "!</b>");
        }
    }
}