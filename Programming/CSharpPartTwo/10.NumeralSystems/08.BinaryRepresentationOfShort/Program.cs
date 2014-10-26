using System;
using System.Collections.Generic;
class Program
{
    static List<int> ShortToBinary(short decimalNumber)
    {
        List<int> array = new List<int>(0);
        bool sign = false;
        if (decimalNumber<0)
        {
            decimalNumber *= -1;
            sign = true;
        }
        while (decimalNumber > 0)
        {
            array.Add(decimalNumber % 2);
            decimalNumber /= 2;
        }
        if (array.Count<16)
        {
            for (int i = array.Count-1; i < 16; i++)
            {
                array.Add(0);
            }
        }
        array.Reverse();
        if (sign)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i]==1)
                {
                    array[i] = 0;
                }
                else
                {
                    array[i] = 1;
                }
            }
        }
        return array;
    }
    static void PrintBinary(List<int> array)
    {
        Console.WriteLine("Binary representation: ");
        foreach (int bit in array)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter a short number (-32,768 to 32,767): ");
        short decimalNumber = short.Parse(Console.ReadLine());
        List<int> binaryArray = ShortToBinary(decimalNumber);
        PrintBinary(binaryArray);
    }
}