/* Task 3 : Write a program to compare the performance of SQUARE ROOT, natural logarithm, 
 * sinus for float, double and decimal values.
 * */
namespace SquareRootCompare
{
    using System;
    using System.Diagnostics;

    public class SquareRoot
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rand = new Random();
            float floatNumber = 1f;
            double doubleNumber = 1d;
            decimal decimalNumber = 1m;
            int testRounds = 10000000;

            Console.WriteLine("Square root testing:");
         
            // Float
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                floatNumber = (float)Math.Sqrt(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Float square root, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                doubleNumber = Math.Sqrt(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Double square root, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                decimalNumber = (decimal)Math.Sqrt(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal square root, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
