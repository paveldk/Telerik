/* Write a program that reads a string from the console and lists all different words in 
 * the string along with information how many times each word is found.
 * */
namespace PrintDifferentWords
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string text = @"ABBA   ,.,a.,       ABBA!!!ABBA!AB!BA";

            // we split by anything we can imagine - we can add everything as seperators, we want just words
            string[] words = text.Split(new char[] { ',', ' ', '!', '?', '-', '=', ':', ';', '.', '/' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> countWords = new Dictionary<string, int>();

            // so new have all words in array
            for (int i = 0; i < words.Length; i++)
            {
                // we can check them if exists and not in Dictionary - if Yes increase their value
                if (countWords.ContainsKey("" + words[i]))
                {
                    int value = countWords["" + words[i]];
                    countWords["" + words[i]] += 1;
                }
                else
                {
                    // if not we add them with value 1
                    countWords.Add("" + words[i], 1);
                }
            }

            // and again print
            foreach (var counts in countWords)
            {
                Console.WriteLine(counts);
            }
        }
    }
}
