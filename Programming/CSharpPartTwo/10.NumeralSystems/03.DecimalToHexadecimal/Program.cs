using System;
using System.Collections.Generic;
class Program
{
    static List<int> DecimalToHexadecimal(int decimalNumber)
    {
        List<int> array = new List<int>(0);
        while (decimalNumber > 0)
        {
            array.Add(decimalNumber % 16);
            decimalNumber /= 16;
        }
        array.Reverse();
        return array;
    }
    static void PrintBinary(List<int> array)
    {
        Console.WriteLine("Hexadecimal is: ");
        for (int i = 0; i < array.Count; i++)
        {
            if (array[i] >= 10)
            {
                Console.Write((char)('A' + array[i] - 10));
            }
            else
            {
                Console.Write(array[i]);
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<int> hexadecimalArray = DecimalToHexadecimal(decimalNumber);
        PrintBinary(hexadecimalArray);
    }
}
