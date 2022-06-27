using System;
using EulerGeneralLibrary;

namespace Euler4LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestThreeDigitNumber = 999;
            int largestPalindrome = 0;

            if(largestThreeDigitNumber.IsPalindrome())
            {
                Console.WriteLine(largestThreeDigitNumber.ToString());
            }

            //loop through integers, starting with 999
            for(int x = largestThreeDigitNumber; x > 0; x--)
            {
                //loop through second integer, starting with 999
                for (int y = largestThreeDigitNumber; y > 0; y--) 
                {
                    int intProduct = x * y;

                    if (intProduct.IsPalindrome() && intProduct > largestPalindrome)
                    {
                        largestPalindrome = intProduct;
                    }

                    if(y <= intProduct)
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(largestPalindrome.ToString());
        }
    }
}
