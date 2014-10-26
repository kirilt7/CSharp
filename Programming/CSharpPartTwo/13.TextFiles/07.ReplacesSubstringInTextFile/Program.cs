using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../../Ex8.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../../Ex9.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
    }
}