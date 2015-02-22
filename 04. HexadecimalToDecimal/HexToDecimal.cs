/*
 * Problem 4. Hexadecimal to decimal
 * Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts hexadecimal numbers to their decimal representation. ");
        Console.Write("Please enter a hexadecimal number \tn= ");
        string strNumber = Console.ReadLine();
        double systemBase = 16;
        CovertHexToDecimal(strNumber, systemBase);
    }

    private static void CovertHexToDecimal(string strNumber, double systemBase)
    {
        var digitsList = strNumber.Select(digit => (digit.ToString())).ToList();
        digitsList.Reverse();
        double sum = 0;
        double multiplier = 1;
        bool hexDigit = true;
        for (int i = 0; i < digitsList.Count; i++)
        {
            //Console.Write(symbol);
            switch (digitsList[i])
            {
                case "1": multiplier = 1; break;
                case "2": multiplier = 2; break;
                case "3": multiplier = 3; break;
                case "4": multiplier = 4; break;
                case "5": multiplier = 5; break;
                case "6": multiplier = 6; break;
                case "7": multiplier = 7; break;
                case "8": multiplier = 8; break;
                case "9": multiplier = 9; break;
                case "A": multiplier = 10; break;
                case "a": multiplier = 10; break;
                case "B": multiplier = 11; break;
                case "b": multiplier = 11; break;
                case "C": multiplier = 12; break;
                case "c": multiplier = 12; break;
                case "D": multiplier = 13; break;
                case "d": multiplier = 13; break;
                case "E": multiplier = 14; break;
                case "e": multiplier = 14; break;
                case "F": multiplier = 15; break;
                case "f": multiplier = 15; break;
                default: Console.WriteLine("Not a valid hexadecimal number"); hexDigit = false; break;
            }
            if (hexDigit)
            {
                sum += multiplier * Math.Pow(systemBase, i);
            }
            else
            {
                return;
            }
        }
        Console.WriteLine("The decimal representation of the number is: {0}", sum);




        //{

        //    //Console.WriteLine("{0} * {1}", digitsList[i], Math.Pow(systemBase, i));
        //    
        //}

    }
}