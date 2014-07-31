/* Task 3 : Write a program to compare the performance of square root, natural logarithm, 
 * SINUS for float, double and decimal values.
 * 
 * Same here, again Decimal 2 times slower
 * 
 * */
namespace SinusCompare
{
    using System;
    using System.Diagnostics;

    public class Sinus
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rand = new Random();
            float floatNumber = 1f;
            double doubleNumber = 1d;
            decimal decimalNumber = 1m;
            int testRounds = 10000000;

            Console.WriteLine("Sinus testing:");

            // Float
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                floatNumber = (float)Math.Sin(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Float sinus, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                doubleNumber = Math.Sin(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Double sinus, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                decimalNumber = (decimal)Math.Sin(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal sinus, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
