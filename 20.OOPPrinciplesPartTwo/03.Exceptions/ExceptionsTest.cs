using System;
using System.Collections.Generic;
using System.Linq;
class ExceptionsTest
{
    static void GetNumber(int number)
    {
        if (number<1 || number>100)
        {
            throw new InvalidRangeException<int>("Number exception!", 1, 100);
        }
        else
        {
            Console.WriteLine(number);
        }
    }
    static void GetDate(DateTime date)
    {
        if (date < DateTime.Parse("1.1.1980") || date> DateTime.Parse("31.12.2013"))
        {
            throw new InvalidRangeException<DateTime>("Date exception!", DateTime.Parse("1.1.1980"), DateTime.Parse("31.12.2013"));
        }
        else
        {
            Console.WriteLine(date);
        }
    }
    static void Main(string[] args)
    {
        try
        {
            GetNumber(5);
            GetNumber(101);
        }
        catch (InvalidRangeException<int> ex)
        {
            Console.WriteLine("{0}: Must be between {1} and {2}",ex.Message, ex.Start, ex.End);
        }
        try
        {
            GetDate(DateTime.Parse("30.10.2013"));
            GetDate(DateTime.Parse("1.1.2015"));
        }
        catch (InvalidRangeException<DateTime> ex)
        {
            Console.WriteLine("{0}: Must be between {1} and {2}", ex.Message, ex.Start, ex.End);
        }
    }
}