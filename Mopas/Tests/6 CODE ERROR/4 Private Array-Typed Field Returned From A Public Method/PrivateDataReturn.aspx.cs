using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 41.
    /// Private Array-Typed Field Returned From A Public Method
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class PrivateDataReturn : System.Web.UI.Page
    {
        private string[] uniqueKey = new []{"ag7asghasLASl8g7g", "ahk8gkhbj78(SDHkh8hf"};

        protected void Page_Load(object sender, EventArgs e)
        {
            string needKey = Request.Params["get_key"];

            if (needKey.Equals("1"))
            {
                Response.Write(ReturnKey());
            }
        }

        public string[] ReturnKey()
        {
            return uniqueKey;
        }
    }
}