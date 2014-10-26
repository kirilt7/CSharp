using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> digits = new List<string>();
        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }
        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString() + j);
            }
        }
        ulong number = ulong.Parse(Console.ReadLine());
        string result = "";
        if (number == 0)
        {
            Console.WriteLine("A");
        }
        while (number > 0)
        {
            result = digits[(int)(number % 256)] + result;
            number /= 256;
        }
        Console.WriteLine(result);
    }
}
