/* Task 2 : Write a program to compare the performance of add, substract, INCREMENT, multiply, 
 * divide for int, long, float, double and decimal values.
 * */
namespace IncrementCompare
{
    using System;
    using System.Diagnostics;

    public class Increment
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rand = new Random();
            int intNumber = 0;
            long longNumber = 0L;
            float floatNumber = 0f;
            double doubleNumber = 0d;
            decimal decimalNumber = 0m;
            int testRounds = 10000000;

            Console.WriteLine("Incement testing:");

            // Int
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                intNumber = intNumber++;
            }

            stopwatch.Stop();
            Console.WriteLine("Int increment, time elapsed: {0}", stopwatch.Elapsed);

            // Long
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                longNumber = longNumber++;
            }

            stopwatch.Stop();
            Console.WriteLine("Long increment, time elapsed: {0}", stopwatch.Elapsed);

            // Float
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                floatNumber = floatNumber++;
            }

            stopwatch.Stop();
            Console.WriteLine("Float increment, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                doubleNumber = doubleNumber++;
            }

            stopwatch.Stop();
            Console.WriteLine("Double increment, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                decimalNumber = decimalNumber++;
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal increment, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}