//10. Write a program that converts a string to a sequence of C# Unicode 
//character literals. Use format strings. 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        foreach (var item in text)
        {
	        Console.Write("\\u{0:x4}", (int)item);
        }
        Console.WriteLine();
    }
}