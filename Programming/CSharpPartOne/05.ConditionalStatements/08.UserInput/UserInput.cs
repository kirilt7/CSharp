using System;

class UserInput
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter:'1' for int, '2' for double, '3' for string.");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: 
                Console.WriteLine("Enter an int:");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine(v1+1);
                break;
            case 2: 
                Console.WriteLine("Enter a double:");
                int v2 = int.Parse(Console.ReadLine());
                Console.WriteLine(v2+1);
                break;
            case 3:
                Console.WriteLine("Enter a string:");
                string v3 = Console.ReadLine();
                Console.WriteLine(v3 + '*');
                break;
            default: Console.WriteLine("Error!"); break;
        }

    }
}