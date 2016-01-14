using System;
using System.Net;

namespace Mopas.Tests
{
    /// <summary>
    /// 43.
    /// Reliance on DNS Lookups in a Security Decision
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class DnsLookup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string remoteAddress = "85.215.188.44";
            bool trusted = false;

            IPAddress hostIPAddress = IPAddress.Parse(remoteAddress);
            IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
            if (hostInfo.HostName.EndsWith("trustme.com"))
            {
                trusted = true;
            }
        }
    }
}