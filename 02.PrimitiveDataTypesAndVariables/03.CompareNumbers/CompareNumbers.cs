using System;
    class CompareNumbers
    {
        static void Main(string[] args)
        {
            float a = 5.00000001f; 
            float b = 5.00000003f;
            bool equal = (a == b);
            Console.WriteLine("Equal={0}",equal);
            a = 5.3f;
            b = 5.01f;
            equal = (a == b);
            Console.WriteLine("Equal={0}", equal);
        }
    }

