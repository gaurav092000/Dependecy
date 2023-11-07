using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    interface IAccount
    {
        void PrintDetails();
    }

    class CurrentsAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is My Current Account");
        }
    }
    class SavingsAccount : IAccount
    {
       public  void PrintDetails()
        {
            Console.WriteLine("This is my saving Account");
        }
    }

    class Accounts
    {
        private IAccount iAccount;
        public Accounts(IAccount iAccount)
        {
            this.iAccount = iAccount;
        }
         
        public void AcccountDetails()
        {
            iAccount.PrintDetails();
        }

    }

    class DependencyConstructor
    {
        static void Main()
        {
            IAccount Iacc = new CurrentsAccount();
            Accounts acc = new Accounts(Iacc);
            acc.AcccountDetails();

            IAccount Iacc2 = new SavingsAccount();
            Accounts acc2 = new Accounts(Iacc2);
            acc2.AcccountDetails();

            Console.ReadLine();
        }
    }
}
