/*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or 
 * non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 * */
namespace ReadIntegerCheckIfInvalid
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = 0;

            // create a loop from 0 to 8(first time we do it twice, so it's 10 times total)
            for (int i = 0; i < 9; i++)
            {
                if (number == 0)
                {
                    // if it's for the first time we use method with 1 and 100 as indexes
                    number = ReadNumber(1, 100);        
                }  
 
                // if not we use it with number as start index, that way we need to enter each time bigger number
                number = ReadNumber(number, 100);
            }
        }

        static int ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                // if the number isn't between indexes - exceptions
                if (number < start || number > end)
                {
                    throw new Exception("Invalid number");
                }

                return number;
            }
            catch (FormatException)
            {
                // if we enter text again exception - specific one
                Console.WriteLine("This isn't a number");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
                return 0;
            }           
        }
    }
}
