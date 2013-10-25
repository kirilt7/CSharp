using System;
class NumberAppearsInGivenAarray
{
    static int[] ReadArray(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter an element {0}: ",i);
            array[i] = int.Parse(Console.ReadLine()); 
        }
        return array;
    }
    static int NumberInArray(int[] array, int number)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==number)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = ReadArray(n);
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} times.", NumberInArray(array,number));
    }
}
