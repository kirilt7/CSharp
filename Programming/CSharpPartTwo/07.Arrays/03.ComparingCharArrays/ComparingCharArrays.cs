//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
class ComparingArrays
{
    static void Main()
    {
        Console.WriteLine("Enter  arrays length:");
        int n = int.Parse(Console.ReadLine());
        char[] arrayOne = new char[n];
        for (int i = 0; i < arrayOne.Length; i++)
        {
            Console.WriteLine("Enter element {0}: ", i);
            arrayOne[i] = char.Parse(Console.ReadLine());
        }

        char[] arrayTwo = new char[n];
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            Console.WriteLine("Enter element {0}: ", i);
            arrayTwo[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (arrayOne[i] > arrayTwo[i])
            {
                Console.WriteLine("{0}>{1}", arrayOne[i], arrayTwo[i]);
            }
            else if (arrayOne[i] < arrayTwo[i])
            {
                Console.WriteLine("{0}<{1}", arrayOne[i], arrayTwo[i]);
            }
            else
            {
                Console.WriteLine("{0}={1}", arrayOne[i], arrayTwo[i]);
            }
        }
    }
}