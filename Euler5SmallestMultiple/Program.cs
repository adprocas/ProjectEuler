using System;
using EulerGeneralLibrary;

namespace Euler5SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestTest = 19 * 20;

            for(int x = smallestTest; ; x++)
            {
                if(IsDivisible(x))
                {
                    Console.WriteLine(x.ToString());

                    break;
                }
            }
        }

        static bool IsDivisible (int x)
        {
            for (int i = 1; i <= 20; i++)
            {
                if(!x.IsMultipleOf(i))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
