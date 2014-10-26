using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string[] arrayDigits = new string[9] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
        string number = Console.ReadLine();
        BigInteger result = 0;
        List<string> separatedDigits = new List<string>();
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '-' && number[i + 1] == '!')
            {
                separatedDigits.Add(String.Format("{0}{1}", number[i], number[i + 1]));
                i++;
            }
            else if (number[i] == '*' && number[i + 1] == '*')
            {
                separatedDigits.Add(String.Format("{0}{1}", number[i], number[i + 1]));
                i++;
            }
            else if (i + 2 <= number.Length && number[i] == '!' && number[i + 1] == '!' && number[i + 2] == '!')
            {
                separatedDigits.Add(String.Format("{0}{1}{2}", number[i], number[i + 1], number[i + 2]));
                i += 2;
            }
            else if (number[i] == '&' && number[i + 1] == '&')
            {
                separatedDigits.Add(String.Format("{0}{1}", number[i], number[i + 1]));
                i++;
            }
            else if (number[i] == '&' && number[i + 1] == '-')
            {
                separatedDigits.Add(String.Format("{0}{1}", number[i], number[i + 1]));
                i++;
            }
            else if (number[i] == '!' && number[i + 1] == '-')
            {
                separatedDigits.Add(String.Format("{0}{1}", number[i], number[i + 1]));
                i++;
            }
            else if (i + 3 <= number.Length && number[i] == '*' && number[i + 1] == '!' && number[i + 2] == '!' && number[i + 3] == '!')
            {
                separatedDigits.Add(String.Format("{0}{1}{2}{3}", number[i], number[i + 1], number[i + 2], number[i + 3]));
                i += 3;
            }
            else if (i + 2 <= number.Length && number[i] == '&' && number[i + 1] <= '*' && number[i + 2] == '!')
            {
                separatedDigits.Add(String.Format("{0}{1}{2}", number[i], number[i + 1], number[i + 2]));
                i += 2;
            }

            else
            {
                separatedDigits.Add(String.Format("{0}{1}{2}{3}{4}{5}", number[i], number[i + 1], number[i + 2], number[i + 3], number[i + 4], number[i + 5]));
                i += 5;
            }
        }
        for (int i = 0; i < separatedDigits.Count; i++)
        {
            result += (ulong)(Math.Pow(9, (separatedDigits.Count - 1 - i))) * (ulong)Array.IndexOf(arrayDigits, separatedDigits[i]);
        }
        Console.WriteLine(result);
    }
}
