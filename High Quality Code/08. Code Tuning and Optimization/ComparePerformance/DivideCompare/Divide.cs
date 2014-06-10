/* Task 2 : Write a program to compare the performance of add, substract, increment, multiply, 
 * DIVIDE for int, long, float, double and decimal values.
 * 
 * General conclusion : Decimal is VERRYYYY SLOW :)
 * 
 * */
namespace DivideCompare
{
    using System;
    using System.Diagnostics;

    public class Divide
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

            Console.WriteLine("Divide testing:");

            // Int
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                intNumber = intNumber / rand.Next(1, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Int divide, time elapsed: {0}", stopwatch.Elapsed);

            // Long
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                longNumber = longNumber / rand.Next(1, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Long divide, time elapsed: {0}", stopwatch.Elapsed);

            // Float
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                floatNumber = floatNumber / rand.Next(1, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Float divide, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                doubleNumber = doubleNumber / rand.Next(1, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Double divide, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < testRounds; i++)
            {
                decimalNumber = decimalNumber / rand.Next(1, 100);
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal divide, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
