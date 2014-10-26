using System;
class MaximalSumOfKElements
{
    static void Main()
    {
        Console.WriteLine("Enter  arrays length n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int sum = 0;
        for (int i = (array.Length - k); i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Maximal sum of {0} elements is: {1}", k, sum);
    }
}
