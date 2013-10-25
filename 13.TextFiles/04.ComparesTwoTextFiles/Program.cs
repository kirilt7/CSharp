using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            StreamReader reader =
                new StreamReader(@"..\..\..\Ex4.txt");
            StreamReader reader2 =
                     new StreamReader(@"..\..\..\Ex5.txt");
            using (reader2)
            {
                using (reader)
                {
                    string lineFromFirstFile = reader.ReadLine();
                    string lineFromSecondFile = reader2.ReadLine();
                    int sameLines = 0;
                    int differentLines = 0;
                    while (lineFromFirstFile != null)
                    {
                        if (lineFromFirstFile == lineFromSecondFile)
                        {
                            sameLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                        lineFromFirstFile = reader.ReadLine();
                        lineFromSecondFile = reader2.ReadLine();
                    }
                    Console.WriteLine("Number of lines that are the same is: {0}", sameLines);
                    Console.WriteLine("Number of lines that are different is: {0}", differentLines);
                }

            }
        }
        catch (IOException ioex)
        {

            Console.WriteLine(ioex.Message);
        }
    }
}
