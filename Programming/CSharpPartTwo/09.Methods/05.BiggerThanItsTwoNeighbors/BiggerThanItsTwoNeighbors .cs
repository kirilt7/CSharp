using System;

class Program
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
    static bool BiggerThanNeighbors(int[] array, int position)
    {
        if (array[position+1]>array[array.Length-1] || array[position-1]< array[0])
        {
            return false;
        }
        else
        {
            if (array[position]>array[position+1] && array[position]> array[position-1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = ReadArray(n);
        Console.WriteLine("Enter element position: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Element on position {0} is bigger than its neighbors?", position);
        Console.WriteLine(BiggerThanNeighbors(array, position));
    }
}