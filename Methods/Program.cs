using System;
using Humanizer;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void GetQuadraticRoots()
        {
            Console.WriteLine("To get the roots of equations of type ax^2+bx+C");
            Console.WriteLine();
            Console.WriteLine("Input a value for a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input a value for b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input a value for c");
            double c = double.Parse(Console.ReadLine());
            double x1;
            double x2;
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
            if ((Math.Pow(b, 2) - 4 * a * c) < 0)
            {
                x1 = double.NaN;
                x2 = double.NaN;
            }
            Console.WriteLine($"The roots of the equation are {{{x1},{x2}}}");
        }
        static int GetFactorial(int number)
        {
            int factorial = 1;
            while(number > 0)
            {
                factorial *= number;
                number--;
            }
            return factorial;

        }
        static string GetWordNumber(int number)
        {
            string wordNumber;
            if (number >= 1 && number <= 100)
            {
              wordNumber =  number.ToWords();
                return wordNumber;
            }
            else
            {
                return "Please enter a number between 1 and 100";
            }
        }
        static int TotalNumberOfChars(string stringValue)
        {
            return stringValue.Length;
        }
    }
}
