//07. Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by 
//performing XOR (exclusive or) operation over the first letter of the string with 
//the first of the key, the second – with the second, etc. When the last key character 
//is reached, the next is the first.
using System;
using System.Text;
class Program
{
    static string Encrypt(string text, string key)
    {
        var encryptedText = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
            encryptedText.Append((char)(text[i] ^ key[i % key.Length]));

        return encryptedText.ToString();
    }

    static string Decrypt(string text, string key)
    {
        return Encrypt(text, key);
    }

    static void Main()
    {
        Console.WriteLine("Enter text to encode: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter code: ");
        string key = Console.ReadLine();
        string encodedText = Encrypt(text, key);
        string decodedText = Decrypt(encodedText, key);
        Console.WriteLine("The encoded text is:\n{0}", encodedText);
        Console.WriteLine("The decoded text is:\n{0}", decodedText);
        
    }
}