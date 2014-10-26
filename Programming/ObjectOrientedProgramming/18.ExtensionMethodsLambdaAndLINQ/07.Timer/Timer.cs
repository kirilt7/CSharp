using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class Timer
{
    delegate void SomeDelegate(int t);
    public static void Print(int t)
    {
        for (int i = 0; i < t; i++)
        {
            Console.WriteLine("Doing something...");
        }
    }
    public static void Sleep(int t)
    {
        Thread.Sleep(t*1000);
    }
    static void Main()
    {
        SomeDelegate d = new SomeDelegate(Print);
        d += Sleep;
        for (int i = 0; i < 5; i++)
        {
            d(3);   
        }
    }
}