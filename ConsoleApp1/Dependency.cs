using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CurrentAcount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is my Current Account");
        }
    }
    class SavingAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is my Saving Account");
        }
    }
    class Account
    {
        CurrentAcount ca = new CurrentAcount();
        SavingAccount sa = new SavingAccount();
        public void PrintDetailsAccount()
        {
            ca.PrintDetails();
            sa.PrintDetails();
        }
    }

    class Dependency
    {
        static void Main()
        {
            Account a = new Account();
            a.PrintDetailsAccount();
            Console.ReadLine();
        }
    }
}
 