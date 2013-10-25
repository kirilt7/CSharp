//16. Write a program that reads two dates in the format: day.month.year and calculates 
//the number of days between them. 
using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("Enter the first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        if ((firstDate - secondDate).TotalDays>0)
        {
            Console.WriteLine("Distance: {0}", (firstDate - secondDate).TotalDays);  
        }
        else
        {
            Console.WriteLine("Distance: {0}", (secondDate - firstDate).TotalDays);
        }
    }
}