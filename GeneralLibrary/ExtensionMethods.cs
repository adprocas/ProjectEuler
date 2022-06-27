using System;
using System.Linq;

namespace EulerGeneralLibrary
{
    public static class ExtenionMethods
    {
        public static bool IsMultipleOf(this int input, int value)
        {
            return input % value == 0;
        }

        public static bool IsMultipleOfAnyValue(this int input, int[] values)
        {
            foreach (int i in values)
            {
                if(input.IsMultipleOf(i))
                {
                    return true;
                }
            }
            
            return false;
        }

        public static bool IsPrime(this double input)
        {
            double maxTestNumber = Math.Ceiling(Math.Sqrt(input));

            for (double x = 2; x <= maxTestNumber; x+=1) 
            {
                if (input % x == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPalindrome(this int input)
        {
            char[] charInput = input.ToString().ToCharArray();
            char[] reverseCharInput = new char[charInput.Length];

            for(int x = charInput.Length - 1; x >= 0; x--)
            {
                reverseCharInput.SetValue(charInput[x], (reverseCharInput.Length - 1) - x);
            }

            return charInput.SequenceEqual(reverseCharInput);
        }
    }
}