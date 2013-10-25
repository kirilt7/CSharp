using System;
using System.Numerics;
class FactorialFormula
{
    static void Main()
    {
        Console.Write("Enter N: ");
        decimal n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        if ((n > 1) && (k > n))
        {
            BigInteger nFact = 1;
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
            }

            BigInteger result = 1;
            for (int i = 0; i < (k - (k - n)); i++)
            {
                result = result * (k - i);
            }

            Console.WriteLine(nFact * result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}