using System;
class BiggestInt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ener first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int c = int.Parse(Console.ReadLine());
        int biggest;
        if (a > b)
        {
            if (a > c)
            {
                biggest = a;
                Console.WriteLine("The biggest is " + biggest);
            }
            else
            {
                biggest = c;
                Console.WriteLine("The biggest is " + biggest);
            }
        }
        else
        {
            if (b > c)
            {
                biggest = b;
                Console.WriteLine("The biggest is " + biggest);
            }
            else
            {
                biggest = c;
                Console.WriteLine("The biggest is " + biggest);
            }
        }
    }
}