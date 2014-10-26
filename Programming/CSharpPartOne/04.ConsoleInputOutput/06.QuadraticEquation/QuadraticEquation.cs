using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coeficient a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coeficient b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coeficient c:");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) + (4 * a * c);
        if (d < 0) Console.WriteLine("No real roots.");
        else
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1= {0:0.0000}, x2= {1:0.0000}", x1, x2);
        }
    }
}

