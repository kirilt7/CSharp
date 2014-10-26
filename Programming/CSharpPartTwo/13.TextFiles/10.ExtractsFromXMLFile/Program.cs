using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader(@"../../../example.xml"))
            {
                for (int i; (i = reader.Read()) != -1; ) 
                {
                    if (i == '>') 
                    {
                        string text = String.Empty;
                        int j = reader.Read();
                        while ((j != -1) && (j != '<'))
                        {
                            text += (char)j;
                            j = reader.Read();
                        }
                        if (!string.IsNullOrEmpty(text))
                        {
                            Console.WriteLine(text);
                        }

                    }
                }
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
    }
}