//25. Write a program that extracts from given HTML file its title (if available), 
// and its body text without the HTML tags. 
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        MatchCollection matches = Regex.Matches(text, "(?<=>).*?(?=<)");
        foreach (Match someText in matches)
        {
            if (!String.IsNullOrEmpty(someText.Value))
            {
                Console.WriteLine(someText);
            }
        }
    }
}