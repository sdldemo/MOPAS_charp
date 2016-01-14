using System;
using System.Xml;

namespace Mopas.Tests
{
    /// <summary>
    /// 8.
    /// XPath Injection
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class XQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml = @"<root>
                    <users>
                        <user name=""admin"">Admin</item>
                        <user name=""user1"">Peter</item>
                        <user name=""user3"">John</item>
                        <user name=""user4"">Alex</item>
                        <user name=""user5"">Mike</item>
                    </users>
                    <pass>                        
                        <user name=""admin"">@^6As^AEWagag</item>
                        <user name=""user1"">sdj|sffs</item>
                        <user name=""user3"">@#6ddhas</item>
                        <user name=""user4"">AGHLhngunADESG</item>
                        <user name=""user5"">mkAGNaUhgna</item>
                    </pass>
            </root>";


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string name = Request.Params["name"];

            if (name != null)
            {
                // TODO: AI issue #7, High, XPath Injection, https://github.com/sdldemo/MOPAS_charp/issues/7
                // GET /Tests/1 INPUT DATA VERIFICATION/8 XPath Injection/XPath.aspx?name=1%27+and+1%3d%271 HTTP/1.1
                // Host:localhost
                XmlNode target = doc.SelectSingleNode("/root/users/user[@name='" + name + "']");
                string result = target != null ? target.InnerText : "No user " + name;
                Response.Write(result);
            }

        }
    }
}