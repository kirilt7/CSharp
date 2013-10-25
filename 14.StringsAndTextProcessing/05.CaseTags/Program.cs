//05. You are given a text. Write a program that changes the text in all regions surrounded 
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {

        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string pattern = @"<upcase>(?<capitalise>.+?)</upcase>";
        string upText = Regex.Replace(text, pattern, m=>m.Groups["capitalise"].Value.ToUpper());
        Console.WriteLine(upText);
    }
}

