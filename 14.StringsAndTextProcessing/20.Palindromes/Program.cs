//20. Write a program that extracts from a given text all palindromes, 
// e.g. "ABBA", "lamal", "exe".
using System;
using System.Text.RegularExpressions;
class Program
{
    static bool IsPalindrome(string word)
    {
        if (word.Length<2)
        {
            return false;
        }
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
        string pattern = @"\w+";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match word in matches)
        {
            if (IsPalindrome(word.Value))
            {
                Console.WriteLine(word.Value);
            }
        }
    }
}