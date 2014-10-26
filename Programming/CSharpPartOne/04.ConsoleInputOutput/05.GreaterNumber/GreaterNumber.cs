using System;
class GreaterNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        if (a > b) Console.WriteLine("First number is bigger than second.");
        else Console.WriteLine("Second number is bigger than first.");
    }
}