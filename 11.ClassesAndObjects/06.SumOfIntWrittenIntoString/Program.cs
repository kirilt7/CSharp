//06. You are given a sequence of positive integer values written into a string,
//separated by spaces. Write a function that reads these values from given
//string and calculates their sum.

using System;
class Program
{
    static int CalcSum(string s)
    {
        int sum = 0;
        string[] numbers = s.Split(' ');
        foreach (string number in numbers)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Enter integers, separated by spaces:");
        string s = Console.ReadLine();
        Console.WriteLine("Their sum is : {0}", CalcSum(s));
    }
}