using System;
class PrintNotDivisibleNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number's count:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

