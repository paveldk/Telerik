/*We are given a string containing a list of forbidden words and a text containing some of 
 * these words. Write a program that replaces the forbidden words with asterisks. 
 * Example:
 * Microsoft announced its next generation PHP compiler today. It is based on .NET 
 * Framework 4.0 and is implemented as a dynamic language in CLR.
 * Words: "PHP, CLR, Microsoft"
 * The expected result:
 * ********* announced its next generation *** compiler today. It is based on .NET 
 * Framework 4.0 and is implemented as a dynamic language in ***.
 * */
namespace CountSubstringInString
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            // string text = Console.ReadLine();
            // string searchWord = Console.ReadLine();
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = new string[] { "PHP", "CLR", "Microsoft" };

            // one simple loop for every forbidden word and replacing them by exact number of *
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));                        
            }

            Console.WriteLine(text);
        }
    }
}
