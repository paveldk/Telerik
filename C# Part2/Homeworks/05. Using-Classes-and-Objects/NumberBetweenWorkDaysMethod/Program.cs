/* Write a method that calculates the number of workdays between today and 
 * given date, passed as parameter. Consider that workdays are all days from 
 * Monday to Friday except a fixed list of public holidays specified preliminary 
 * as array.
 * */

namespace NumberBetweenWorkDaysMethod
{
    using System;

    class Program
    {       
        static void Main()
        {
            DateTime secondDate = new DateTime(2014, 1, 28);
            Console.WriteLine("The numbers of work days between today and {0} are {1}.", secondDate, NumberOfWorkDays(secondDate));
        }

        static int NumberOfWorkDays(DateTime secondDate)
        {
            // Array for the holidays, we can add how many we want
            DateTime[] holidays = new DateTime[] 
            {
                new DateTime(2014, 1, 25),
                new DateTime(2014, 1, 26)
            };
            
            // get the today
            DateTime today = new DateTime();
            today = DateTime.Today;

            // check if today is AFTER the second date - it shouldn't be that way
            if (today > secondDate)
            {
                throw new ArgumentException("Incorrect last day " + secondDate);
            }
            
            // we get ALL days between the two dates
            int businessDays = (secondDate - today).Days;
            
            // and calculate how many full weeks we have in the interval
            int fullWeeks = businessDays / 7;

            // if the days are more than the fullweeks*7 we have not a exact number of weeks(7,14,21,28)
            if (businessDays > fullWeeks * 7)
            {
                //// we get which day of the week is today
                int firstDayOfWeek = (int)today.DayOfWeek;

                // and which day of the week is the second date
                int lastDayOfWeek = (int)secondDate.DayOfWeek;

                // if today is after second date as day of the week(Today is Thursday second date is Wednesday) we add 7
                if (lastDayOfWeek < firstDayOfWeek)
                {
                    lastDayOfWeek += 7;
                }
                    
                // if today is Saturday of before
                if (firstDayOfWeek <= 6)
                {
                    // and second date, or second date +7 is more or equal than 7 both Saturday and Sunday are in the remaining time interval (-2)
                    if (lastDayOfWeek >= 7) 
                    {
                        businessDays -= 2;
                    }                                      
                    else if (lastDayOfWeek >= 6)
                    {
                        // if more and equal to 6 only Saturday (-1)
                        businessDays -= 1;
                    }                       
                }               
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)
                {
                    // Only Sunday is in the remaining time interval (-1)
                    businessDays -= 1;
                }                    
            }

            // subtract the weekends during the full weeks in the interval
            businessDays -= fullWeeks + fullWeeks;

            // subtract the number of holidays during the time interval from the array
            foreach (DateTime date in holidays)
            {
                DateTime holiday = date.Date;
                if (today <= holiday && holiday <= secondDate)
                {
                    --businessDays;
                }                  
            }

            // and we got our final days
            return businessDays;
        }
    }
}
