//05. Write a method that calculates the number of workdays between today
//and given date, passed as parameter. Consider that workdays are all daysfrom
//Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;
using System.Collections.Generic;
class Program
{
    static int WorkDays(DateTime now, DateTime futureDate)
    {
        int workdays = 0;
        while (now <= futureDate)
        {
            if (now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday)
            {
                if (!IsHolyday(now))
                {
                    workdays++;
                }
            }
            now = now.AddDays(1);
        }
        return workdays;
    }
    static bool IsHolyday(DateTime day)
    {
        if ((day.Month == 1 && day.Day == 1) || (day.Month == 3 && day.Day == 3) || (day.Month == 5 && day.Day == 1)
            || (day.Month == 5 && day.Day == 6)|| (day.Month == 5 && day.Day == 24) || (day.Month == 8 && day.Day == 15)
            || (day.Month == 9 && day.Day == 6)|| (day.Month == 9 && day.Day == 22) || (day.Month == 9 && day.Day == 22)
            || (day.Month == 11 && day.Day == 1) || (day.Month == 12 && day.Day == 25))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        DateTime now = DateTime.Now.Date;
        Console.WriteLine("Enter a date.Format should be DD.MM.YYYY:");
        DateTime givenDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("There is {0} workdays between today and your date.",WorkDays(now, givenDate));
    }
}