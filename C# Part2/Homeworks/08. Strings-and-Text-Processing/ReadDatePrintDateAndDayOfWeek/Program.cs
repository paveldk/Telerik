/*Write a program that reads a date and time given in the format: day.month.year 
 * hour:minute:second and prints the date and time after 6 hours and 30 minutes 
 * (in the same format) along with the day of week in Bulgarian.
 * */
namespace ReadDatePrintDateAndDayOfWeek
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            

            string dateAsString = "13.1.2014 13:36:00";

            DateTime date;
            
            // again TryParse method, that we convert from String to DateTime
            DateTime.TryParse(dateAsString, out date);

            // add 6.5 hours (6:30)
            date = date.AddHours(6.5);

            // and print the new date with the day with BG culture
            Console.WriteLine("The date after 6:30 hours is {0:dd.MM.yyyy HH:mm:ss} and it's {1}", date, date.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
