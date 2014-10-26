using System;
class SumOfFractions
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number N:");
        int n = int.Parse(Console.ReadLine());
        decimal sum = 0;
        Console.WriteLine("Sum of:");
        for (int i = 1; i <=n; i++)
        {
            decimal fraction = 1m / i;
            Console.WriteLine("1/{0},",i);
            sum = sum + fraction;
        }
        Console.WriteLine("is: {0:0.000}",sum);
    }
}
