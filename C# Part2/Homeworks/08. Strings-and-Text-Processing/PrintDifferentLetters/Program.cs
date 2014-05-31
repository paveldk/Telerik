/* Write a program that reads a string from the console and prints all different letters 
 * in the string along with information how many times each letter is found. 
 * */
namespace PrintDifferentLetters
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string text = @"ABBA   ,.,a.,";

            // we gonna use Dictionary - in Dictionary we can use as key string, and it's not possible to have 2 same keys
            Dictionary<string, int> letters = new Dictionary<string, int>();

            // so for every single char in text
            for (int i = 0; i < text.Length; i++)
            {
                // we check if it's letter - from a to z, or from A to Z
                if (Regex.IsMatch("" + text[i], @"[a-z]|[A-Z]"))
                {
                    // if it's letter and allready in Dictionary we increase it's value - +1
                    if (letters.ContainsKey("" + text[i]))
                    {
                        int value = letters["" + text[i]];
                        letters["" + text[i]] += 1;
                    }
                    else
                    {
                        // if not we add it with value 1
                        letters.Add("" + text[i], 1);
                    }                   
                }    
            }

            foreach (var letter in letters)
            {
                Console.WriteLine(letter);    
            }
        }
    }
}
