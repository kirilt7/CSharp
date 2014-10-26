using System;
class GreatestOf5Variables
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ener first number:");
        int v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int v2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int v3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number:");
        int v4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number:");
        int v5 = int.Parse(Console.ReadLine());
        int greatest =0;
        if ((v1 > v2) && (v1 > v3) && (v1 > v4) && (v1 > v5))
        {
            greatest = v1;
        }
        else if ((v2 > v1) && (v2 > v3) && (v2 > v4) && (v2 > v5))
        {
            greatest = v2;
        }
        else if ((v3 > v1) && (v3 > v2) && (v3 > v4) && (v3 > v5))
        {
            greatest = v3;
        }
        else if ((v4 > v5) && (v4 > v2) && (v4 > v3) && (v4 > v5))
        {
            greatest = v4;
        }
        else if ((v5 > v1) && (v5 > v2) && (v5 > v3) && (v5 > v4))
        {
            greatest = v5;
        }
        Console.WriteLine("The greatest is: {0}",greatest);
    }
}
