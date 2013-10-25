using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            StreamReader reader =
                new StreamReader(@"..\..\..\Ex.txt");
            StreamReader reader2 =
                     new StreamReader(@"..\..\..\Ex2.txt");
            StreamWriter writer =
                     new StreamWriter(@"..\..\..\Ex3.txt");
            
            using (reader2)
            {
                using (reader)
                {
                    using (writer)
                    {
                        string concText = "";
                        concText += reader.ReadToEnd();
                        concText += reader2.ReadToEnd();
                        writer.WriteLine(concText);
                    }
                }
                
            }
        }
        catch (IOException ioex)
        {

            Console.WriteLine(ioex.Message);
        }
    }
}
