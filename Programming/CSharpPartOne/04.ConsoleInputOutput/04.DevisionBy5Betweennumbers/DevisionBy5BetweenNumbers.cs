using System;
class DevisionBy5BetweenNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        ushort a = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        ushort b = ushort.Parse(Console.ReadLine());
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0) count++;
        }
        Console.WriteLine("p({0},{1}) = {2}", a, b, count);

    }
}
