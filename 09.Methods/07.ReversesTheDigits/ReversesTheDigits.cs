using System;
class ReversesTheDigits
{
    static char[] ReverseDigit(string number)
    {
        char[] tempoNumber= new char[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            tempoNumber[(tempoNumber.Length - 1) - i] = number[i];
        }
        return tempoNumber;
    }
    static void Main()
    {
        Console.WriteLine("Enter an interger: ");
        string number = Console.ReadLine();
        Console.WriteLine(ReverseDigit(number));
    }
}