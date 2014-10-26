using System;
class FibonacciSequence
{
    static void Main(string[] args)
    {
        decimal a=0;
        decimal b=1;
        for (int i = 0; i < 100; i++)
        {
            Console.Write("{0}, ",a);
            decimal sum = a + b;
            a = b;
            b = sum;
        }
    }
}

