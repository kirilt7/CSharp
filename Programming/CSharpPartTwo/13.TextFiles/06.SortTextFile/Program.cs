using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        try
        {
        List<string> stringEntries = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\..\unsorted.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                stringEntries.Add(line);
                line = reader.ReadLine();
            }
        }
        stringEntries.Sort();

        using (StreamWriter writer = new StreamWriter(@"..\..\..\sorted.txt"))
        {
            for (int i = 0; i < stringEntries.Count; i++)
            {
                writer.WriteLine(stringEntries[i]);
            }
        }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
    }
}