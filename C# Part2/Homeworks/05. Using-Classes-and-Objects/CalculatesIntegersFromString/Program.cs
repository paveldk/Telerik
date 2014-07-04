/* You are given a sequence of positive integer values written into a string, 
 * separated by spaces. Write a function that reads these values from given string 
 * and calculates their sum. Example:
 *      string = "43 68 9 23 318"  result = 461
 * */

namespace CalculatesIntegersFromString
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string integersInString = "06 78 45 -12";
            Console.WriteLine(CalculateIntegersFromString(integersInString));
        }

        static int CalculateIntegersFromString(string integersInString)
        {
            //// To devide the string to parts we use String.Split method with devider space and add all to string array
            string[] parts = integersInString.Split(' ');
            int sum = 0;

            // Then we make loop for all elements in this array and accumulate them in sum variable
            for (int i = 0; i < parts.Length; i++)
            {
                sum = sum + Convert.ToInt32(parts[i]);        
            }

            // at the end we return it:
            return sum;
        }
    }
}
