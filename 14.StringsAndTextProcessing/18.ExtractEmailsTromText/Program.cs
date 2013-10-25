//18. Write a program for extracting all email addresses from given text. 
// All substrings that match the format <identifier>@<host>…<domain> should be 
// recognized as emails.
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @"Valid: svirka@kaval.com, sladurana@duduk.net, -123--@usa.net,
                    test.test123@en.some-host.12345.com, Invalid: .ala.@bala.com, 
                    test@-host.com, user@.test.ru, user@test.ru., alabala@, user@host, @eu.net";
        string pattern = @"([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" +
          @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})";
        MatchCollection matches = Regex.Matches(text, pattern);
            foreach (var email in matches)
	        {
		        Console.WriteLine(email);
	        }
    }
}
