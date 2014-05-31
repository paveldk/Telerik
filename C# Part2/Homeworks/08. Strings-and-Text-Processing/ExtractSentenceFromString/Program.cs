/*Write a program that extracts from a given text all sentences containing given word.
 * Example: The word is "in". The text is:
 * We are living in a yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day. 
 * We will move out of it in 5 days.
 * The expected result is:
 * We are living in a yellow submarine.
 * We will move out of it in 5 days.
 * Consider that the sentences are separated by "." and the words – by non-letter symbols.
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
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string searchWord = " in ";

            // First we split our text to sentences
            string[] sentences = text.Split('.');

            // after that we loop all the sentences
            for (int i = 0; i < sentences.Length; i++)
            {
                // if in any of them we find the searchword
                if (Regex.Matches(sentences[i], @"\b" + searchWord + @"\b").Count > 0)
                {
                    // we print it
                    Console.WriteLine((sentences[i] + ".").Trim());
                }
            }          
        }
    }
}
