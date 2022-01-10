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


        public CashRegister(double totalamount,Currency currency)
        {
            TotalAmount = totalamount;
            Currency = currency;
            switch ((int)Currency)
            {
                case 0:
                    currName = "AZN";
                    break;
                case 1:
                    currName = "USD";
                    break;
                case 2:
                    currName = "USD";
                    break;
                default:
                    break;
            }
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
                //1-ci yazilis---->
                #region
                //switch ((int)currency1)
                //{
                //    case 0:
                //        currn1 = "AZN";
                //        if (currName == "TL")
                //        {
                //            mebleg *= 8;
                //        }
                //        else if (currName == "USD")
                //        {
                //            mebleg /= 2;
                //        }
                //        break;
                //    case 1:
                //        currn1 = "TL";
                //        if (currName == "AZN")
                //        {
                //            mebleg /= 8;
                //        }
                //        else if (currName == "USD")
                //        {
                //            mebleg /= 14;
                //        }
                //        break;
                //    case 2:
                //        currn1 = "USD";
                //        if (currName == "TL")
                //        {
                //            mebleg *= 14;
                //        }
                //        else if (currName == "AZN")
                //        {
                //            mebleg *= 2;
                //        }
                //        break;
                //    default:
                //        break;
                //}
                #endregion
                //1-ci yazilis <-----


                //2-ci yazilis---->
                switch (Currency)
                {
                    case Currency.AZN:
                        switch (currency1)
                        {
                            case Currency.TL:
                                mebleg /= 8;
                                break;
                            case Currency.USD:
                                mebleg *= 2;
                                break;
                            default:
                                break;
                        }
                        break;
                    case Currency.TL:
                        switch (currency1)
                        {
                            case Currency.AZN:
                                mebleg *= 8;
                                break;
                            case Currency.USD:
                                mebleg *= 14;
                                break;
                            default:
                                break;
                        }
                        break;
                    case Currency.USD:
                        switch (currency1)
                        {
                            case Currency.AZN:
                                mebleg /= 2;
                                break;
                            case Currency.TL:
                                mebleg /= 14;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                //2-ci yazilis <-----


                TotalAmount += mebleg;
            }
            TotalSalesCount++;
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
                //1-ci yazilis---->
                #region
                //switch ((int)currency1)
                //{
                //    case 0:
                //        currn1 = "AZN";
                //        if (currName == "TL")
                //        {
                //            mebleg *= 8;
                //        }
                //        else if (currName == "USD")
                //        {
                //            mebleg /= 2;
                //        }
                //        break;
                //    case 1:
                //        currn1 = "TL";
                //        if (currName == "AZN")
                //        {
                //            mebleg /= 8;
                //        }
                //        else if (currName == "USD")
                //        {
                //            mebleg /= 14;
                //        }
                //        break;
                //    case 2:
                //        currn1 = "USD";
                //        if (currName == "TL")
                //        {
                //            mebleg *= 14;
                //        }
                //        else if (currName == "AZN")
                //        {
                //            mebleg *= 2;
                //        }
                //        break;
                //    default:
                //        break;
                //}
                #endregion
                //1-ci yazilis <-----


                //2-ci yazilis---->
                switch (Currency)
                {
                    case Currency.AZN:
                        switch (currency1)
                        {
                            case Currency.TL:
                                mebleg /= 8;
                                break;
                            case Currency.USD:
                                mebleg *= 2;
                                break;
                            default:
                                break;
                        }
                        break;
                    case Currency.TL:
                        switch (currency1)
                        {
                            case Currency.AZN:
                                mebleg *= 8;
                                break;
                            case Currency.USD:
                                mebleg *= 14;
                                break;
                            default:
                                break;
                        }
                        break;
                    case Currency.USD:
                        switch (currency1)
                        {
                            case Currency.AZN:
                                mebleg /= 2;
                                break;
                            case Currency.TL:
                                mebleg /= 14;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                //2-ci yazilis <-----
                TotalAmount -= mebleg;
            }
            TotalSalesCount--;
        }
        public override string ToString()
        {

            return $"TotalAmount : {TotalAmount} {currName}\n" +
                $"Gunluk Satisin sayi : {TotalSalesCount}\n----------------------";
        }
    }
}
