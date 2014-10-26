using System;
using System.Linq;
static class ShapesTest
{
    static void Main()
    {
        Shape[] shapes = new Shape[] {new Triangle(5,6), new Triangle (3,4), new Rectangle(7,8), new Rectangle(2,5),
        new Circle(5), new Circle(6)};
        foreach (var shape in shapes)
        {
            Console.WriteLine("I'm {0}. My surface is {1:0.00}",shape.GetType().Name, shape.CalcSurface());
        }
    }
}
