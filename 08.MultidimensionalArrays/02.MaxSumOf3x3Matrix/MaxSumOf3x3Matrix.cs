//2.Write a program that reads a rectangular matrix of size N x M and finds in it
// the square 3 x 3 that has maximal sum of its elements.

using System;
class MaxSumOf3x3Matrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        if (n < 3 || m < 3)
        {
            Console.WriteLine("There is no square 3 x 3.");
        }
        else
        {
            int[,] intMatrix = new int[n, m];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.WriteLine("Enter an element:");
                    intMatrix[r, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write("{0,3}, ", intMatrix[r, c]);
                }
                Console.WriteLine();
            }

            int bestSum = int.MinValue;
            for (int r = 0; r < n - 2; r++)
            {
                for (int c = 0; c < m - 2; c++)
                {
                    int sum = intMatrix[r, c] + intMatrix[r, c + 1] + intMatrix[r, c + 2]
                        + intMatrix[r + 1, c] + intMatrix[r + 1, c + 1] + intMatrix[r + 1, c + 2]
                        + intMatrix[r + 2, c] + intMatrix[r + 2, c + 1] + intMatrix[r + 2, c + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine("Maximal sum of the square 3 x 3 is: {0}", bestSum);
        }
    }


}