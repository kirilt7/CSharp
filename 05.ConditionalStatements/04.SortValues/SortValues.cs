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
        int large;
        int medium;
        int small;
        if (a > b)
        {
            if (a > c)
            {
                large = a;
                if (b > c)
                {
                    medium = b;
                    small = c;
                }
                else
                {
                    medium = c;
                    small = b;
                }
            }
            else
            {
                large = c;
                medium = a;
                small = b;

            }
        }
        else
        {
            if (b > c)
            {
                large = b;
                if (a > c)
                {
                    medium = a;
                    small = c;
                }
                else
                {
                    medium = c;
                    small = a;
                }
            }
            else
            {
                large = c;
                medium = b;
                small = a;
            }
        }
        Console.WriteLine("The sort in decending order is: {0}, {1}, {2}", large, medium, small);
    }
}