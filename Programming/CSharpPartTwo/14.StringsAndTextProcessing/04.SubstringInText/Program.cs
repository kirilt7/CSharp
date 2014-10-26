//04. Write a program that finds how many times a substring is contained in a given 
//text (perform case insensitive search).
using System;
using System.Text.RegularExpressions;
    class Program
    {
        static int CountSubstringInText(string text, string pattern)
        {
            string patternForMatch = String.Format(@"{0}",pattern);
            MatchCollection matches = Regex.Matches(text, patternForMatch,RegexOptions.IgnoreCase);
            return matches.Count;
        }
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter substring: ");
            string pattern = Console.ReadLine();
            int count = CountSubstringInText(text, pattern);
            Console.WriteLine("The result is: {0}.",count);
            
        }
    }

