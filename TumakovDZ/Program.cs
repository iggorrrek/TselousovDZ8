using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.ReadKey();
        }
        static void Task1()
        {
            Console.WriteLine("Task number 1\n"); 
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount(10000);
            BankAccount bankAccount3 = new BankAccount(20000, TypeSchet.tekushiy);
            bankAccount1.PrintBankAccount();
            bankAccount2.PrintBankAccount();
            bankAccount3.PrintBankAccount();
        }
    }
}
