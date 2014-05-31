/* Write a program that reads a text file and inserts line numbers in front of each of 
 * its lines. The result should be written to another text file.
 * */

namespace ReadFileInsertLineNumbers
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string fileName = @"..\..\Test.txt";
            StreamReader reader = new StreamReader(fileName);

            fileName = @"..\..\FileFinal.txt";
            StreamWriter writer = new StreamWriter(fileName);

            using (reader)
            { 
                using (writer)
                {
                    int lineNumber = 0;

                    // read a line from source file
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;

                        // and add same line + it's number infront in destination file
                        writer.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }                
                }
            }
        }
    }
}
