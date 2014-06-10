/* Task 2 : Write a program to compare the performance of add, substract, increment, MULTIPLY, 
 * divide for int, long, float, double and decimal values.
 * */
namespace MultiplyCompare
{
    using System;
    using System.Diagnostics;

    public class Multiply
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rand = new Random();
            int intNumber = 1;
            long longNumber = 1L;
            float floatNumber = 1f;
            double doubleNumber = 1d;
            decimal decimalNumber = 1m;
            int testRounds = 10000000;

            Console.WriteLine("Multiply testing:");

            // Int
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                intNumber = intNumber * rand.Next(0, 10);
            }

            stopwatch.Stop();
            Console.WriteLine("Int multiply, time elapsed: {0}", stopwatch.Elapsed);

            // Long
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                longNumber = longNumber * rand.Next(0, 10);
            }

            stopwatch.Stop();
            Console.WriteLine("Long multiply, time elapsed: {0}", stopwatch.Elapsed);

            // Float
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                floatNumber = floatNumber * rand.Next(0, 10);
            }

            stopwatch.Stop();
            Console.WriteLine("Float multiply, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                doubleNumber = doubleNumber * rand.Next(0, 10);
            }

            stopwatch.Stop();
            Console.WriteLine("Double multiply, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                decimalNumber = decimalNumber * rand.Next(0, 10);
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal multiply, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
