using System;
class FirstBiggerThanItsNeighbors
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
    static int BiggerThanNeighbors(int[] array)
    {
        if (array.Length<=2)
            {
                return -1;
            }
        for (int position = 1; position < array.Length - 1; position++)
        {
            if (array[position] > array[position + 1] &&
            array[position] > array[position - 1])
            {
                return position;
            }        
        }
        return -1;
    }
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = ReadArray(n);
        Console.WriteLine("Element with index {0} is bigger than its neighbors!",
        BiggerThanNeighbors(array));
    }
}