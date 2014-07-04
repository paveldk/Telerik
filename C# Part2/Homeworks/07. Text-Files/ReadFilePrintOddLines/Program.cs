// Write a program that reads a text file and prints on the console its odd lines.
namespace ReadFilePrintOddLines
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string fileName = @"..\..\Test.txt";
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if ((lineNumber % 2) == 1)
                    {
                       // Console.WriteLine("Line {0}: {1}", lineNumber, line); 
                        Console.WriteLine(line); 
                    }
                    
                    line = reader.ReadLine();
                } 
            }

            Console.ReadLine();
        }
    }
}
