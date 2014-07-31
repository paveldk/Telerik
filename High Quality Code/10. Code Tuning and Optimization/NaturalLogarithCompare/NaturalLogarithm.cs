/* Task 3 : Write a program to compare the performance of square root, NATURAL LOGARITHM, 
 * sinus for float, double and decimal values.
 * */
namespace NaturalLogarithmCompare
{
    using System;
    using System.Diagnostics;

    public class NaturalLogarithm
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rand = new Random();
            float floatNumber = 1f;
            double doubleNumber = 1d;
            decimal decimalNumber = 1m;
            int testRounds = 10000000;

            Console.WriteLine("Natural Logarithm testing:");

            // Float
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                floatNumber = (float)Math.Log(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Float natural logarithm, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                doubleNumber = Math.Log(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Double natural logarithm, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                decimalNumber = (decimal)Math.Log(rand.Next(1, 100));
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal natural logarithm, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
