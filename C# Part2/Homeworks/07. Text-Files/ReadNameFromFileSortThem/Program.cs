/*Write a program that reads a text file containing a list of strings, sorts them 
 * and saves them to another text file. Example:
  Ivan    George
  Peter   Ivan
  Maria   Maria
  George  Peter
*/

namespace ReadNameFromFileSortThem
{
    using System;   
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();
            string fileName = @"..\..\Source.txt";
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }
            }

            names.Sort();

            fileName = @"..\..\Destination.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }
        }
    }
}
