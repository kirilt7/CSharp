using System;
class Rectangle
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine("The area of this rectangle is: {0}",area);
    }
}

