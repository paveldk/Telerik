/* Write a program that reads two dates in the format: day.month.year and calculates the 
 * number of days between them. Example:
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2004
 * Distance: 4 days
 * */
namespace CalculateDayDifference
{
    using System;

    class Program
    {
        static void Main()
        {
            string firstDateString = "27.02.2006";
            string secondDateString = "25.02.2006";

            DateTime firstDate;
            DateTime secondDate;

            // first we use TryParse method, that we convert from String to DateTime
            DateTime.TryParse(firstDateString, out firstDate);
            DateTime.TryParse(secondDateString, out secondDate);

            // and with DateTime variable we can easily calculate the difference
            TimeSpan result = secondDate - firstDate;

            int days = result.Days;

            // but if secondDate is before first the difference gonna be negative
            if (days < 0)
            {
                // and we need to inverse it - the difference is always positive at least IMO
                days = -days;
            }

            // and we print it - voila
            Console.WriteLine("Distance: {0} days", days);

        }
    }
}
