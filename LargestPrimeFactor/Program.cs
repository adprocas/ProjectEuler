using System;
using EulerGeneralLibrary;

namespace Euler3LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToTest = 600851475143;
            double maxNumberToTest = Math.Ceiling(Math.Sqrt(numberToTest));

            for (double x = maxNumberToTest; x > 2; x--)
            {
                if(numberToTest % x == 0 && x.IsPrime())
                {
                    Console.WriteLine(x.ToString());

                    break;
                }
            }
        }
    }
}
