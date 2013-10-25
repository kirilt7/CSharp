using System;

class ASCIITable
{
    static void Main(string[] args)
    {
        char symbol = '\u0000';
        for (int i = 0; i <= 127; i++)
        {
            Console.WriteLine("Caracter {0} = {1}", i, symbol);
            symbol++;
        }
    }
}