using System;
using System.Linq;

class MinMax
{

    static void Main()
    {
        Console.WriteLine("Enter the number's count: ");
        int numberCount = int.Parse(Console.ReadLine());
        int[] numberArray = new int[numberCount];

        for (int i = 0; i < numberCount; i++)
        {
            Console.WriteLine("Enter number:");
            numberArray[i] = int.Parse(Console.ReadLine());
        }
        int min = numberArray.Min();
        int max = numberArray.Max();

        Console.WriteLine("Minimum is {0}", min);
        Console.WriteLine("Maximum is {0}", max);
    }
}