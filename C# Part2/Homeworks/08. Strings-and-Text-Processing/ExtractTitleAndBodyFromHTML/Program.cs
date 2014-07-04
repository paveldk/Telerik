/* Write a program that extracts from given HTML file its title (if available), 
 * and its body text without the HTML tags. Example:
 * <html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>
*/
namespace ExtractTitleAndBodyFromHTML
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            // first we make one new streamreader reading the file index.html which is in the same folder as exe
            StreamReader reader = new StreamReader(@"index.html");
            using (reader)
            {
                // then for every given line we read a
                string line = string.Empty;

                line = reader.ReadLine();
                while (line != null)
                {
                    // we check if any text in the line isn't in Tag 
                    foreach (Match text in Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)"))
                    {
                        // and if there is such we print it
                        if (!string.IsNullOrWhiteSpace(text.Value))
                        {
                            Console.WriteLine(text);
                        }                         
                    }

                    // then we get next line and so on to the end
                    line = reader.ReadLine();
                }
            }
        }
    }
}
