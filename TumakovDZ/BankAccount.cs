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
        public void Snyatie(decimal value)
        {
            balanceschet -= value;
        }
        public void Popolneniy(decimal value)
        {
            balanceschet += value;
        }
        private static int NovuyID()
        {
            return idCounter++;
        }
        public void PrintBankAccount()
        {
            Console.WriteLine($"\nНомер счета: {id}");
            Console.WriteLine($"Баланс: {balanceschet}");
            Console.WriteLine($"Тип счета: {typeschet}\n");
        }
    }
}
