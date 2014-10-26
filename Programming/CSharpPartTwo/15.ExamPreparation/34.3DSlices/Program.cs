using System;

    class Program
    {
        static void Main()
        {
            string[] sizes = Console.ReadLine().Split();
            int height = int.Parse(sizes[1]);
            int depth = int.Parse(sizes[2]);
            int width = int.Parse(sizes[0]);
            int[, ,] cuboid = new int[height, depth, width];
            long totalSum = 0;
            for (int h = 0; h < height; h++)
            {
                string[] tokens = Console.ReadLine().Split(new char[]{'|'}, StringSplitOptions.RemoveEmptyEntries);
                for (int d = 0; d < depth; d++)
                {
                    string[] numbersStr = tokens[d].Trim().Split();
                    for (int w = 0; w < width; w++)
                    {
                        cuboid[h, d, w] = int.Parse(numbersStr[w]);
                        totalSum += cuboid[h, d, w];
                    }
                }
            }
            int count = 0;
            long sum = 0;
            for (int h = 0; h < height-1; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        sum += cuboid[h, d, w];
                    }
                }
                if ((sum+sum)==totalSum)
                {
                    count++;
                }
            }
            sum = 0;
            for (int d = 0; d < depth-1; d++)
            {
                for (int h = 0; h < height; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        sum += cuboid[h, d, w];
                    }
                }
                if ((sum + sum) == totalSum)
                {
                    count++;
                }
            }
            sum = 0;
            for (int w = 0; w < width-1; w++)
            {
                for (int d = 0; d < depth; d++)
                {
                    for (int h = 0; h < height; h++)
                    {
                        sum += cuboid[h, d, w];
                    }
                }
                if ((sum + sum) == totalSum)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
