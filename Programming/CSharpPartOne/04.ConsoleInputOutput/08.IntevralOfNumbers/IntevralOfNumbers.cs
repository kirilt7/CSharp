using System;

class IntervalOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Input number N:");
        int n = int.Parse(Console.ReadLine());
        for (int counter = 1; counter <= n; counter++)
        {
            Console.WriteLine(counter);
        }
    }
}