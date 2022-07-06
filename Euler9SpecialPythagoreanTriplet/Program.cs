using System;

namespace Euler9SpecialPythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            int x = 1000;

            GetTriplet(ref a, ref b, ref c, x);

            Console.WriteLine((a * b * c).ToString());
        }

        private static void GetTriplet(ref int a, ref int b, ref int c, int x)
        {
            for (a = 1; a < x - 2; a++)
            {
                for (b = 2; b < x - 1; b++)
                {
                    for (c = 3; c < x; c++)
                    {
                        if ((a + b + c == x) && ((a * a) + (b * b) == (c * c)))
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}