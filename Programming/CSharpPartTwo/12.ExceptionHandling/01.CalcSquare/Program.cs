//01. Write a program that reads an integer number and calculates and prints its
//square root. If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.
using System;
class Program
{
    static double ReadNumber()
    {
            int number = int.Parse(Console.ReadLine());
            return number;
    }
    static double CalcSqrt(double number)
    {
        if (number >= 0)
        {
            return Math.Sqrt(number);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
    static void Main()
    {
        try
        {
            double number = ReadNumber();
            Console.WriteLine(CalcSqrt(number));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
        
    }
}
