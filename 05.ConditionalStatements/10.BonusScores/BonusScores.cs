﻿using System;

class BonusScores
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a digit:");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                digit = digit * 10;
                Console.WriteLine(digit); break;
            case 4:
            case 5:
            case 6:
                digit = digit * 100;
                Console.WriteLine(digit); break;
            case 7:
            case 8:
            case 9:
                digit = digit * 1000;
                Console.WriteLine(digit); break;
            default: Console.WriteLine("Error!"); break;
        }

    }
}