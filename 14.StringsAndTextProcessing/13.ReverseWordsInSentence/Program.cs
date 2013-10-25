//13. Write a program that reverses the words in given sentence.
﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string str = "C# is not C++, not PHP and not Delphi!";

        string pattern = @"\s+|,\s*|\.\s*|!\s*|$";
        var words = new Stack<string>();
        foreach (var word in Regex.Split(str, pattern))
        {
            if (word.Length!=0)
            {
                words.Push(word);
            }
            
        }
        foreach (var separator in Regex.Matches(str, pattern))
        {
            if (words.Count!=0)
	        {
		        Console.Write(words.Pop()+separator);
	        }
            
        }

        Console.WriteLine();
    }
}