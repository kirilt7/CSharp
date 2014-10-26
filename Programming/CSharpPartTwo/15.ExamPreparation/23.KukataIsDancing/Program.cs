using System;
    class Program
    {
        static void Main()
        {
            int dances = int.Parse(Console.ReadLine());
            string[] movements = new string[dances];
            for (int i = 0; i < dances; i++)
            {
                movements[i] = Console.ReadLine();
            }
            for (int i = 0; i < dances; i++)
            {
                int finalPosition = FinalPosition(movements[i]);
                if (finalPosition==0)
                {
                    Console.WriteLine("GREEN");
                }
                if (finalPosition == 1)
                {
                    Console.WriteLine("RED");
                }
                if (finalPosition == 2)
                {
                    Console.WriteLine("BLUE");
                }
            }
        }
        
        private static int FinalPosition(string movement)
        {
            int[,] cube = new int[3, 3];
            cube[1, 1] = 0; //Green
            cube[0, 0] = cube[0, 2] = cube[2, 0] = cube[2, 2] = 1; //Red
            cube[0, 1] = cube[1, 0] = cube[1, 2] = cube[2, 1] = 2; //Blue
            int pos = 0;
            int row = 1;
            int col = 1;
            for (int i = 0; i < movement.Length; i++)
            {
                if (pos==4)
                {
                    pos = 0;
                }
                if (pos==-1)
                {
                    pos = 3;
                }
                if (movement[i]=='L')
                {
                    pos++;
                }
                if (movement[i] == 'R')
                {
                    pos--;
                }
                if (movement[i]=='W')
                {
                    if (pos==0)
                    {
                        row++;
                    }
                    if (pos == 1)
                    {
                        col++;
                    }
                    if (pos == 2)
                    {
                        row--;
                    }
                    if (pos == 3)
                    {
                        col--;
                    }
                }
                if (row == -1)
                {
                    row = 2;  // Checking for edge
                }
                if (row == 3)
                {
                    row = 0;  // Checking for edge
                }
                if (col == -1)
                {
                    col = 2; // Checking for edge
                }
                if (col == 3)
                {
                    col = 0; // Checking for edge
                }
            }
            return cube[row, col];
        }
    }
