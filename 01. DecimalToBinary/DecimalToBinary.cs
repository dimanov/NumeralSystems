/*
 * Problem 1. Decimal to binary
 * Write a program to convert decimal numbers to their binary representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("This program converts decimal numbers to their binary representation. ");
        Console.Write("Please enter a decimal number \tn= ");
        int number = int.Parse(Console.ReadLine());

        CovertToBinary(number);
        Console.WriteLine();
    }

    private static void CovertToBinary(int number)
    {
        var binaryNumber = new List<int>();
        while (number > 0)
        {
            binaryNumber.Add(number % 2);
            number /= 2;
        }
        binaryNumber.Reverse();
        Console.Write("The binary representation of the number is: ");
        foreach (var digit in binaryNumber)
        {
            Console.Write(digit);
        }

    }
}