/*Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!"  
 * "Delphi not and PHP, not C++ not is C#!".
 * */
namespace ReverseWordsInSentence
{
    using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";

            // first we create new array containing only words
            string[] words = sentence.Split(new char[] { ',', ' ', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            
            // and we reverse it - we need them in reverse order after all
            Array.Reverse(words);

            // then another one containing EVERYthing else
            string[] notWords = Regex.Split(sentence, "[A-Za-z0-9#+]");
            List<string> separators = new List<string>();

            // from that Everything else we need to seperate empty strings
            for (int i = 0; i < notWords.Length; i++)
            {
                if (notWords[i] != string.Empty)
                {
                    // so if string is NOT empty we add it to List - a List, couse we don't know the count
                    separators.Add(notWords[i]);
                }
            }

            StringBuilder reversedSentence = new StringBuilder();

            // then we make one loop to the count of separators(they're more then words)
            for (int i = 0; i < separators.Count; i++)
            {
                if (i < words.Length)
                {
                    // if we still got words we Add them
                    reversedSentence.Append(words[i]);
                }

                // then the separator
                reversedSentence.Append(separators[i]);
            }

            // and we print it
            Console.WriteLine(reversedSentence.ToString());
        }
    }
}
