//Write a program that finds the most frequent number in an array.
using System;
class MostFrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int sequence = 0;
        int max = 0;
        int index = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                sequence++;
                if (sequence > max)
                {
                    max = sequence;
                    index = i + 1;
                }
            }
            else
            {
                sequence = 0;
            }

        }

        Console.WriteLine("{0},{1}times", array[index], max+1);
    }
}