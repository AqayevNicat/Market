using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister(100, Currency.USD);

            cashRegister.AddNewSale(56, Currency.TL);
            cashRegister.AddNewSale(100, Currency.USD);
            cashRegister.AddNewSale(30, Currency.AZN);

            Console.WriteLine(cashRegister);
        }
    }
}
