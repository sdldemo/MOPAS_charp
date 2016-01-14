using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 38.
    /// Exposure of Data Element to Wrong Session
    /// MOPAS
    /// Contains 1 vulnerability
    /// Using Cache to get var in multiple pages
    /// </summary>
    public partial class WrongSession : System.Web.UI.Page
    {
        private static String name = "";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (Page.Cache.Get("name") == null)
                {
                    Page.Cache.Insert("name", name);
                }
                else
                {
                    name = Page.Cache["name"].ToString();
                }
            }
            
            Response.Write(name);
        }
    }
}