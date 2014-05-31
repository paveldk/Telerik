/* Write a program that prints to the console which day of the week is today. 
 * Use System.DateTime.
 * */

namespace WhichDayIsToday
{
    using System;

    class Program
    {
        static void Main()
        {
            DateTime today = new DateTime();
            today = DateTime.Today;

            Console.WriteLine("Today is {0}.", today.DayOfWeek);
        }
    }
}
