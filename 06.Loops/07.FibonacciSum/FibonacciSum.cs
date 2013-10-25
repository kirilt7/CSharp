using System;
class FibonacciSum
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        decimal a = 0;
        decimal b = 1;
        decimal sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += a;
            decimal c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine("The sum of Fibonacci numbers is: "+sum);
    }
}