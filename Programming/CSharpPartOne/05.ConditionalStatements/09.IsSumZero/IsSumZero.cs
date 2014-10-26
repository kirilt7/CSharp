using System;
class IsSumZero
{
    static void Main(string[] args)
    {
        int[] array = new int[5];
        int sumCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter a number:");
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == 0)
                {
                    sumCount++;
                }
                for (int k = 2; k < array.Length; k++)
                {
                    if (array[i] + array[j] + array[k] == 0)
                    {
                        sumCount++;
                    }
                    for (int m = 3; m < array.Length; m++)
                    {
                        if (array[i] + array[j] + array[k] + array[m] == 0)
                        {
                            sumCount++;
                        }
                        for (int n = 4; n < array.Length; n++)
                        {
                            if (array[i] + array[j] + array[k] + array[m] + array[n] == 0)
                            {
                                sumCount++;
                            }

                        }
                    }
                }
            }
        }
        if (sumCount != 0)
        {
            Console.WriteLine("There are sums of subsets that are equal to 0!");
        }
    }

}
