//14. A dictionary is stored as a sequence of text lines containing words 
// and their explanations. Write a program that enters a word and translates 
// it by using the dictionary. 
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string dictionary = ".NET a–b platform for applications from Microsoft\nCLR – managed execution environment for .NET\nnamespace – hierarchical organization of classes\n";
        Console.WriteLine("Enter word to explain: ");
        string input = Console.ReadLine();
        string pattern = String.Format(@"{0}\s.+?\n",input);
        Match explain = Regex.Match(dictionary, pattern, RegexOptions.IgnoreCase);
        Console.Write(explain.Value);
    }
}
