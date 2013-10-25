using System;
class GetMaxOf3Numbers
{
    static int[] ReadNumbers()
    {
        Console.WriteLine("Enter first integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third integer: ");
        int c = int.Parse(Console.ReadLine());
        int[] array = new int[] { a, b, c };
        return array;
    }
    static int GetMax(int a, int b)
    {
        int max = a;
        if (a<b)
        {
            max = b;
        }
        return max;
    }
    static void Main(string[] args)
    {
        int [] array = ReadNumbers();
        if (array[2]> GetMax(array[0], array[1]))
        {
            Console.WriteLine("Biggest is: {0}!",array[2]);
        }
        else
        {
            Console.WriteLine("Biggest is: {0}!", GetMax(array[0], array[1]));
        }
    }
}