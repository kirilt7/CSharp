using System;

class MaxElementInAPortionOfArray
{
    static int[] ReadArray(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter an element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static int GetMaxElement(int index, int[] array)
    {
        int bestIndex = index;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > array[bestIndex])
            {
                bestIndex = i;
            }
        }
        return bestIndex;
    }

    static int[] SortingArrayReverse(int[] array)
    {
        int maxElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            maxElement = GetMaxElement(i, array);
            int holder = array[maxElement];
            array[maxElement] = array[i];
            array[i] = holder; 
      
        }
        return array;
    }

    static int[] SortingArray(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            sortedArray[i] = array[array.Length - 1 - i];
        }
        return sortedArray;
    }

    static void PrintMatrix(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write("{0} ",num);
        }
        Console.WriteLine();
    }


    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = ReadArray(n);
        int[] reversedArray = SortingArrayReverse(array);
        int[] sortedArray = SortingArray(reversedArray);

        PrintMatrix(sortedArray);
        PrintMatrix(reversedArray);

    }


}