//19. Write a program that extracts from a given text all dates that match the 
// format DD.MM.YYYY. Display them in the standard date format for Canada.
using System;
using System.Text.RegularExpressions;
using System.Globalization;
class Program
{
    static void Main()
    {
        string text = "Write a program that extracts from a given text all dates that match the format 12.10.2012, 50.13.2012";
        string pattern = @"\b\d{2}.\d{2}.\d{4}\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        DateTime date;
        foreach (Match match in matches)
	    {
            if (DateTime.TryParse(match.Value, out date))
	        {
		        Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("fr-CA")));
	        }
	    }
    }
}