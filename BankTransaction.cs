using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class BankTransaction
    {
        private double accountBalance;

        public BankTransaction(double v, double depositAdded)
        {
            DepositAdded = depositAdded;
        }

        double AccountBalance {get; set;} = 1000.00;
        double AmountWithdrawal {get; set;}
        double DepositAdded {get; set;}


        
        public double depositMoney(double depositdAdded)
        {

            AccountBalance = accountBalance;
            DepositAdded = depositdAdded;

            

            return accountBalance + depositdAdded;

        }

        public double Withdrawal(double amountWithdrawal)
        {
            AmountWithdrawal = amountWithdrawal;
            accountBalance = 1000;
            if (accountBalance == 1000)
                {
                    Console.WriteLine($"Unable to withdraw from the account because of minimum limit...");
                }
                else
                {
                    accountBalance = accountBalance - amountWithdrawal;
                    return accountBalance;
                }
        }
    }

}
