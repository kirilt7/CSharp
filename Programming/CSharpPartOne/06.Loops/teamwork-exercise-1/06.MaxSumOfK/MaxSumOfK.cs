﻿using System;
using System.Collections.Generic;

class MaxSumOfK
{
    static void Main()
    {
        int n = 2;
        int k = 0;

        Console.Write("Enter the lenght of the input array AAAAAAAA: ");
        do
        {

        } while (!int.TryParse(Console.ReadLine(), out n));

        Console.Write("Enter the number of elements to sum: ");
        do
        {

        } while (!int.TryParse(Console.ReadLine(), out k));

        int[] arraySum = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Value for {0} element: ", i);
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out arraySum[i]));
        }

        Array.Sort(arraySum);

        int maxSum = 0;

        for (int i = arraySum.Length - 1; i >= (arraySum.Length - k); i--)
        {
            maxSum += arraySum[i];
        }

        Console.WriteLine("The maximum sum of {0} elements is: {1}", k, maxSum);
        Console.Write("{");
        for (int i = arraySum.Length - 1; i >= (arraySum.Length - k); i--)
        {
            Console.Write("{0},", arraySum[i]);
        }
        Console.WriteLine("\b}");
    }
}
