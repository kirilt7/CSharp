using System;
class PrimeNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter  a number:");
        int prime = int.Parse(Console.ReadLine());
        if (prime <= 100) {
            int devide = 0;
            for (int i = 2; i < prime; i++)
            {
                if (prime % i == 0)
                {
                    devide++;
                }
            }
            if (devide == 0) {
                Console.WriteLine("This number is  prime.");
            }
            else {
                Console.WriteLine("This number is not prime.");
            }
        }
            else {
                Console.WriteLine("This number is more than 100.");
    }
}
}
