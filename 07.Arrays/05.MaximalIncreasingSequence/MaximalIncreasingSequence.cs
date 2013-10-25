//Write a program that finds the maximal increasing sequence in an array.
using System;
class ComparingArrays
{
    static void Main()
    {
        Console.WriteLine("Enter  arrays length:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sequence = 0;
        int max = 0;
        int index = 0;
        int maxSeqIndex = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == (array[i + 1]-1))
            {
                if (sequence == 0)
                {
                    index = i;
                }

                sequence++;
            }
            if (array[i] != (array[i + 1]-1))
            {
                if (sequence > max)
                {
                    max = sequence;
                    maxSeqIndex = index;
                }
                sequence = 0;
            }

        }
        Console.WriteLine("Maximal sequence of increasing elements: ");
        for (int i = maxSeqIndex; i <= (maxSeqIndex + max); i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
