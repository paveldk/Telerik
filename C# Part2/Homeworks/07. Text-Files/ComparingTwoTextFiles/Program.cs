/*Write a program that compares two text files line by line and prints the number of lines 
 * that are the same and the number of lines that are different. Assume the files 
 * have equal number of lines.
 * */
namespace ComparingTwoTextFiles
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            // reads the first file
            string fileName = @"..\..\FileOne.txt";             
            StreamReader readerOne = new StreamReader(fileName);

            // then reads the second, where I made some differences
            fileName = @"..\..\FileTwo.txt";
            StreamReader readerTwo = new StreamReader(fileName);

            string equalLines = string.Empty;
            string differentLines = string.Empty;

            using (readerOne)
            {
                using (readerTwo)
                {
                    int lineNumber = 0;

                    string lineOne = readerOne.ReadLine();
                    string lineTwo = readerTwo.ReadLine();

                    while (lineOne != null)
                    {
                        if (lineOne == lineTwo)
                        {
                            Console.WriteLine("Lines {0} are equal", lineNumber);
                        }
                        else
                        {
                            Console.WriteLine("Lines {0} are different", lineNumber);
                        }

                        lineOne = readerOne.ReadLine();
                        lineTwo = readerTwo.ReadLine();
                        lineNumber++;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
