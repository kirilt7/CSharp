using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter sum S: ");
        int s = int.Parse(Console.ReadLine());

        int sum;
        int curIndex = 0;
        int count;
        for (int i = 0; i < array.Length-1; i++)
        {
            sum = 0;
            count = 0;
            for (int k = i; k < array.Length; k++)
            {
                count++;
                sum += array[k];
                if (sum == s)
                {
                    for (int j = i; j < (i+count); j++)
                    {
                        Console.WriteLine(array[j]);
                    }
                }
            }
        }
        
    }
}

