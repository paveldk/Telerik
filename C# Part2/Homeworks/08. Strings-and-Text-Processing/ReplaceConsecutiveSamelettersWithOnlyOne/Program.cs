/* Write a program that reads a string from the console and replaces all series of 
 * consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  
 * "abcdedsa".
 * */
namespace ReplaceConsecutiveSamelettersWithOnlyOne
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";

            // create StringBuilder and append first symbol from the text
            StringBuilder finaltext = new StringBuilder();
            finaltext.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                // the we loop and check if current symbol isn't same like previous, we start from 1 - 0 is already in StringBuilder
                if (text[i] != text[i - 1])
                {
                    // if it differs we add it, if not - just skip
                    finaltext.Append(text[i]);    
                }    
            }

            // finally we print :)
            Console.WriteLine(finaltext.ToString());
        }
    }
}
