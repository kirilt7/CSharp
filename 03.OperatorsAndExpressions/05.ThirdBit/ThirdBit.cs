using System;
class ThirdBit
{
    static void Main(string[] args)
    {
        int somepoint = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;          // 00000000 0001000
        int result = somepoint & mask;
        if (result == 0) Console.WriteLine("Bit 3 (counting from 0) of this integer is 0");
        else Console.WriteLine("Bit 3 (counting from 0) of this integer is 1");
         
    }
}
