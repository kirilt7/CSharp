//04. Write methods that calculate the surface of a
//triangle by given:-Side and an altitude to it;
//-Three sides; -Two sides and an angle between them. Use System.Math.

using System;
class Program
{
    static double SurfaceOfATriangle(double a, double ha)
    {
        double s = (a*ha)/2;
        return s;
    }
    static double SurfaceOfATriangle(double a, double b, double c)
    {
        double semiP = (a+b+c)/2;
        double s = Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));
        return s;
    }
    static double SurfaceOfATriangle(double a, double b, short alpha)
    {
        double alphaInRad = (alpha * Math.PI) / 180;
        double c = Math.Sqrt((a * a) + (b * b) - (2 * a * b * Math.Cos(alphaInRad)));
        double semiP = (a+b+c)/2;
        double s = Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));
        return s;
    }
    static void Main()
    {
        double SurfaceOfTriangle1 = SurfaceOfATriangle(5.0, 10.0);
        double SurfaceOfTriangle2 = SurfaceOfATriangle(5.0, 10.0, 12.0);
        double SurfaceOfTriangle3 = SurfaceOfATriangle(5.0, 10.0, 12);
        Console.WriteLine(SurfaceOfTriangle1);
        Console.WriteLine(SurfaceOfTriangle2);
        Console.WriteLine(SurfaceOfTriangle3);
        
    }
}