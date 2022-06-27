
namespace Euler1MultiplesOf3And5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EulerGeneralLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            //sum all numbers that are multiples of 3 or 5 below 1000
            int startingValue = 0;
            int endingValue = 1000;
            int[] values = { 3, 5 };
            
            Console.WriteLine(GetSumOfValues(startingValue, endingValue, values).ToString());
        }

        private static int GetSumOfValues(int startingValue, int endingValue, int[] values)
        {
            int sumOfValues = 0;

            for (int i = 0; i < values.Length; ++i) 
            {
                IEnumerable<int> otherValues = from a in values where a < values[i] select a;

                for (int x = startingValue; x < endingValue; x += values[i])
                {
                    if (i == 0 || !x.IsMultipleOfAnyValue(otherValues.ToArray()))
                    {
                        sumOfValues += x;
                    }
                }
            }

            return sumOfValues;
        }
    }
}
