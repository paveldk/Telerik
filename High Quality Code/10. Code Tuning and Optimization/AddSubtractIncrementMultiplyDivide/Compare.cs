/* Task 1. Write a program to compare the performance of add, subtract, increment, multiply, 
 * divide for int, long, float, double and decimal values.
*/
namespace AddSubtractIncrementMultiplyDivide
{
    using System;
    using System.Diagnostics;

    public class Compare
    {
        static Stopwatch stopwatch = new Stopwatch();
        static int intNumber = 0;
        static long longNumber = 0;
        static float floatNumber = 0;
        static double doubleNumber = 0;
        static decimal decimalNumber = 0;

        public static void Main(string[] args)
        {
            AddCompare();             
        }

        public static void AddCompare()
        {
            // Int
            stopwatch.Start();

            for (int i = 0; i < 100000000; i++)
            {
                intNumber = intNumber + intNumber;
            }

            stopwatch.Stop();
            Console.WriteLine("Int add, time elapsed: {0}", stopwatch.Elapsed);

            // Long
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 100000000; i++)
            {
                longNumber = longNumber + longNumber;
            }

            stopwatch.Stop();
            Console.WriteLine("Long add, time elapsed: {0}", stopwatch.Elapsed);

            // Float
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 100000000; i++)
            {
                floatNumber = floatNumber + floatNumber;
            }

            stopwatch.Stop();
            Console.WriteLine("Float add, time elapsed: {0}", stopwatch.Elapsed);

            // Double
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 100000000; i++)
            {
                doubleNumber = doubleNumber + doubleNumber;
            }

            stopwatch.Stop();
            Console.WriteLine("Double add, time elapsed: {0}", stopwatch.Elapsed);

            // Decimal
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 100000000; i++)
            {
                decimalNumber = decimalNumber + decimalNumber;
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal add, time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
