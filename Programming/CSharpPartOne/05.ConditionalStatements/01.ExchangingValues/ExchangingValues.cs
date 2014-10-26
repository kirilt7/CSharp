using System;
class ExchangingValues
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ener first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("Now values are:");
        Console.WriteLine("a= "+a);
        Console.WriteLine("b= "+b);
    }
}

