using System;

class Program
{
    static int Min(params int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static int Max(params int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static decimal Average(params decimal[] numbers)
    {
        decimal result = 0;
        decimal sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        result = sum / numbers.Length;
        return result;
    }

    static int Product(params int[] numbers)
    {
        int result = 1;
        foreach (var num in numbers)
        {
            result *= num;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine();
        int min = Min(1, 2, 3, 4);
        int max = Max(1, 2, 3, 4);
        decimal average = Average(1, 2, 3, 4);
        int product = Product(1, 2, 3, 4);
        Console.WriteLine("The min number is: " + min);
        Console.WriteLine("The max number is: " + max);
        Console.WriteLine("The average number is: " + average);
        Console.WriteLine("The product  is: " + product);
    }
}