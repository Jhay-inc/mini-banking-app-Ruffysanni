using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
        public class BankAccount(double depositAdded)
        {
            AccountBalance = 1000 + depositAdded;

            //string accountNumber = "";
            //string firstTwo = "09";
            //string nextSix = DateTime.Now.ToString("yyMMdd");

            //string LastTwo = new Random().Next(99).ToString().PadLeft(2, '0');
            //accountNumber = firstTwo + nextSix + LastTwo;

            //AccountNumber = accountNumber;
            accountNumber = $"09{DateTime.Now.ToString("yyMMdd")}{new Random().Next(99).ToString().PadLeft(2, '0')}";
            Console.WriteLine($"{accountNumber}");
        }

            public string AccountNumber { get; set; }
            double AccountBalance { get; set; } = 1000.00;
            double DepositAdded { get; set; }
            
}
