using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class CashRegister
    {
        public double TotalAmount { get; set; }
        public static int TotalSalesCount { get; set; }
        public Currency Currency { get; set; }
        public string currName { get; set; }
        public PaymentType PaymentType { get; set; }

        public CashRegister(double totalamount,Currency currency,PaymentType paymentType)
        {
            TotalAmount = totalamount;
            Currency = currency;
            PaymentType = paymentType;
            switch ((int)Currency)
            {
                case 0:
                    currName = "AZN";
                    break;
                case 1:
                    currName = "TL";
                    break;
                case 2:
                    currName = "USD";
                    break;
                default:
                    break;
            }
            switch ((int)PaymentType)
            {
                case 0:
                    currName = "AZN";
                    break;
                case 1:
                    currName = "TL";
                    break;
                case 2:
                    currName = "USD";
                    break;
                default:
                    break;
            }
            TotalSalesCount++;
        }
        public void AddNewSale(double mebleg, Currency currency1)
        {
            string currn1 = "";
            if(Currency == currency1)
            {
                TotalAmount += mebleg;
            }
            else
            {
                switch ((int)currency1)
                {
                    case 0:
                        currn1 = "AZN";
                        if (currName == "TL")
                        {
                            mebleg *= 8;
                        }
                        else if (currName == "USD")
                        {
                            mebleg /= 2;
                        }
                        break;
                    case 1:
                        currn1 = "TL";
                        if (currName == "AZN")
                        {
                            mebleg /= 8;
                        }
                        else if (currName == "USD")
                        {
                            mebleg /= 14;
                        }
                        break;
                    case 2:
                        currn1 = "USD";
                        if (currName == "TL")
                        {
                            mebleg *= 14;
                        }
                        else if (currName == "AZN")
                        {
                            mebleg *= 2;
                        }
                        break;
                    default:
                        break;
                }
                TotalAmount += mebleg;
            }
        }
        public void RemoveSale(double mebleg, Currency currency1)
        {
            string currn1 = "";
            if (Currency == currency1)
            {
                TotalAmount -= mebleg;
            }
            else
            {
                switch ((int)currency1)
                {
                    case 0:
                        currn1 = "AZN";
                        if (currName == "TL")
                        {
                            mebleg *= 8;
                        }
                        else if (currName == "USD")
                        {
                            mebleg /= 2;
                        }
                        break;
                    case 1:
                        currn1 = "TL";
                        if (currName == "AZN")
                        {
                            mebleg /= 8;
                        }
                        else if (currName == "USD")
                        {
                            mebleg /= 14;
                        }
                        break;
                    case 2:
                        currn1 = "USD";
                        if (currName == "TL")
                        {
                            mebleg *= 14;
                        }
                        else if (currName == "AZN")
                        {
                            mebleg *= 2;
                        }
                        break;
                    default:
                        break;
                }
                TotalAmount -= mebleg;
            }
        }
        public override string ToString()
        {

            return $"TotalAmount : {TotalAmount} {currName}\n" +
                $"Odenisin novu : {PaymentType}\n" +
                $"Satisin sayi : {TotalSalesCount}\n----------------------";
        }
    }
}
