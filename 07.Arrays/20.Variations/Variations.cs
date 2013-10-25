//Write a program that reads two numbers N and K and generates
//all the variations of K elements from the set [1..N].
using System;
    class Variations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < Math.Pow(n, k); i++)
            {
                int conv = i;
                int[] array = new int[k];
                for (int j = 1; j <= k; j++)
                {
                    array[k-j] = (conv%n)+1;
                    conv = conv / n;
                }

                Console.Write("{");
                Console.Write("{0}",array[0]);
                for (int j = 1; j < k; j++)
                {
                    Console.Write(", {0}", array[j]);
                }
                Console.WriteLine("}");
            } 
        }
    }
