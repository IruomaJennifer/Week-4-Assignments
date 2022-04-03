using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int length = GetStringLength("Iruoma");
            //Console.WriteLine($"Length of the String is {length}"); 
            //PrintPrimeNumbers(1,20);
            //RandomNumbers(1, 20);
            
        }
        static int GetStringLength(string inputString,int indexNumber=0)
        {
         
            if (indexNumber == inputString.Length)
            {
                return 0;
            }
            else
            {
                
                int lengthOfString = 1 + GetStringLength(inputString, indexNumber+1);
                Console.WriteLine($"Character {indexNumber+1} is {inputString[indexNumber]}");
                return lengthOfString;
            }
            
        }

        static void PrintPrimeNumbers(int start, int end)
        {
            if (start > end)
            {
                return;
            }
            else
            {
                List<int> factors = new List<int>();
                for (int i = 1; i < end+1; i++)
                {
                    if ((start % i) == 0)
                    {
                        factors.Add(i);
                    }
                    
                }
                if (factors.Count < 3)
                {
                    Console.WriteLine(start);
                }
                PrintPrimeNumbers(start + 1,end);
            }
        }      

        static void RandomNumbers(int start,int stop)
        {
            Console.WriteLine($"Some random numbers from {start} to {stop} are;");
            bool isNotRepeated = true;
            List<int> AllRandomNumbers = new List<int>();
            Random random = new Random();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int randomNumber = random.Next(start, stop);
            Console.WriteLine(randomNumber);
            while (isNotRepeated)
            {
                AllRandomNumbers.Add(randomNumber);
                randomNumber = random.Next(start, stop);
                if (AllRandomNumbers.Contains(randomNumber))
                {
                    isNotRepeated = false;
                }
                
                Console.WriteLine(randomNumber);
            }
            timer.Start();
            Console.WriteLine();
            Console.WriteLine($"{randomNumber} is repeated in {timer.ElapsedMilliseconds} milliseconds");
        }
    }
}
