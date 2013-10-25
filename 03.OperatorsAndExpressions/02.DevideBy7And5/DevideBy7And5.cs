using System;

    class DevideBy7And5
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        bool devideBy7 = ((a % 7) == 0);
        bool devideBy5 = ((a % 5) == 0);
        bool devideBy7And5 = devideBy7 && devideBy5;
        Console.WriteLine(devideBy7And5);
    }
}
