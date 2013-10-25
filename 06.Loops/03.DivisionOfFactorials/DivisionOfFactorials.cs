using System;
using System.Numerics;
class DivisionOfFactorials
{
    static void Main()
    {
         Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        if ((1 < n) && (n > k))
        {
            BigInteger result = 1;
            for (int i = n; i > k; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

