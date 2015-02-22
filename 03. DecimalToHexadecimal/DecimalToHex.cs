/*
 * Problem 3. Decimal to hexadecimal
 * Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToHex
{
    static void Main()
    {
        Console.WriteLine("This program converts decimal numbers to their hexadecimal representation. ");
        Console.Write("Please enter a decimal number \tn= ");
        long number = long.Parse(Console.ReadLine());
        int systemBase = 16;
        CovertToHex(number, systemBase);
        Console.WriteLine();
    }

    private static void CovertToHex(long number, int systemBase)
    {
        var hexNumber = new List<string>();
        long currDigit;
        while (number > 0)
        {
            currDigit = number % systemBase;

            switch (currDigit)
            {
                case 10: hexNumber.Add("A"); break;
                case 11: hexNumber.Add("B"); break;
                case 12: hexNumber.Add("C"); break;
                case 13: hexNumber.Add("D"); break;
                case 14: hexNumber.Add("E"); break;
                case 15: hexNumber.Add("F"); break;
                default: hexNumber.Add(Convert.ToString(currDigit)); break;
            }
            number /= systemBase;
        }
        hexNumber.Reverse();
        Console.Write("The hexadecimal representation of the number is: ");
        foreach (var symbol in hexNumber)
        {
            Console.Write(symbol);
        }
    }
}