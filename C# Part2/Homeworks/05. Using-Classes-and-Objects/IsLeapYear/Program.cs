/* Write a program that reads a year from the console and checks whether it is a 
 * leap. Use DateTime.
 * 
 * */
namespace IsLeapYear
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Input year: ");           
            int year = int.Parse(Console.ReadLine());

            // To get if the year is leap we use the method IsLeapYear part of DateTime:
            Console.WriteLine("Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
        }
    }
}
