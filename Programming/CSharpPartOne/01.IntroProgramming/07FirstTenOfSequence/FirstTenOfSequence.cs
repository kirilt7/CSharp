using System;
class FirstTenOfSequence
{
    static void Main()
    {
        for (int i = 0; i < 10; i = i + 1)
{
Console.WriteLine((i + 2) * (Math.Pow(-1, i)));
}
    //    for (int i = 2; i < 12; ++i)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        else
    //        {
    //            Console.WriteLine(-i);
    //        }
    //    }
    }
}