//Write a program that finds the sequence of maximal sum in given array.
using System;
class SequenceOfMaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter  array elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int maxSum = 0;
        int curIndex=0;
        int maxSumIndex= 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            curIndex = i;
            sum += array[i];
            if (sum>maxSum)
                {
                    maxSum = sum;
                    maxSumIndex = curIndex;
                    count++;
                }

         }
        Console.WriteLine("Sequence of maximal sum is: ");
        for (int i = maxSumIndex-count; i <= maxSumIndex; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
