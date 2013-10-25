// This exercise is same as Exercise 9 
using System;
using System.Numerics;
class CatalanNumbers
{
    static BigInteger Factorial(int n)
    {
        BigInteger nFact = 1;
        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }
        return nFact;
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger catalanNumber = Factorial(2 * n) / Factorial(n + 1) * Factorial(n);
        Console.WriteLine(catalanNumber);
    }
}