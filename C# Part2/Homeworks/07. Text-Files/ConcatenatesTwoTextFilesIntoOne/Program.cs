// Write a program that concatenates two text files into another text file.
namespace ConcatenatesTwoTextFilesIntoOne
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string fileName = @"..\..\FileOne.txt";
            
            // reads the first file and add his text to text variable wholeText(empty at the beggining)
            StreamReader reader = new StreamReader(fileName);
            string wholeText = string.Empty;
            using (reader)
            {
                wholeText = wholeText + reader.ReadToEnd();    
            }

            // then reads the second and add to the same variable(now containing text from both files)
            fileName = @"..\..\FileTwo.txt";
            reader = new StreamReader(fileName);
            using (reader)
            {
                wholeText = wholeText + reader.ReadToEnd(); 
            }

            // and finally write the variable to the third file - it now contains text from both files
            fileName = @"..\..\FileFinal.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.WriteLine(wholeText);      
            } 
        }
    }
}
