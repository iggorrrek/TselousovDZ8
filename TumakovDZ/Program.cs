using System;


namespace TumakovDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2(); // надо доделать класс под второе задание
            Task3();
            Console.ReadKey();
        }
        static void Task1()
        {
            Console.WriteLine("Task number 1-------------------------------------------\n"); 

            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount(10000);
            BankAccount bankAccount3 = new BankAccount(20000, TypeSchet.tekushiy);
            bankAccount1.PrintBankAccount();
            bankAccount2.PrintBankAccount();
            bankAccount3.PrintBankAccount();
        }
        static void Task2()
        {
            Console.WriteLine("Task number 2--------------------------------------------\n");

            BankAccount bankAccount2 = new BankAccount(10000);
            BankAccount bankAccount3 = new BankAccount(20000, TypeSchet.tekushiy);
            BankAccount bankAccount4 = new BankAccount(10000);
            BankAccount bankAccount5 = new BankAccount(20000, TypeSchet.tekushiy);

            bankAccount2.Perevod(bankAccount3,1);
            bankAccount2.Perevod(bankAccount3, 1);
            bankAccount2.Perevod(bankAccount3, 1);
            bankAccount2.Perevod(bankAccount3, 1);
            bankAccount2.Perevod(bankAccount3, 1);
            bankAccount2.Perevod(bankAccount3, 1);
            bankAccount2.Perevod(bankAccount3, 1);
            bankAccount2.Perevod(bankAccount3, 1);

            Console.WriteLine("----");

            bankAccount5.PopolneniySam(5);
            bankAccount5.PopolneniySam(5);
            bankAccount5.PopolneniySam(5);
            bankAccount5.PopolneniySam(5);
            bankAccount5.PopolneniySam(5);

            Console.WriteLine("----");

            bankAccount5.SnyatieSam(50000);
            bankAccount5.SnyatieSam(50000);
            bankAccount5.SnyatieSam(50000);
            bankAccount5.SnyatieSam(50000);

            Console.WriteLine("----");

            bankAccount5.SnyatieSam(500);
            bankAccount5.SnyatieSam(500);
            bankAccount5.SnyatieSam(500);
            bankAccount5.SnyatieSam(500);
        }
        static void Task3()
        {
            Console.WriteLine("Task number 3-------------------------------------------\n");

            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount(10000);
            BankAccount bankAccount3 = new BankAccount(20000, TypeSchet.tekushiy);
            bankAccount1.PrintBankAccount();
            bankAccount2.PrintBankAccount();
            bankAccount3.PrintBankAccount();
        }
    }
}
