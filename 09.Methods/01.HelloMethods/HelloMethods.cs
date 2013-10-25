using System;
class Program
{
    static string EnterName()
    {
        Console.WriteLine("Enter a name: ");
        string name = Console.ReadLine();
        return name;
    }
    static void HelloName(string name)
    {
        Console.WriteLine("Hello, {0}!",name);
    }
    static void Main()
    {
        string name = EnterName();
        HelloName(name);
    }
}