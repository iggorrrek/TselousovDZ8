using System;


namespace TumakovDZ
{
    public class BankAccount
    {
        private static int idCounter = 1;
        public int id { get; }
        public decimal balanceschet { get; set; }
        private TypeSchet typeschet { get; set; }
        public BankAccount()
        {
            balanceschet = 0;
            typeschet = TypeSchet.obshiy;
            id = NovuyID();

        }
        public BankAccount(decimal a)
        {
            balanceschet = a;
            typeschet = TypeSchet.obshiy;
            id = NovuyID();
        }
        public BankAccount(decimal a, TypeSchet b)
        {
            balanceschet = a;
            typeschet = b;
            id = NovuyID();
        }
        private void Snyatie(decimal value)
        {
            balanceschet -= value;
        }
        public void SnyatieSam(decimal value)
        {
            if (balanceschet > value)
            {
                balanceschet -= value;
                BankTransaction schetperev = new BankTransaction();
                Console.WriteLine($"Количество операций:{BankTransaction.GetTransactionCount()}");
            }
            else
            {
                Console.WriteLine("Вы не можете снять, вам не хватает денег на счету...");
            }
        }
        private void Popolneniy(decimal value)
        {
            balanceschet += value;
        }
        public void PopolneniySam(decimal value)
        {
            balanceschet += value;
            BankTransaction schetperev = new BankTransaction();
            Console.WriteLine($"Количество операций:{BankTransaction.GetTransactionCount()}");
        }
        private static int NovuyID()
        {
            return idCounter++;
        }
        public bool Perevod(BankAccount toAccount, decimal summa)
        {

            if (summa > balanceschet)
            {
                Console.WriteLine("Недостаточно средств.");
                return false;
            }
            BankTransaction schetperev = new BankTransaction();
            Console.WriteLine($"Количество операций:{BankTransaction.GetTransactionCount()}");
            Snyatie(summa);
            toAccount.Popolneniy(summa);
            return true;
        }
        //static void Dispose();
        //{

        //}
        public void PrintBankAccount()
        {
            Console.WriteLine($"\nНомер счета: {id}");
            Console.WriteLine($"Баланс: {balanceschet}");
            Console.WriteLine($"Тип счета: {typeschet}\n");
        }
    }
}
