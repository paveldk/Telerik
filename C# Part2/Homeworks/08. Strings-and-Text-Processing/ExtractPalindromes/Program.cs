/*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", 
 * "exe".
 * */
namespace ExtractPalindromes
{
    using System;
    using System.Text;

    class Program
    {
        static bool IsPalindromes(string palindromes)
        {
            // we create Method IsPalindromes who invert the word check if inverted and normal are equal if so return True, if not - False
            StringBuilder reversePalindromes = new StringBuilder();

            for (int i = palindromes.Length - 1; i >= 0; i--)
            {
                reversePalindromes.Append(palindromes[i]);    
            }

            if (reversePalindromes.ToString() == palindromes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            string text = @"ABBA is the my favorite band, so I'm keeping all their songs in my folder /lamal/ABBA and I'm playing them with winamp.exe";

            // we split by anything we can imagine - we can add everything as seperators
            string[] words = text.Split(new char[] { ',', ' ', '!', '?', '-', '=', ':', ';', '.', '/' }, StringSplitOptions.RemoveEmptyEntries);

            int index = 1;

            // then we loop
            for (int i = 0; i < words.Length; i++)
            {
                if (IsPalindromes(words[i]))
                {
                    // If the Method return True we print the word
                    Console.WriteLine("palindromes[{0}] - {1}", index, words[i]);
                    index++;
                }
            }
        }
    }
}
