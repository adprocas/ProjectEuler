using System;
using EulerGeneralLibrary;

namespace Euler2EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 4000000;
            int sumOfEvenTerms = 0;
            int y = 2;

            for (int x = 1; x < maxValue; )
            {
                if (y.IsMultipleOf(2))
                {
                    sumOfEvenTerms += y;
                }

                int tmpX = x;
                x = y;
                y += tmpX;
            }

            Console.WriteLine(sumOfEvenTerms.ToString());
        }
    }
}
