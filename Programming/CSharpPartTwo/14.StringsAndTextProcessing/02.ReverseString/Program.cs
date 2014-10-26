//02. Write a program that reads a string, reverses it and 
//prints the result at the console.Example: "sample" => "elpmas".
using System;
using System.Text;
    class Program
    {
        static string ReverseString(string input)
        {
            StringBuilder reversedString = new StringBuilder(input.Length);
            for (int i = input.Length-1; i >=0; i--)
            {
                reversedString.Append(input[i]);
            }
            return reversedString.ToString();
        }

        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string reversedString = ReverseString(input);
            Console.WriteLine(reversedString);
        }
    }
