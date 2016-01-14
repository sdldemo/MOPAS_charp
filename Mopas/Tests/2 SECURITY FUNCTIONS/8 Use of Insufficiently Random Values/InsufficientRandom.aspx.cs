using System;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 22.
    /// Use of Insufficient Random Values
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class InsufficientRandom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = "";

            Random rand = new Random();

            //Generate random id for user
            id = rand.Next().ToString();

            //Set session param with new id
            HttpContext context = HttpContext.Current;

            context.Session["name_id"] = id;

            Response.Write("User name_ID:" + id);
        }
    }
}