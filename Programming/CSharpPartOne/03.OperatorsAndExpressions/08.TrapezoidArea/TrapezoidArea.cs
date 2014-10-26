using System;
class TrapezoidArea
{
    static void Main(string[] args)
    {
        int sideA = int.Parse(Console.ReadLine());
        int sideB = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        decimal area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area of this trapezoid is {0}.",area);
    }
}
