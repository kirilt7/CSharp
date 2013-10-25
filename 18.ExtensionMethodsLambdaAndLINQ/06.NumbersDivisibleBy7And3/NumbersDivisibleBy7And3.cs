using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class NumbersDivisibleBy7And3
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 21, 22, 42 };
        var divisibleNumbers =
          numbers.Where(x=> (x % 7) == 0 && (x % 3) == 0);
        foreach (var num in divisibleNumbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();

        //now with LINQ
        var divisibleNumbersWithLINQ =
            from number in numbers
            where (number % 7) == 0 && (number % 3) == 0
            select number;
        foreach (var num in divisibleNumbersWithLINQ)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}
