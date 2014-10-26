using System;
using System.Text;

class Program
{
    public static string BinaryToHex(string binary)
    {
        int i = Convert.ToInt32(binary, 2);
        string hex = Convert.ToString(i, 16);
        return hex;
    }
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        string hexNumber = BinaryToHex(binaryNumber);
        Console.WriteLine("Hexadecimal is: {0}", hexNumber);
    }
}