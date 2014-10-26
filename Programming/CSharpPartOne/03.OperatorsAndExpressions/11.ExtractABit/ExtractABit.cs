using System;
class ExractABit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int result = i & mask;
        if (result == 0) Console.WriteLine("Bit {0} (counting from 0) of this integer is 0",b);
        else Console.WriteLine("Bit {0} (counting from 0) of this integer is 1",b);

    }
}
