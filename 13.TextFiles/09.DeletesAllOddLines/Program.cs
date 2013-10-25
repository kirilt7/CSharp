using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        try
        {
            StreamReader reader =
                new StreamReader(@"..\..\..\Ex.txt");
            List<string> textWithoutOddLines = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                int i = 0;
                
                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        textWithoutOddLines.Add(line);
                        i++;
                    }
                    line = reader.ReadLine();
                    lineNumber++;

                }
            }
            StreamWriter writer =
                new StreamWriter(@"..\..\..\Ex.txt");
            using (writer)
            {
                for (int i = 0; i < textWithoutOddLines.Count; i++)
                {
                    writer.WriteLine(textWithoutOddLines[i]);
                }
            }
        }
        catch (IOException ioex)
        {

            Console.WriteLine(ioex.Message);
        }

    }

    private static void List<T1>()
    {
        throw new NotImplementedException();
    }
}