//11. Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. Format the 
//output aligned right in 15 symbols.
using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine()); ;
        Console.WriteLine("{0,15:D}\n" +
                        "{0,15:X}\n" +
                        "{0,15:P}\n" +
                        "{0,15:E}\n", number);

        
    }
}