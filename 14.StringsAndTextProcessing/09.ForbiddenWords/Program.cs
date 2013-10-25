//09. We are given a string containing a list of forbidden words and a text 
//containing some of these words. Write a program that replaces the 
//forbidden words with asterisks. 
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string pattern = @"\b(Microsoft|PHP|CLR)\b";
        string replacedText = Regex.Replace(text, pattern, m => new String('*', m.Length));
        Console.WriteLine(replacedText);
    }
}

