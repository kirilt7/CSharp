using System;

class Program
{
    static void Menu()
    {
        Console.WriteLine("Choose 1 to reverse the digits of a number.");
        Console.WriteLine("Choose 2 to calculates the average of a sequence of integers.");
        Console.WriteLine("Choose 3 to solve a linear equation a * x + b = 0.");
    }
    static void Choice(byte n)
    {
        switch (n)
        {
            case 1:
                {
                    Console.WriteLine("Enter a number!:");
                    int number = int.Parse(Console.ReadLine()); ReversedNumber(number); break;
                }
            case 2:
                {
                    Console.WriteLine("What's the length of the array? ");
                    int number = int.Parse(Console.ReadLine());
                    Average(number); break;
                }
            case 3:
                {
                    Console.WriteLine("Enter 'a'");
                    decimal a = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 'b'");
                    decimal b = decimal.Parse(Console.ReadLine());
                    Equation(a, b);
                    break;
                }
            default: Console.WriteLine("Inavlid choice!!"); break;
        }
    }

    static void ReversedNumber(int number)
    {

        int reverse = 0;
        if (number > 0)
        {
            while (number > 0)
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine("The reversed number is {0}", reverse);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
    static void Average(int n)
    {
        decimal result = 0;
        int sum = 0;
        if (n > 0)
        {
            Console.WriteLine("Enter numbers:");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            result = (decimal)sum / n;
            Console.WriteLine("The average of a sequence of integers is {0}", result);
        }
        else
        {
            Console.WriteLine("Not a valid input!");
        }
    }

    static void Equation(decimal a, decimal b)
    {
        decimal result = 0;
        if (a == 0)
        {
            Console.WriteLine("Incorect input!!!");
        }
        else
        {
            result = b / a;
        }
        Console.WriteLine("In the equation of {0}*x+{1}=0, x={2}", a, b, result);
    }

    static void Main()
    {
        while (true)
        {
            Menu();
            byte userChoice = byte.Parse(Console.ReadLine());
            Choice(userChoice);
        }
    }
}