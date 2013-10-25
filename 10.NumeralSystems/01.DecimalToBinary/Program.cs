using System;
using System.Collections.Generic;
class Program
{
    static List<int> DecimalToBinary(int decimalNumber)
    {
        List<int> array = new List<int>(0);
        while (decimalNumber > 0)
        {
            array.Add(decimalNumber % 2);
            decimalNumber /= 2;
        }
        array.Reverse();
        return array;
    }
    static void PrintBinary(List<int> array)
    {
        Console.WriteLine("Binary is: ");
        foreach (int bit in array)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<int> binaryArray = DecimalToBinary(decimalNumber);
        PrintBinary(binaryArray);
    }
}
