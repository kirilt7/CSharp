using System;
    class Program
    {
        static long CalcPatt(int[] pattern, int[] valley)
        {
            int[] wasHere = new int[valley.Length];
            long sum = valley[0];
            wasHere[0] = 1;
            int currPosition = 0;
            for (int i = 0; i >=0; i++)
            {
                currPosition += pattern[i%pattern.Length];
                if (currPosition<0 || currPosition>= valley.Length || wasHere[currPosition]==1)
                {
                    return sum;
                }
                else
                {
                    sum += valley[currPosition];
                    wasHere[currPosition] = 1;
                }
            }
            return sum;
        }
        static void Main()
        {
            string inputNums = Console.ReadLine();
            string[] rawNums = inputNums.Split(',');
            int[] valley = new int[rawNums.Length];
            for (int i = 0; i < valley.Length; i++)
            {
                valley[i] = int.Parse(rawNums[i]);
            }
            int countOfPatts = int.Parse(Console.ReadLine());
            long max = int.MinValue;
            for (int i = 0; i < countOfPatts; i++)
			{
			    string inputNumsPatt = Console.ReadLine();
                string[] rawNumsPatt = inputNumsPatt.Split(',');
                int[] pattern = new int[rawNumsPatt.Length];
                for (int j = 0; j < pattern.Length; j++)
                {
                    pattern[j] = int.Parse(rawNumsPatt[j]);
                }
                if (CalcPatt(pattern, valley)>max)
	            {
		            max=CalcPatt(pattern, valley);
	            }
			}
            Console.Write(max);
        }
    }
