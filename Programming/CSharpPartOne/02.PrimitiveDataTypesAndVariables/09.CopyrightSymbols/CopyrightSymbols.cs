using System;
using System.Text;
class CopyrightSymbols
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '©';
        Console.WriteLine("     {0}\n    {0}{0}{0}\n   {0}{0}{0}{0}{0}", symbol);
    }
}