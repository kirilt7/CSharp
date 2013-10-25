//Write a program that finds the index of given element in a sorted array of integers 
//by using the binary search algorithm (find it in Wikipedia).
using System;
class BinarySearch
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
        Console.WriteLine("Enter key: ");
        int key = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int left = 0;
        int right = array.Length;
        while (left < right)
        {
            int m = (left + right) / 2;
            if (array[m] < key)
            {
                left = m + 1;
            }
            else if (array[m] > key)
            {
                right = m + 1;
            }
            else
            {
                Console.WriteLine(m);
                return;
            }
        }
    }
}   