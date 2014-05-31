/* Write a program that reads a list of words, separated by spaces and prints the list 
 * in an alphabetical order.
 * */
namespace ReadWordsPrintThemAlphabeticly
{
    using System;

    class Program
    {
        static void Main()
        {
            string text = "Words separated only by spacec";

            // since we know that they gonna be separated only by spaces, we add only spaces to Split Method
            string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            // then we Sort the Array
            Array.Sort(words);

            // and we print them
            foreach (var word in words)
            {
                Console.WriteLine(word);    
            }
        }
    }
}
