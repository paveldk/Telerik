/* Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. The encoding/decoding is done by performing
 * XOR (exclusive or) operation over the first letter of the string with the first of the 
 * key, the second – with the second, etc. When the last key character is reached, the next 
 * is the first.
 * */
namespace EncodeAndDecodeString
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string cipher = "abcd";

            string decodedText = string.Empty;

            // First we decode it.

            // To do it we need to find which is larger - text or cypher
            if (cipher.Length > text.Length)
            {
                Console.Write("Decoded text: "); 
                decodedText = CypherIsLonger(text, cipher);
                Console.WriteLine(decodedText);  
            }
            else
            {
                Console.Write("Decoded text: "); 
                decodedText = TextIsLonger(text, cipher);
                Console.WriteLine(decodedText);
            }

            // Then we encode
            if (cipher.Length > decodedText.Length)
            {
                Console.Write("And encoded again: "); 
                decodedText = CypherIsLonger(decodedText, cipher);
                Console.WriteLine(decodedText);
            }
            else
            {
                Console.Write("And encoded again: ");
                decodedText = TextIsLonger(decodedText, cipher);
                Console.WriteLine(decodedText);
            }        
        }

        private static string TextIsLonger(string text, string cipher)
        {
            /* both Method works the same but for different variables
             *  first we loop to the end of the larger and Xor it by the value from the index
             *  that we create for the shorter variable, in this case cipherIndex
             *  When our index reach it's variable length we reset it to 0.
             *  */

            StringBuilder result = new StringBuilder();
            int cipherIndex = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int operation = 0;

                // The Xor
                operation = text[i] ^ cipher[cipherIndex];

                // The append to the stringBuilder
                result.Append((char)operation);
                cipherIndex++;

                // The check if index is at maximum
                if (cipherIndex == cipher.Length)
                {
                    cipherIndex = 0;
                }
            }

            return result.ToString();
        }

        private static string CypherIsLonger(string text, string cipher)
        {
            // Pretty much the same
            StringBuilder result = new StringBuilder();
            int textIndex = 0;
            for (int i = 0; i < cipher.Length; i++)
            {
                int operation = 0;
                operation = cipher[i] ^ text[textIndex];

                result.Append((char)operation);
                textIndex++;
                if (textIndex == text.Length)
                {
                    textIndex = 0;
                }
            }

            return result.ToString();
        }
    }
}
