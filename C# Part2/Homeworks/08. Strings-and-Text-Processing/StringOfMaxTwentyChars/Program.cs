/* Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be 
 * filled with '*'. Print the result string into the console.
 * */
namespace StringOfMaxTwentyChars
{
    using System;

    class Program
    {
        static void Main()
        {
            int maxLength = 20;
            string text = Console.ReadLine();

            if (text.Length > maxLength)
            {
                // if the length is more than 20 we cut the string to 20 chars
                text = text.Substring(0, maxLength);
            }
            else if (text.Length < maxLength)
            {
                // if the lenght is less than 20 we add * to the maxLength - 20
                text = text.PadRight(maxLength, '*');
            }

            Console.WriteLine(text);
        }
    }
}
