using System;
class LastDigitOfGivenInteger
{
    static string LastDigit(int a)
    {
        string digits = a.ToString();
        char lastDigit = digits[digits.Length - 1];
        switch (lastDigit)
        {
            case '1':
                return "One";
                
            case '2':
                return "Two";
                
            case '3':
                return "Three";
                
            case '4':
                return "Four";
                
            case '5':
                return "Five";
                
            case '6':
                return "Six";
                
            case '7':
                return "Seven";
                
            case '8':
                return "Eight";
                
            case '9':
                return "Nine";
                
            case '0':
                return "Zero";
            default:
                return "Invalid input. Please enter an integer!.";
                
                
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter an interger: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine( LastDigit(number) ); 
    }
}