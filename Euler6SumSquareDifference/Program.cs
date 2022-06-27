using System;

namespace Euler6SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumSquareDifference = 100;

            Console.WriteLine((SquareOfSums(sumSquareDifference) - SumOfSquares(sumSquareDifference)).ToString());
        }

        private static long SumOfSquares(int value)
        {
            long result = 0;

            for (int x = 1; x <= value; x++)
            {
                result += (x * x);
            }

            return result;
        }

        private static long SquareOfSums(int value)
        {
            long result = 0;

            for (int x = 1; x <= value; x++)
            {
                result += x;    
            }

            return result * result;
        }
    }
}
