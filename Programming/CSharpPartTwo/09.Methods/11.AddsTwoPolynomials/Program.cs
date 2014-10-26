using System;
class Program
{
    static int[] PolynomialInput()
    {
        Console.WriteLine("Enter coefficient 'a'");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient 'b'");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient 'c'");
        int c = int.Parse(Console.ReadLine());
        int[] array = new int[] { a, b, c };
        return array;
    }
    static void AddsPolynomials(int[] polynomial1, int[] polinomial2)
    {
        int[] sumOfPolinomials = new int[polynomial1.Length];
        for (int i = 0; i < polynomial1.Length; i++)
        {
            sumOfPolinomials[i] = polynomial1[i] + polinomial2[i];
        }
        Console.WriteLine("New polynomial is: {0}*x*x + {1}*x + {2}", sumOfPolinomials[0], sumOfPolinomials[1], sumOfPolinomials[2]);
    }

    static void Main()
    {
        int[] polynomial1 = PolynomialInput();
        int[] polynomial2 = PolynomialInput();
        AddsPolynomials(polynomial1, polynomial2);
    }
}
