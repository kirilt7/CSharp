//Write a program that creates an array containing all letters from the alphabet (A-Z).//Read a word from the console and print the index of each of its letters in the array.
using System;
class Alphabet
{
    static void Main()
    {
        int alphabetCount = 26;
        int[] alphabet = new int [alphabetCount];
        for (int i = 0; i < alphabetCount; i++)
        {
            alphabet[i] = 'A' + i; 
        }
        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
			{
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine(alphabet[j]);
                }
			}
        }
    }
}
