//02.Write a method ReadNumber(int start, int end) that enters an
//integer number in givenrange [start…end]. If an invalid number or non-number
//text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers.
using System;
class Program
{
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number >= start && number <= end)
        {
            return number;
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
            Console.WriteLine("Enter start:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end:");
            int end = int.Parse(Console.ReadLine());
            if (start >= end)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number [{0}...{1}]", start, end);
                ReadNumber(start, end);
            }

        }
        catch (OverflowException ovEx)
        {
            Console.Error.WriteLine("Error:{0}", ovEx.Message);
        }
        catch (ArgumentOutOfRangeException outOfRangeEx)
        {
            Console.Error.WriteLine("Error:{0}", outOfRangeEx.Message);
        }
        catch (ArgumentNullException nullEx)
        {
            Console.Error.WriteLine("Error:{0}", nullEx.Message);
        }
        catch (ArgumentException arEx)
        {
            Console.Error.WriteLine("Error:{0}", arEx.Message);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine("Error:{0}", fe.Message);
        }
    }

}