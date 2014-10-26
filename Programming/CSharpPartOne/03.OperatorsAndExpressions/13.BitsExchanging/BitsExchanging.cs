using System;
class BitsExchanging
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int result = v & mask;
        if (result == 0) Console.WriteLine("False");
        else Console.WriteLine("True");

    }
}
