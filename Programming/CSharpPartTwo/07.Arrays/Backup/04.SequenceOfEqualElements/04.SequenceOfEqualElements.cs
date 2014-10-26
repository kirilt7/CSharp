using System;

class ComparingArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter  arrays length:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sequence = 0 ;
        int max = 0;
        int index = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                sequence++;
                if (sequence > max)
                {
                    max = sequence;
                    index = i+1;
                }
            }
            else
            {
                sequence = 0;
            }

        }
        Console.WriteLine("Maximal sequence of equal elements: ");
        for (int i = index; i >= (index-max); i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}
