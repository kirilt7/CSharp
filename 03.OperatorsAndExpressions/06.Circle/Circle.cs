using System;
class Circle
{
    static void Main(string[] args)
    {
        double pointA = double.Parse(Console.ReadLine());
        double pointB = double.Parse(Console.ReadLine());
        double isWithin = System.Math.Sqrt((pointA * pointA) + (pointB * pointB));
        if (isWithin <= 5)
        {
            Console.WriteLine("This point is within a circle.");
        }
        else Console.WriteLine("This point is not within a circle.");
    }
}
