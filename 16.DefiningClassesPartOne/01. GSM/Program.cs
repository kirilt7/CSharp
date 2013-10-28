using System;
using System.Linq;
using MobilePhone.Test;

class Program
{
    static void Main()
    {
        GSM_Test.TestRunner();
        Console.WriteLine(new string('-', 80) + "\n");
        CallHistory_Test.TestRunner();
    }
}