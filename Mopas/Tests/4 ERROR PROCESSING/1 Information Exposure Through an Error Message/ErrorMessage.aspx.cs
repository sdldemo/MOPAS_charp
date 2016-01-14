using System;
using System.Net;

namespace Mopas.Tests
{
    /// <summary>
    /// 33.
    /// Information Exposure Through an Error Message
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class ErrorMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = "http://ptsecurity.com";

            try
            {
                //Request the url
                WebRequest myWebRequest = WebRequest.Create(url);

                //Get response from site
                WebResponse myWebResponse = myWebRequest.GetResponse();
            }
            catch (Exception ex)
            {
                Response.Write(ex.StackTrace);
                throw;
            }
        }
    }
}