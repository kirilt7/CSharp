//24. Write a program that reads a list of words, separated by spaces 
// and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();

        string[] words = text.Split(' ');
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
