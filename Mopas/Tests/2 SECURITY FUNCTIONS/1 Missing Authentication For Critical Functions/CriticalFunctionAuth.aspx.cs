using System;

namespace Mopas.Tests
{
    /// <summary>
    /// 15.
    /// Missing Authentication For Critical Functions
    /// MOPAS
    /// Contains 1 vulnerability
    /// </summary>
    public partial class CriticalFunctionAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public BankAccount createBankAccount(String accountNumber, String accountType,
        String accountName, String accountSSN, double balance)
        {

            BankAccount account = new BankAccount();
            account.Number = accountNumber;
            account.Type = accountType;
            account.Name = accountName;
            account.SSN = accountSSN;
            account.Balance = balance;

            return account;
        }

        public class BankAccount
        {
            // TODO: Вернуть назад после исправления ошибки в инструментации свойств

            //private double accountbalance;
            //private string accountNumber, accountSSN, accountName, accountType;
            //public string Number {
            //    get { return accountNumber; }
            //    set { accountNumber = value; }
            //}
            //public string SSN {      
            //    get { return accountSSN; }
            //    set { accountSSN = value; }
            //}
            //public double Balance {      
            //    get { return accountbalance; }
            //    set { accountbalance = value; }
            //}
            //public string Name {
            //    get { return accountName; }
            //    set { accountName = value; }
            //}
            //public string Type {      
            //    get { return accountType; }
            //    set { accountType = value; }
            //}

            public string Number;
            public string SSN;
            public double Balance;
            public string Name;
            public string Type;

        }
    }
}