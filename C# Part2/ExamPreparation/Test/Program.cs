using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permutation
{   
    class Program
    {
        static HashSet<string> quickWords = new HashSet<string>();


        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            char[] letters = new char[input.Length];
            letters = input.ToCharArray();
            Array.Sort(letters);
            int count = 0;

            do
            {
                bool ok = true;
                for (int i = 0; i < letters.Length - 1; i++)
                {
                    if (letters[i] == letters[i + 1])
                    {
                        ok = false;
                    }
                }
                if (ok)
                {
                    count++;
                }
            }
            while (NextPermutation(letters));

            Console.WriteLine(count);
        }
        /// <summary>
        /// Wrapper function
        /// </summary>
        /// <param name="input"></param>
        public static void Permutation(StringBuilder input)
        {
            StringBuilder Empty = new StringBuilder();
            RecPermutation(Empty, input);
        }

        private static bool NextPermutation(char[] array)
        {
            for (int index = array.Length - 2; index >= 0; index--)
            {
                if (array[index] < array[index + 1])
                {
                    int swapWithIndex = array.Length - 1;
                    while (array[index] >= array[swapWithIndex])
                    {
                        swapWithIndex--;
                    }

                    // Swap i-th and j-th elements
                    var tmp = array[index];
                    array[index] = array[swapWithIndex];
                    array[swapWithIndex] = tmp;

                    Array.Reverse(array, index + 1, array.Length - index - 1);
                    return true;
                }
            }
            // No more permutations
            return false;
        }

        private static void RecPermutation(StringBuilder soFar, StringBuilder input)
        {
            
            if (string.IsNullOrEmpty(input.ToString()))
            {
                bool ok = true;
                for (int i = 0; i < soFar.Length - 1; i++)
                {                   
                    if (soFar[i] == soFar[i + 1])
                    {
                        ok = false;    
                    }   
                }
                if (ok)
                {
                    quickWords.Add(soFar.ToString());
                }
               
                return;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    StringBuilder remaining = new StringBuilder();
                    remaining.Append(input.ToString().Substring(0, i));
                    remaining.Append(input.ToString().Substring(i + 1));

                    StringBuilder text = new StringBuilder();
                    text.Append(soFar);
                    text.Append(input[i]);
                    
                   // RecPermutation(soFar + input[i], remaining);
                    RecPermutation(text, remaining);
                }
            }
            
        }
    }
}