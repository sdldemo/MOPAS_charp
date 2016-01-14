using System;
using System.Collections.Generic;
using System.Web;

namespace Mopas.Tests
{
    /// <summary>
    /// 16.
    /// Improper Authorization
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class ImproperAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> messagesList = new Dictionary<int, string>();

            messagesList.Add(0, "Test");
            messagesList.Add(1, "Test1");
            messagesList.Add(2, "Test2");
            messagesList.Add(3, "Test3");
            
            //Get id from session
            HttpContext context = HttpContext.Current;

            int messageId = (int) context.Session["message_id"];
            
            //Write text of message with selected id
            Response.Write(messagesList[messageId]);
        }
    }
}