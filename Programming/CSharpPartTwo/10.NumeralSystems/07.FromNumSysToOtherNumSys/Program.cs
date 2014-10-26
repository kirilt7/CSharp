using System;
using System.Text;
using System.Collections.Generic;
class Program
{
    static int BasedOnSToDecimal(string sNumber,int s)
    {
        int decimalNumber = 0;
        if (s>10)
        {
            for (int i = 0; i < sNumber.Length; i++)
        {
            if (sNumber[i] >= 'A')
            {
                decimalNumber += (int)(Math.Pow(s, (sNumber.Length - 1 - i))) * (sNumber[i] - 'A' + 10);
            }
            else
            {
                decimalNumber += (int)(Math.Pow(s, (sNumber.Length - 1 - i))) * int.Parse(sNumber[i].ToString());
            }
        }
        return decimalNumber;
        }
        else
        {
            for (int i = 0; i < sNumber.Length; i++)
            {
                decimalNumber += (int)(Math.Pow(s, (sNumber.Length - 1 - i))) * int.Parse(sNumber[i].ToString());
            }
            return decimalNumber;
        }
        
    }
    static List<int> DecimalToBasedOnD(int decimalNumber, int d)
    {
        List<int> array = new List<int>(0);
        while (decimalNumber > 0)
        {
            array.Add(decimalNumber % d);
            decimalNumber /= d;
        }
        array.Reverse();
        return array;
    }
    static void PrintNumber(List<int> array, int d)
    {
        Console.WriteLine("New number, based on {0}, is: ", d);
        if (d>10)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] >= 10)
                {
                    Console.Write((char)('A'+array[i]-10));
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
            Console.WriteLine();  
        }
        else
        {
            foreach (int digit in array)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }
        
    }
    static void Main()
    {
        Console.WriteLine("Your numeral system is based on: ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number");
        string numberBaseOnS = Console.ReadLine();
        Console.WriteLine("Convert to any other numeral system of base: ");
        int d = int.Parse(Console.ReadLine());
        int decimalNumber = BasedOnSToDecimal(numberBaseOnS, s);
        List<int> convertedNumber = DecimalToBasedOnD(decimalNumber, d);
        PrintNumber(convertedNumber, d);
    }
}