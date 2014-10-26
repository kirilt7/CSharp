using System;
class SortingAnArray
{
    public static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] sortArray = new int[n];
        Console.WriteLine("Enter integer Sorting array elements: ");
        for (int i = 0; i < sortArray.Length; i++)
        {
            sortArray[i] = int.Parse(Console.ReadLine());
        }

        int min;
        for (int k = 0; k < sortArray.Length - 1; k++)
        {
            min = k;
            for (int i = k + 1; i < sortArray.Length; i++)
            {
                if (sortArray[min] > sortArray[i])
                    min = i;
            }
            if (min != k)
            {
                int q = sortArray[k];
                sortArray[k] = sortArray[min];
                sortArray[min] = q;
            }
        }
  
        Console.WriteLine("Sort: ");
        for (int j = 0; j < sortArray.Length; j++)
            Console.WriteLine(sortArray[j]);

    }
}
