using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Accounts{
        public int accNo;
        public string name;
        public string accType;
        public char transactionType;
        public int balance;
        public int amt;

        public void show()
        {
            Console.WriteLine($"Account number:{accNo} Name:{name} Account Type:{accType}");
        }
        
        public int credit()
        {
            balance += amt;
            return balance;
        }

        public int debit()
        {
            balance -= amt;
            return balance;
        }
        static void Main()
        {
            Accounts acc = new Accounts();
            acc.accNo = 12345;
            acc.accType = "Savings";
            acc.name = "Aniket";
            acc.balance = 10000;
            Console.WriteLine("Enter transaction type(d/w):");
            acc.transactionType = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount:");
            acc.amt = int.Parse(Console.ReadLine());
            switch (acc.transactionType)
            {
                case 'w':
                    {
                        Console.WriteLine("balance:" + acc.debit());
                    }
                    break;
                case 'd':
                    {
                        Console.WriteLine("balance:" + acc.credit());
                    }
                    break;
                default:
                    Console.WriteLine("Enter d or w");
                    break;
            }
            acc.show();
        }
    }
}
