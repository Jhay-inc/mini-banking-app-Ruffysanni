using System;
using System.Net.Mail;

namespace BankingApplication
{
    public class Program
    {
        public void Main(string[] args)
        {
            UserInfo userInfo = new UserInfo("julian", "Maxwell", 23461527, "lucas@gmail.com", "dswu67", 2525);

            BankTransaction bankTransaction = new BankTransaction(double depositAdded);
            bankTransaction.depositMoney(23000.78);
            
            double depositAdded;

            //Email Validation

            bool isValid(string emailAddress)
            {
                try
                {
                    MailAddress m = new MailAddress(emailAddress);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }

        }
        
    }
}
