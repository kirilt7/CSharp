using System;
using System.Threading;
using System.Globalization;
class PerimeterAndAreaOfCircle
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter a radius:");
        double pi = Math.PI;
        double radius = double.Parse(Console.ReadLine());
        double area = pi * radius * radius;
        double perimeter = 2 * pi * radius;
        Console.WriteLine("The area of this circle is:{0:0.0000}",area);
        Console.WriteLine("The perimeter of this circle is:{0:0.0000}",perimeter);
    }
}
