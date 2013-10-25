using System;
using System.IO;

class Program
{
    public static int FindMaxSum(int[,] matrix)
    {
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1] + matrix[row, col + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }
    public static int[,] ReadMatrixFile()
    {
        int[,] matrix;

        using (StreamReader reader = new StreamReader(@"..\..\..\Ex6.txt"))
        {
            string matrixWithoutSpaces = reader.ReadLine().Replace(" ", string.Empty);
            int matrixSize = matrixWithoutSpaces.Length;
            matrix = new int[matrixSize, matrixSize];
        }
        using (StreamReader reader = new StreamReader(@"..\..\..\Ex6.txt"))
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] stringRow = new string[matrix.GetLength(0)];
                stringRow = reader.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[row, col] = int.Parse(stringRow[col]);
                }
            }
        }
        return matrix;
    }
    static void Main()
    {
        try
        {
            int[,] matrix = ReadMatrixFile();
            int maxSum = FindMaxSum(matrix);
            using (StreamWriter writer = new StreamWriter(@"..\..\..\Ex7.txt"))
            {
                writer.Write(maxSum);
            }
        }
        catch (IOException ioex)
        {
            Console.WriteLine(ioex.Message);
        }
        
    }      
}