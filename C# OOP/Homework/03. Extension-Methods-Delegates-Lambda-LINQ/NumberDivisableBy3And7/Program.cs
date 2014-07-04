/* Write a program that prints from given array of integers all numbers that are 
 * divisible by 7 and 3. Use the built-in extension methods and lambda expressions. 
 * Rewrite the same with LINQ.
 * */

namespace NumberDivisableBy3And7
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] intArray = new int[] { 3, 6, 8, 123, 14, 21, 52, 42 };

            // Lambda expression checking if x has remainder 0 when devided to 7 AND 3
            Console.WriteLine("Lambda");

            int[] resultLambda = intArray.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();

            foreach (var number in resultLambda)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("LINQ");
            
            // again here the same just with LINQ
            var resultLINQ =
                from number in intArray
                where number % 3 == 0 && number % 7 == 0
                select number;
            
            foreach (var number in resultLINQ)
            {
                Console.WriteLine(number);
            }
        }
    }
}
