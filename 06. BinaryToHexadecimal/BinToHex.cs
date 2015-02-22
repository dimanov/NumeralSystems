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
        int addZero = strNumber.Length % 4;

        StringBuilder sb = new StringBuilder(strNumber);

        while (addZero > 0)
        {
            sb.Insert(0, '0');
            addZero--;
        }

        var binNumber = new List<string>();
        var hexNumber = new Queue<string>();

        for (var i = 0; i < sb.Length - 3; i += 4)
        {
            binNumber.Add(sb.ToString().Substring(i, 4));
        }

        bool binDigit = true;
        for (int i = 0; i < binNumber.Count; i++)
        {
            switch (binNumber[i])
            {
                case "0000": hexNumber.Enqueue("0"); break;
                case "0001": hexNumber.Enqueue("1"); break;
                case "0010": hexNumber.Enqueue("2"); break;
                case "0011": hexNumber.Enqueue("3"); break;
                case "0100": hexNumber.Enqueue("4"); break;
                case "0101": hexNumber.Enqueue("5"); break;
                case "0110": hexNumber.Enqueue("6"); break;
                case "0111": hexNumber.Enqueue("7"); break;
                case "1000": hexNumber.Enqueue("8"); break;
                case "1001": hexNumber.Enqueue("9"); break;
                case "1010": hexNumber.Enqueue("A"); break;
                case "1011": hexNumber.Enqueue("B"); break;
                case "1100": hexNumber.Enqueue("C"); break;
                case "1101": hexNumber.Enqueue("D"); break;
                case "1110": hexNumber.Enqueue("E"); break;
                case "1111": hexNumber.Enqueue("F"); break;
                default: Console.WriteLine("Not a valid binary number"); binDigit = false; break;
            }
            if (!binDigit)
            {
                return;
            }
        }

        Console.Write("The hexadecimal representation of the number is: ");

        while (true)
        {
            if (hexNumber.Count == 0)
            {
                break;
            }
            Console.Write(hexNumber.Dequeue());
        }
    }
}