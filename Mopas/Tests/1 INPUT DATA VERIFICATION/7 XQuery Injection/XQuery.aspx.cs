using System;
using System.Xml;

namespace Mopas.Tests
{
    /// <summary>
    /// 7.
    /// XQueriy Injection
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class XQuery1 : System.Web.UI.Page
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
                    <roles>                        
                        <user name=""admin"" role=""0"">admin</item>
                        <user name=""user1"" role=""1"">privileged</item>
                        <user name=""user3"" role=""1"">privileged</item>
                        <user name=""user4"" role=""2"">common</item>
                        <user name=""user5"" role=""1"">privileged</item>
                    </roles>
            </root>";


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string role = Request.Params["role"];
            string result = "";
            
            if (role != null)
            {
                foreach (XmlNode target in doc.SelectNodes("/root/roles/role[@='" + role + "']"))
                {
                    result = result + (target != null ? target.InnerText : "No role " + role);
                }

                Response.Write(result);
            }

        }
    }
}