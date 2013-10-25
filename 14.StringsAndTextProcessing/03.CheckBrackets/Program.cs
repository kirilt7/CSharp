//03 Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
using System;
class Program
{
    static bool CheckBrackets(string input)
    {
        int stack = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (stack<0)
            {
                return false;
            }
            if (input[i]=='(')
            {
                stack++;
            }
            if (input[i] == ')')
            {
                stack--;
            }
        }
        return stack == 0;
    }

    static void Main()
    {
        Console.WriteLine("Enter an expression: ");
        string input = Console.ReadLine();
        bool isBracketsPutCorrectly = CheckBrackets(input);
        Console.WriteLine("Are brackets in this expression put correctly? "+isBracketsPutCorrectly);
    }
}
