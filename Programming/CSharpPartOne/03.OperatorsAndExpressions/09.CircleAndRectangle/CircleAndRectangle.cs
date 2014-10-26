using System;
class Circle
{
    static void Main(string[] args)
    {
        double pointA = double.Parse(Console.ReadLine());
        double pointB = double.Parse(Console.ReadLine());
        double isWithin = System.Math.Sqrt(((pointA-1) * (pointA-1)) + ((pointB-1) * (pointB-1)));
        if (isWithin <= 3)
        {
            if ((pointA <= 1) && (pointA >= 7))
            {
                if ((pointB <= -1) && (pointB >= 2))
                    Console.WriteLine("This point is within a circle and out of rectangle");
            }
            else Console.WriteLine("This point is within a circle but also within rectangle");
        }
        else Console.WriteLine("This point is not within a circle.");
   
    }
}
