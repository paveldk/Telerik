/* Write a program that reads a list of words from a file words.txt and finds how many 
 * times each of the words is contained in another file test.txt. 
 * The result should be written in the file result.txt and the words should be sorted by 
 * the number of their occurrences in descending order. Handle all possible exceptions 
 * in your methods.
 * */
namespace CountWordsFromList
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            try
            {
                string[] words = File.ReadAllLines("../../words.txt");
                int[] values = new int[words.Length];

                // Count words
                using (StreamReader input = new StreamReader("../../test.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                    }
                }

                // Sort
                Array.Sort(values, words);

                // Write output
                using (StreamWriter output = new StreamWriter("../../results.txt"))
                {
                    // Descending order
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        output.WriteLine("{0}: {1}", words[i], values[i]);
                    }
                }         
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file don't exists");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The folder don't exists");
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("The drive don't exists");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path to the file is too long");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("Problem with loading the file");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error");
            }

            Console.ReadKey();
            
        }
    }
}
