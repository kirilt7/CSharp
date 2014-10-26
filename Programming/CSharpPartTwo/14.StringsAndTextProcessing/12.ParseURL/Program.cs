//12. Write a program that parses an URL address given in the format:
// [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements. 
// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		[protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter URL: ");
        string url = Console.ReadLine();
        string pattern = @"(?<protocol>.*)://(?<server>.*?)/(?<resource>.*)";
        Match match = Regex.Match(url, pattern);
        Console.WriteLine("Protocol: {0}",match.Groups["protocol"].Value);
        Console.WriteLine("Server: {0}", match.Groups["server"].Value);
        Console.WriteLine("Resource: {0}", match.Groups["resource"].Value);
    }
}

