using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader reader =
        new StreamReader(@"..\..\..\Ex.txt");
        StreamWriter writer =
        new StreamWriter(@"..\..\..\Ex2.txt");
        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }

    }
}
