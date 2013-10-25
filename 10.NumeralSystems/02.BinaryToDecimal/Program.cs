using System;
class Program
{
    static int BinaryToDecimal(string binaryNumber)
    {
        int decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += (int)(Math.Pow(2, (binaryNumber.Length-1 - i)))*int.Parse(binaryNumber[i].ToString());
        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = BinaryToDecimal(binaryNumber);
        Console.WriteLine("Decimal is: {0}",decimalNumber);
    }
}
