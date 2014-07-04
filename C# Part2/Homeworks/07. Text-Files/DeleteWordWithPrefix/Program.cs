namespace DeleteWordWithPrefix
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
            string line = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    // using again RegularExpressions we change test, with \w, which is for matching and \b for bounderies, with string.Empty                   
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", string.Empty));
                        line = reader.ReadLine();
                    }                    
                }                           
            }
        }
    }
}
