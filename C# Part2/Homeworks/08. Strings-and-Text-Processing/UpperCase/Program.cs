/*You are given a text. Write a program that changes the text in all regions surrounded 
 * by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
 * Example:
 * We are living in a <upcase>yellow submarine</upcase>. We don't have 
 * <upcase>anything</upcase> else.
 * The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 * */
namespace CountSubstringInString
{
    using System;

    class Program
    {
        static void Main()
        {
            // string text = Console.ReadLine();
            // string substring = Console.ReadLine();
            string text = "<upcase>We</upcase> are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> <upcase>else.</upcase>";
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            string endText = string.Empty;

            // we need to find the index of two things - the oppening and closing tags
            int indexOpenTag = text.IndexOf(openTag); 
            int indexCloseTag = text.IndexOf(closeTag); 

            while (indexOpenTag >= 0) 
            {     
                // then till we find oppening tags we add in our exit string:
                // Text before oppening tags(If there is such)
                endText = endText + text.Substring(0, indexOpenTag);

                // we place the oppening tag position after the tag itself
                indexOpenTag += openTag.Length;
                
                // the we add the text between tabs TO UPPER
                endText = endText + text.Substring(indexOpenTag, indexCloseTag - indexOpenTag).ToUpper();
                
                // then the text AFTER the closing tabs is assigned to our original text, 
                // replacing it and we're ready to search for another tags, if there is such
                // all of that till we find oppening tags
                text = text.Substring(indexCloseTag + closeTag.Length, text.Length - indexCloseTag - closeTag.Length);
                
                indexOpenTag = text.IndexOf(openTag);
                indexCloseTag = text.IndexOf(closeTag);
            }

            // at the end we add any text left after last closing tag, if there is such
            endText = endText + text;
            Console.WriteLine(endText);
        }
    }
}
