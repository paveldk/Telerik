/*Write a program that removes from a text file all words listed in given another text file. 
 * Handle all possible exceptions in your methods.
 * */
namespace RemoveWordFromFileListedInOther
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
                // we're using 3 files, source, destination and a list file containing the list of words we gonna remove
                string fileName = @"..\..\source.txt";
                StreamReader reader = new StreamReader(fileName);

                fileName = @"..\..\destination.txt";
                StreamWriter writer = new StreamWriter(fileName);

                fileName = @"..\..\list.txt";
                StreamReader list = new StreamReader(fileName);

                string line = string.Empty;

                // we create a List for the words to be removed
                List<string> words = new List<string>();

                // and add all words from the list.txt
                using (list)
                {
                    line = list.ReadLine();
                    while (line != null)
                    {
                        words.Add(line);
                        line = list.ReadLine();
                    }
                }

                // then we begin read line by line from source file 
                line = reader.ReadLine();
                string replace = string.Empty;
                using (reader)
                {
                    using (writer)
                    {
                        while (line != null)
                        {
                            replace = line;

                            // make a loop for all words in the list
                            for (int i = 0; i < words.Count; i++)
                            {
                                // and using again RegularExpressions we change current word if exists with string.Empty
                                string search = @"\b" + words[i] + @"\w*\b";
                                replace = Regex.Replace(replace, search, string.Empty);
                            }

                            line = reader.ReadLine();
                            writer.WriteLine(replace);
                        }
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
