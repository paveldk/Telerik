/* Define a class InvalidRangeException<T> that holds information about an error condition 
 * related to invalid range. It should hold error message and a range definition [start … 
 * end].
 * Write a sample application that demonstrates the InvalidRangeException<int> 
 * and InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
 * and dates in the range [1.1.1980 … 31.12.2013].
 * */

namespace CustomExceptions
{
    using System;

    class MainClass
    {
        static void Main()
        {
            // Integers. Try to set the number <0 or >100 and the exception will be raised
            int number = 0;
            int minNumber = 0;
            int maxNumber = 100;
            Console.Write("Insert number in the range {0}-{1}: ", minNumber, maxNumber);
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < minNumber || number > maxNumber)
                {
                    throw new InvalidRangeException<int>("Number is not in range.", number, minNumber, maxNumber);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("InvalidRangeException: Number {0} in the range {1}-{2}.", number, e.MinValue, e.MaxValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            // Same for dates, here it's between 1.1.1980 and 31.12.2013
            DateTime date = new DateTime(2010, 1, 1);
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            // try to put 2014-1-1 and the exception gonna be raised
            Console.Write("Insert date in the range {0}-{1}: ", startDate, endDate);
            try
            {
                date = DateTime.Parse(Console.ReadLine());
                if (date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Date is not in range.", date, startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("InvalidRangeException: The Date {0} in the range {1}-{2}.", date, e.MinValue, e.MaxValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
