using System;
class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("Enter A:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B:");
        int b = int.Parse(Console.ReadLine());
        int result = 0;
        int remainder = 0;
        while (true)
        {
            if (a > b)
            {
                result = a / b;
                remainder = a % b;
                if (remainder != 0)
                {
                    a = b;
                    b = remainder;
                }
                else
                {
                    Console.WriteLine("The Greatest Common Divider is: {0}", b);
                    break;
                }
            }
            else
            {
                result = b / a;
                remainder = b % a;
                if (remainder != 0)
                {
                    b = a;
                    a = remainder;
                }
                else
                {
                    Console.WriteLine("The Greatest Common Divider is: {0}", a);
                    break;
                }
            }
        }
    }
}