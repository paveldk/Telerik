/*Write a program that replaces all occurrences of the substring "start" with the 
 * substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
 * */
namespace ReplaceText
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string fileName = @"..\..\source.txt";
            StreamReader reader = new StreamReader(fileName);
            fileName = @"..\..\destination.txt";
            StreamWriter writer = new StreamWriter(fileName);
            string line = string.Empty;

            using (reader)
            {
                using (writer)
                {
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        // using replace method in the source file there is start on first line to see it works even if it's part of the word
                        writer.WriteLine(Regex.Replace(line, "start", "finish"));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
