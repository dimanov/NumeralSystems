/*
 * Problem 5. Hexadecimal to binary
 * Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

using System;
using System.Collections.Generic;
using System.Linq;

class HexToBinary
{
    static void Main()
    {
        Console.WriteLine("This program converts hexadecimal numbers to their binary representation. ");
        Console.Write("Please enter a hexadecimal number \tn= ");
        string strNumber = Console.ReadLine();
        //double systemBase = 16;
        CovertHexToBinary(strNumber);
        Console.WriteLine();
    }

    private static void CovertHexToBinary(string strNumber)
    {
        var digitsList = strNumber.Select(digit => (digit.ToString())).ToList();
        var binNumber = new List<string>();

        bool hexDigit = true;
        for (int i = 0; i < digitsList.Count; i++)
        {
            switch (digitsList[i])
            {
                case "0": binNumber.Add("0000"); break;
                case "1": binNumber.Add("0001"); break;
                case "2": binNumber.Add("0010"); break;
                case "3": binNumber.Add("0011"); break;
                case "4": binNumber.Add("0100"); break;
                case "5": binNumber.Add("0101"); break;
                case "6": binNumber.Add("0110"); break;
                case "7": binNumber.Add("0111"); break;
                case "8": binNumber.Add("1000"); break;
                case "9": binNumber.Add("1001"); break;
                case "A": binNumber.Add("1010"); break;
                case "a": binNumber.Add("1010"); break;
                case "B": binNumber.Add("1011"); break;
                case "b": binNumber.Add("1011"); break;
                case "C": binNumber.Add("1100"); break;
                case "c": binNumber.Add("1100"); break;
                case "D": binNumber.Add("1101"); break;
                case "d": binNumber.Add("1101"); break;
                case "E": binNumber.Add("1110"); break;
                case "e": binNumber.Add("1110"); break;
                case "F": binNumber.Add("1111"); break;
                case "f": binNumber.Add("1111"); break;
                default: Console.WriteLine("Not a valid hexadecimal number"); hexDigit = false; break;
            }
            if (!hexDigit)
            {
                return;
            }
        }

        Console.Write("The binary representation of the number is: ");
        foreach (var item in binNumber)
        {
            Console.Write(item);
        }
    }
}