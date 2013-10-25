using System;
class BitChanging
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a bit value:");
        int v = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            int mask = (1 << b);
            int result = i | mask;
            Console.WriteLine(result);
        }
        else
        {
            if (v == 0)
            {
                int mask = ~(1 << b);
                int result = i & mask;
                Console.WriteLine(result);
            }
            else Console.WriteLine("Error");
        }
        
    }
}
