using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAndObjects
{
    class Bank
    {
        public string name;

        public int accNo;

        public string accType;
        public float balance;

        public void deposit(float amt)
        {
            balance += amt;
            Console.WriteLine("Balance:" + balance);
        }

        public void withdraw(float amt)
        {
            if (balance < amt)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= amt;
                Console.WriteLine("Balance:" + balance);
            }
                
            
        }
        public void display()
        {
            Console.WriteLine($"Name:{name}\nBalance:{balance}");
        }

        static void Main()
        {
            Bank bank = new Bank();
            bank.name = "Pallavi";
            bank.balance = 10000;
            bank.accNo = 1234;
            bank.accType = "Savings";

            bank.deposit(567);
            bank.withdraw(1000);
            bank.display();
        }

    }
}
