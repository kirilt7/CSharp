using System;
class ProsuctOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0))
        {
            Console.WriteLine("The product's sign is '+'. ");
        }
        else if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0)) 
        {
            Console.WriteLine("The product's sign is '-'. ");
        }
        else if ((a < 0 && b < 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The product's sign is '+'. ");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product is zero. ");
        }
    }


}
