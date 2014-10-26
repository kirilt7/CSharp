//08. Write a program that extracts from a given text 
//all sentences containing given word.
//08. Write a program that extracts from a given text all sentences 
//containing given word.
using System;
using System.Text.RegularExpressions;
class Program
{
    static void SentencesContainingGivenWord(string text, string pattern)
    {
        string patternForMatch = String.Format(@"([^\.]*\b{0}\b.*?\.)",pattern);
        MatchCollection matches = Regex.Matches(text, patternForMatch);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter substring: ");
        string pattern = Console.ReadLine();
        SentencesContainingGivenWord(text, pattern);

    }
}

