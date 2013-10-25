using System;
class Program
{
    static int HexaToDecimal(string hexaNumber)
    {
        int decimalNumber = 0;
        for (int i = 0; i < hexaNumber.Length; i++)
        {
            if (hexaNumber[i] >= 'A')
            {
                decimalNumber += (int)(Math.Pow(16, (hexaNumber.Length - 1 - i))) * (hexaNumber[i]-'A'+10);
            }
            
            else
            {
                decimalNumber += (int)(Math.Pow(16, (hexaNumber.Length - 1 - i))) * int.Parse(hexaNumber[i].ToString());
            }
        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number: ");
        string hexaNumber = Console.ReadLine();
        int decimalNumber = HexaToDecimal(hexaNumber);
        Console.WriteLine("Decimal is: {0}", decimalNumber);
    }
}