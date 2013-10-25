//Write a program that reads two arrays from the console and compares them element by element.
using System;
class ComparingArrays
{
    static void Main()
    {
        Console.WriteLine("Enter  arrays length:");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[n];
        for (int i = 0; i < arrayOne.Length; i++)
        {
            Console.WriteLine("Enter element {0}: ",i);
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
       
        int[] arrayTwo = new int[n];
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            Console.WriteLine("Enter element {0}: ", i);
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (arrayOne[i]>arrayTwo[i])
            {
                Console.WriteLine("{0}>{1}",arrayOne[i],arrayTwo[i]);
            }
            else if (arrayOne[i]<arrayTwo[i])
            {
                Console.WriteLine("{0}<{1}",arrayOne[i],arrayTwo[i]);
            }
            else
            {
                Console.WriteLine("{0}={1}", arrayOne[i], arrayTwo[i]);
            }
        }
    }
}
