using System;
class NullVariable
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("a = {0},b = {1}", a, b);

        a += null;
        b += 5; // Adding value to null variable results null
        Console.WriteLine("a = {0},b = {1}", a, b);
    }
}