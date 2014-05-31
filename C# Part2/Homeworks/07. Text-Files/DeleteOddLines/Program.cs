/*Write a program that deletes from given text file all odd lines. 
 * The result should be in the same file.
 * */
namespace ReadNameFromFileSortThem
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            List<string> lines = new List<string>();
            string fileName = @"..\..\Source.txt";
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                // we read the file and add all it's lines into one List
                string line = reader.ReadLine();
                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
            }

            fileName = @"..\..\Source.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {                
                for (int i = 0; i < lines.Count; i++)
                {
                    // then we check if list item is odd 
                    if ((i % 2) == 1)
                    {
                        // if so - we add it to the same file rewriting it(default value)
                        writer.WriteLine(lines[i]);    
                    }                    
                }
            }
        }
    }
}
