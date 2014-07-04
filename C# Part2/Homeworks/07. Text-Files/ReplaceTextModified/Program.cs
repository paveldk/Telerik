// Modify the solution of the previous problem to replace only whole words (not substrings).
namespace ReplaceText
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string fileName = @"..\..\Test.txt";
            StreamReader reader = new StreamReader(fileName);
            fileName = @"..\..\Destination.txt";
            StreamWriter writer = new StreamWriter(fileName);
            string line = string.Empty;

            using (reader)
            {
                using (writer)
                {
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        // and here it don't work unless it's separated word, that's becouse of using RegularExpressions
                        writer.WriteLine(Regex.Replace(line, @"(\W|^)start(\W|$)", "$1finish$2"));
                        line = reader.ReadLine();
                    }    
                }
            }
        }
    }
}
