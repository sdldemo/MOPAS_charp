using System;

namespace Mopas.Tests
{
    public partial class Recursion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n = 1;
            int.TryParse(Request.Params["first_number"], out n);

            //Call factorial calculation
            int result = FactorialCalc(n);
            Response.Write("");
        }

        public int FactorialCalc(int n)
        {
            return n*FactorialCalc(n - 1);
        }
    }
}