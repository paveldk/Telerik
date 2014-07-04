/* Write a program that generates and prints to the console 10 random values 
 * in the range [100, 200].
 * */

namespace RandomValuesInRange
{
    using System;

    class Program
    {
        static void Main()
        {
            // First we initialize new random variable
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                // and then we use the Next method with constructor using start and end values
                Console.WriteLine(rand.Next(100, 200));    
            }
        }
    }
}
