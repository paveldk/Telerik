/* Task 1 : Write a program to compare the performance of ADD, subtract, increment, multiply, 
 * divide for int, long, float, double and decimal values.
 * */

namespace AddCompare
{
    using System;
    using System.Diagnostics;

    public class Add
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

            Console.WriteLine("Add testing:");

             // Int
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                intNumber = intNumber + rand.Next(0, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Int add, time elapsed: {0}", stopwatch.Elapsed);

            // Long
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                longNumber = longNumber + rand.Next(0, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Long add, time elapsed: {0}", stopwatch.Elapsed);

            // Float
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                floatNumber = floatNumber + rand.Next(0, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Float add, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                doubleNumber = doubleNumber + rand.Next(0, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Double add, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                decimalNumber = decimalNumber + rand.Next(0, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal add, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
