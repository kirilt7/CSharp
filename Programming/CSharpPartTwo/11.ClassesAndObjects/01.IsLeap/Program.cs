//01. Write a program that readsa year from the console and
//checks whether it is a leap. Use DateTime.
using System;
class Program
{
    static void IsLeap(int year)
    {
        Console.WriteLine("Is {0} leap year: {1}",year, DateTime.IsLeapYear(year));
    }
    static void Main()
    {
        Console.WriteLine("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        IsLeap(year);

    }
}