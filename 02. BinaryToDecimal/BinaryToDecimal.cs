/*
 * Problem 2. Binary to decimal
 * Write a program to convert binary numbers to their decimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts binary numbers to their decimal representation. ");
        Console.Write("Please enter a binary number \tn= ");
        string strNumber = Console.ReadLine();
        double systemBase = 2;
        CovertToDecimal(strNumber, systemBase);

    }

    private static void CovertToDecimal(string strNumber, double systemBase)
    {
        var digitsList = strNumber.Select(digit => int.Parse(digit.ToString())).ToList();
        digitsList.Reverse();
        double sum = 0;

        for (int i = 0; i < digitsList.Count; i++)
        {

            //Console.WriteLine("{0} * {1}", digitsList[i], Math.Pow(systemBase, i));
            sum += digitsList[i] * Math.Pow(systemBase, i);
        }
        Console.WriteLine("The decimal representation of the number is: {0}", sum);

    }
}