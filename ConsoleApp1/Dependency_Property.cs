using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IAccounts
    {
        void AccountDetails();
    }

    class SavingAcc : IAccounts
    {
        public void AccountDetails()
        {
            Console.WriteLine("This Is my Saving Account");
        }
    }
    class CurrentAcc :IAccounts
    {
        public void AccountDetails()
        {
            Console.WriteLine("This is My Current Account");
        }
    }
                
    class Account1
    {
        public IAccounts accounts { get; set; }

        public void PrintAccount()
        {
            accounts.AccountDetails();
        }
    }
    class Dependency_Property
    {
        static void Main()
        {
            Account1 sa = new Account1();
            sa.accounts = new SavingAcc();
            sa.PrintAccount();

            Account1 ca = new Account1();
            ca.accounts = new CurrentAcc();
            ca.PrintAccount();
            Console.ReadLine();
        }
    }
}
