//15. Write a program that replaces in a HTML document given as string all the tags 
//<a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
using System;
using System.Text.RegularExpressions;
class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Please enter text: ");
        string input = Console.ReadLine();
        string pattern = @"<a href=""(?<link>(.|\s)*?)"">(?<text>(.|\s)*?)</a>";
        string newPattern = @"[URL=${link}]${text}[/URL]";
        string result = Regex.Replace(input, pattern, newPattern);
        Console.WriteLine(result);
    }
}
