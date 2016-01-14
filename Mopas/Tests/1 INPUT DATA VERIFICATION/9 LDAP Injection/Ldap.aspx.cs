using System;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace Mopas.Tests
{
    /// <summary>
    /// 9.
    /// LADP Injection
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class Ldap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DirectoryContext dc = new DirectoryContext(DirectoryContextType.Domain, "ptsecurity.ru");

            string address = Request.Params["address"];
            string filter = "Address=" + address;
            string result = "";

            Domain domain = Domain.GetDomain(dc);

            DirectorySearcher ds = new DirectorySearcher(domain.GetDirectoryEntry(), filter);
            using (SearchResultCollection src = ds.FindAll())
            {
                foreach (var res in src)
                {
                    result = res.ToString();
                }
            }

            Response.Write(result);
        }
    }
}