//06. Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be 
//filled with '*'. Print the result string into the console.
using System;
using System.Text;
class Program
{
    static string StringWith20Chars(string input)
    {
        if (input.Length==20)
        {
            return input;
        }
        else
        {
            StringBuilder stringWith20Chars = new StringBuilder(input);
            for (int i = 0; i < 20-input.Length; i++)
            {
                stringWith20Chars.Append('*');
            }
            return stringWith20Chars.ToString();
        }
        
    }
    static void Main()
    {
        Console.WriteLine("Enter max. 20 characters: ");
        string input = Console.ReadLine();
        string stringWith20Chars = StringWith20Chars(input);
        Console.WriteLine(stringWith20Chars);
    }
}
