/*
 * Problem 6. Binary to hexadecimal
 * Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinToHex
{
    static void Main()
    {
        Console.WriteLine("This program converts binary numbers to their hexadecimal representation. ");
        Console.Write("Please enter a binary number \tn= ");
        string strNumber = Console.ReadLine();
        CovertBinToHex(strNumber);
        Console.WriteLine();
    }

    private static void CovertBinToHex(string strNumber)
    {
        //var digitsList = strNumber.Select(digit => (digit.ToString())).ToList();
        int addZero = strNumber.Length % 4;

        string reversedNumbner = new string(strNumber.Reverse().ToArray());
        Console.WriteLine(reversedNumbner);

        StringBuilder sb = new StringBuilder(reversedNumbner);

        var parsedBin = sb.Append('0', addZero);

        Console.WriteLine(parsedBin);
        var binNumber = new List<string>();
        var hexNumber = new Stack<string>();
        //foreach (var digit in strNumber)
        //{
        //    Console.Write(digit);
        //}

         
        for (var i = 0; i < parsedBin.Length - 3; i += 4)
        {
            binNumber.Add(parsedBin.ToString().Substring(i, 4));
        }
        foreach (var digit in binNumber)
        {
            Console.WriteLine(digit);
        }
        bool binDigit = true;
        for (int i = 0; i < binNumber.Count; i++)
        {
            switch (binNumber[i])
            {
                case "0000": hexNumber.Push("0"); break;
                case "0001": hexNumber.Push("1"); break;
                case "0010": hexNumber.Push("2"); break;
                case "0011": hexNumber.Push("3"); break;
                case "0100": hexNumber.Push("4"); break;
                case "0101": hexNumber.Push("5"); break;
                case "0110": hexNumber.Push("6"); break;
                case "0111": hexNumber.Push("7"); break;
                case "1000": hexNumber.Push("8"); break;
                case "1001": hexNumber.Push("9"); break;
                case "1010": hexNumber.Push("A"); break;
                case "1011": hexNumber.Push("B"); break;
                case "1100": hexNumber.Push("C"); break;
                case "1101": hexNumber.Push("D"); break;
                case "1110": hexNumber.Push("E"); break;
                case "1111": hexNumber.Push("F"); break;
                default: Console.WriteLine("Not a valid binary number"); binDigit = false; break;
            }
            if (!binDigit)
            {
                return;
            }
        }

        Console.Write("The hexadecimal representation of the number is: ");


        foreach (var item in hexNumber)
        {
            Console.Write(item);
        }
    }
}