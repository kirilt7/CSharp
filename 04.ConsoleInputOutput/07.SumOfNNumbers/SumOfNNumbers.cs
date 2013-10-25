using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Input count of numbers for summing:");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int counter = 0; counter < n; counter++)
        {
            Console.WriteLine("Input number for summing:");
            int x = int.Parse(Console.ReadLine());
            sum = sum + x;
        }
        Console.WriteLine("Sum is: " + sum);
    }
}