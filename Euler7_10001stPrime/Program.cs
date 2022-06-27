using System;
using EulerGeneralLibrary;

namespace Euler7_10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int nthPrime = 10001;
            int foundPrimes = 1; //2 is prime, but I want to start at 3
            double currentNumber = 3;

            for(; ; )
            {
                if (currentNumber.IsPrime())
                {
                    foundPrimes++;
                }

                if(foundPrimes == nthPrime)
                {
                    break;
                }

                currentNumber += 2;
            }

            Console.WriteLine(currentNumber.ToString());
        }
    }
}
