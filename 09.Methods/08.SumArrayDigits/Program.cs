using System;
using System.Collections.Generic;

class Program
{
    static List<int> SumDigits(int[] number1, int[] number2)
    {
        if (number2.Length > number1.Length)
        {
            return SumDigits(number2, number1);
        }
        else
        {
            List<int> result = new List<int>(0);
            int remebmber = 0;
            for (int i = 0; i < number1.Length; i++)
            {
                if (i>=number2.Length)
                {
                    if (remebmber==1)
                    {
                        if ((number1[1]+remebmber)>9)
                        {
                            if (i == number1.Length - 1)
                            {
                                result.Add(number1[i] + remebmber);
                            }
                            else
                            {
                                result.Add(number1[i] + remebmber - 10);
                                remebmber = 1;
                            }
                            
                        }
                        else
                        {
                            result.Add(number1[i] + 1);
                            remebmber = 0;
                        }
                                            }
                    else
                    {
                        result.Add(number1[i]);
                    }
                    
                }
                else
                {
                    if ((number1[i]+number2[i]+remebmber)>9)
                    {
                        if (i == number1.Length-1)
                        {
                            result.Add(number1[i]+number2[i]+remebmber);  
                        }
                        else
                        {
                            result.Add(number1[i] + number2[i] + remebmber - 10);
                            remebmber = 1;
                        }
                        
                    }
                    else
                    {
                        result.Add(number1[i]+number2[i]+remebmber);
                        remebmber = 0;
                    }
                }
            }
            return result;
        }
    }
    static int[] ReverseNumber(string number)
    {
        int[] reversedNumber=new int[number.Length];
        for (int i = 0; i < reversedNumber.Length; i++)
        {
            reversedNumber[i] = int.Parse(number[(number.Length - 1) - i].ToString());
        }
        return reversedNumber;
    }
    static void PrintNumber(List<int> list)
    {
        for (int i = list.Count-1; i >= 0; i--)
        {
            Console.Write(list[i]);
        }

        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Enter first interger: ");
        string number1 = Console.ReadLine();
        Console.WriteLine("Enter second interger: ");
        string number2 = Console.ReadLine();
        int[] reversedNumber1 = ReverseNumber(number1);
        int[] reversedNumber2 = ReverseNumber(number2);
        PrintNumber(SumDigits(reversedNumber1, reversedNumber2));
    }
}