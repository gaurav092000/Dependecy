using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Iaccount
    {
        void PrintDetails();
    }

    class Savingaccounts : Iaccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is my Saving Account");
        }

    }

    class Currentaccount : Iaccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is MY current Account");
        }
    }

    class Accountss
    {
        public void Print(Iaccount ac)
        {
            ac.PrintDetails();
        }
    }
    class Dependency_Method
    {
        static void Main()
        {
            Accountss ac1 = new Accountss();
            ac1.Print(new Savingaccounts());

            Accountss ac2 = new Accountss();
            ac2.Print(new Currentaccount());
            Console.ReadLine();

        }
    }
}
