using System;
class OddOrEven
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        bool odd = ((a % 2) == 1);
        if (odd == true) {
            Console.WriteLine("This number is odd.");
        }
        else {
            Console.WriteLine("This number is even.");
        }
    }
}
