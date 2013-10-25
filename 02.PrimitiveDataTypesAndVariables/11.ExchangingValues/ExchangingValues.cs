using System;
class ExchangingValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 6;
        Console.WriteLine("First value is: {0}\nSecond value is: {1}",a,b);
        Console.WriteLine("But now...");
        int c;
        c = a;
        a = b;
        b = a;

        Console.WriteLine("First value is: {0}\nSecond value is: {1}",a,b);
    }
}