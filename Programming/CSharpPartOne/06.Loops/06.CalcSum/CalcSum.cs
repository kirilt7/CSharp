using System;
using System.Numerics;
class CalcSum
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X:");
        int x = int.Parse(Console.ReadLine());
        if ((1 < n) && (x > 1))
        {
            double factResult = 1;
            double singleResult = 0;
            double result = 1;
                for (int i = 1; i <= n; i++)
                {
                    factResult *= i;
                    singleResult = factResult / Math.Pow(x, i);
                    result += singleResult;
                }
             
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

