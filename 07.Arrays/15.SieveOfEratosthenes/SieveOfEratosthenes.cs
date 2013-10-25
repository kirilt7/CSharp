//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
using System;
using System.Collections.Generic;
class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        bool[] array = new bool[10000];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = true;
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == true)
            {
                int j = i + i;
                while (j <array.Length)
                {
                    array[j] = false;
                    j = j + i;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}
