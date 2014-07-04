/* A dictionary is stored as a sequence of text lines containing words and their 
 * explanations. Write a program that enters a word and translates it by using the 
 * dictionary. Sample dictionary:
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes
 * */
namespace Dictionary_Example
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // Add the sample dictionary values
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            // ask for a word
            Console.Write("Search word: ");
            string searchText = Console.ReadLine();
            string result = string.Empty;

            // check if exists in the dictionary
            dictionary.TryGetValue(searchText, out result);

            if (result != null)
            {
                // if so we print it
                Console.WriteLine("{0} - {1}", searchText, result);    
            }
            else
            {
                // if not we print message for the user
                Console.WriteLine("{0} doesn't exists in the database.", searchText);
            }
        }
    }
}
