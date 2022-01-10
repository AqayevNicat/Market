using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cash = new CashRegister(3,Enums.Currency.USD,Enums.PaymentType.CARD);
            cash.AddNewSale(16, Enums.Currency.TL);
            cash.RemoveSale(8, Enums.Currency.TL);
            Console.WriteLine(cash);
        }
    }
}
