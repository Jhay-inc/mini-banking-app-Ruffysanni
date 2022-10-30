using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Database
    {
        public Database()
        {
            BankCustomers = new List<BankCustomer>()
            {
                new BankCustomer("ademola@thebulb.africa", "dgtughkchg")
                {
                    Name = "Ademola",
                    Surname = "Balogun",
                    AccountNumber = new UserInfo(8000)
                },
                new BankCustomer("collin@thebulb.africa", "dgtughkchg")
                {
                    Name = "Collins",
                    Surname = "Usman",
                    AccountNumber = new UserInfo(2000)
                },
                new BankCustomer("malikhi@gmail.africa", "dgtughkchg")
                {
                    Name = "malik",
                    Surname = "Chibuzor",
                    AccountNumber = new UserInfo(12000)
                },
                new BankCustomer("ademola@thebulb.africa", "dgtughkchg")
                {
                    Name = "Corde",
                    Surname = "Manchi",
                    AccountNumber = new UserInfo(45000)
                },
                new BankCustomer("ademola@thebulb.africa", "dgtughkchg")
                {
                    Name = "Ibukun",
                    Surname = "Mary",
                    AccountNumber = new UserInfo(3000)
                },
            };

                
        }
        public List<BankCustomer> BankCustomers;

    }
    
}
