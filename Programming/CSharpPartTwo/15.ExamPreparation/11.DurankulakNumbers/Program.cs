using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> digits = new List<string>();
        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }
        for (char i = 'a'; i <= 'f'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString() + j);
            }
        }
        string[] arrayDigits = new string[168];
        for (int i = 0; i < 168; i++)
			{
			    arrayDigits[i]=digits[i];
			}
        string number = Console.ReadLine();
        ulong result = 0;
        List<string> separatedDigits = new List<string>();
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i]>='a' && number[i]<='f')
            {
                separatedDigits.Add(String.Format("{0}{1}",number[i], number[i+1]));
                i++;
            }
            else
            {
                separatedDigits.Add(number[i].ToString());
            }
        }
        for (int i = 0; i < separatedDigits.Count; i++)
        {
            result += (ulong)(Math.Pow(168, (separatedDigits.Count - 1 - i))) * (ulong)Array.IndexOf(arrayDigits, separatedDigits[i]);
        }
        Console.WriteLine(result);
    }
}
