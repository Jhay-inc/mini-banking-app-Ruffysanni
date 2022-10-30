using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccountNumber {get; set; }   
       
        public string EmailAddress { get; set; }
        public string PassWord { get; set; }
        public int TransactionPin { get; set; }

         public UserInfo( string emailAddress, string passWord)
        {
            //Name = name;
            //Surname = surname;
            //AccountNumber = accountNumber;
            EmailAddress = emailAddress;
            PassWord = passWord;
            //TransactionPin = transactionPin;
        }

        public void SayHello()
        {
            Console.WriteLine($"Welcome mr {Name} {Surname}.");


            Console.WriteLine($"Your account number and email is: {AccountNumber}, {EmailAddress}, and password {PassWord}");


        }
    }

    
}
