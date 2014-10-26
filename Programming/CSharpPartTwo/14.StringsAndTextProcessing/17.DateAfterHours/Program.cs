//17. Write a program that reads a date and time given in the format:
// day.month.year hour:minute:second and prints the date and time after 6 hours 
// and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
class Program
{
    private static string DayInBulgarian(DayOfWeek dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case DayOfWeek.Monday: return "Понеделник";
            case DayOfWeek.Tuesday: return "Вторник";
            case DayOfWeek.Wednesday: return "Сряда";
            case DayOfWeek.Thursday: return "Четвъртък";
            case DayOfWeek.Friday: return "Петък";
            case DayOfWeek.Saturday: return "Събота";
            case DayOfWeek.Sunday: return "Неделя";


            default: return "";
        }
    }
    static void Main()
    {

        Console.WriteLine("Enter the first date: ");
        DateTime givenTime = DateTime.Parse(Console.ReadLine());
        DateTime futureTime = givenTime.AddMinutes((6 * 60) + 30);
        Console.WriteLine("{0:MM.dd.yy H:mm:ss}", futureTime);
        Console.WriteLine(DayInBulgarian(futureTime.DayOfWeek));
    }
}