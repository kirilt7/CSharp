//1.Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//a)
//1	5	9	13
//2	6	10	14
//3	7	11	15
//4	8	12	16
//b)
//1	8	9	16
//2	7	10	15
//3	6	11	14
//4	5	12	13
//c)
//7	11	14	16
//4	8	12	15
//2	5	9	13
//1	3	6	10
//d)
//1	12	11	10
//2	13	16	9
//3	14	15	8
//4	5	6	7
using System;
class Matrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] intMatrix = new int[n, n];
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                intMatrix[r, c] = (c*n)+r+1;
                Console.Write("{0,3}, ",intMatrix[r,c]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (c % 2 == 0)
                {
                    intMatrix[r, c] = (c * n) + r + 1;
                }
                else
                {
                    intMatrix[r, c] = (c * n) + (n-r);
                }
                Console.Write("{0,3}, ", intMatrix[r, c]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int currentNumber = 1;
        for (int r = n - 1; r >= 0; r--)
        {
            for (int c = 0; c < n - r; c++)
            {
                intMatrix[r + c, c] = currentNumber;
                currentNumber++;
            }
        }
        for (int c = 1; c < n; c++)
        {
            for (int r = 0; r < n - c; r++)
            {
                intMatrix[r, r + c] = currentNumber;
                currentNumber++;
            }
        }
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0, 3}, ", intMatrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}
