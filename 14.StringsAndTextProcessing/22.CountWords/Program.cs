//22. Write a program that reads a string from the console and lists all different words 
// in the string along with information how many times each word is found.
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
        string[] words = Regex.Split(text, @"\W+");
        Dictionary<string, int> diffWords = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i]!=String.Empty)
            {
                if (diffWords.ContainsKey(words[i]))
                {
                    diffWords[words[i]]++;
                }
                else
                {
                    diffWords.Add(words[i], 1);
                }
            }
        }
        foreach (var word in diffWords)
        {
            Console.WriteLine("{0}: {1} times.", word.Key, word.Value);
        }
    }
}