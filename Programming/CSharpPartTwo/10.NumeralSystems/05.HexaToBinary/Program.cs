using System;
using System.Collections.Generic;
class Program
{
    static List<string> HexToBinary(string hexNumber)
    {
        List<string> binaryNumber= new List<string>(0);
        for (int i = 0; i < hexNumber.Length; i++)
        {
            if (hexNumber[i] == 'A')
            {
                binaryNumber.Add("1010");
            }
            else if (hexNumber[i] == 'B')
            {
                binaryNumber.Add("1011");
            }
            else if (hexNumber[i] == 'C')
            {
                binaryNumber.Add("1100");
            }
            else if (hexNumber[i] == 'D')
            {
                binaryNumber.Add("1101");
            }
            else if (hexNumber[i] == 'E')
            {
                binaryNumber.Add("1110");
            }
            else if (hexNumber[i] == 'F')
            {
                binaryNumber.Add("1111");
            }
            else if (hexNumber[i] == '0')
            {
                binaryNumber.Add("0000");
            }
            else if (hexNumber[i] == '1')
            {
                binaryNumber.Add("0001");
            }
            else if (hexNumber[i] == '2')
            {
                binaryNumber.Add("0010");
            }
            else if (hexNumber[i] == '3')
            {
                binaryNumber.Add("0011");
            }
            else if (hexNumber[i] == '4')
            {
                binaryNumber.Add("0100");
            }
            else if (hexNumber[i] == '5')
            {
                binaryNumber.Add("0101");
            }
            else if (hexNumber[i] == '6')
            {
                binaryNumber.Add("0110");
            }
            else if (hexNumber[i] == '7')
            {
                binaryNumber.Add("0111");
            }
            else if (hexNumber[i] == '8')
            {
                binaryNumber.Add("1000");
            }
            else if (hexNumber[i] == '9')
            {
                binaryNumber.Add("1001");
            }
        }
        return binaryNumber;
    }
    static void PrintBinary(List<string> array)
    {
        Console.WriteLine("Binary is: ");
        foreach (string fourBits in array)
        {
            Console.Write(fourBits);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine();
        List<string> binaryNumber = HexToBinary(hexNumber);
        PrintBinary(binaryNumber);
       
    }
}