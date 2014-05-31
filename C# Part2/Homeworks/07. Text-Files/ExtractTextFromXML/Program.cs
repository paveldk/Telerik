/* Write a program that extracts from given XML file all the text without the tags. 
 * Example:
 * <?xml version="1.0"><student><name>Pesho</name>
 * <age>21</age><interests count="3"> <interest> 
 * Games</instrest><interest>C#</instrest><interest> 
 * Java</instrest> </interests></student>
 * */
namespace ExtractTextFromXML
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            // bool value to check if we're in place to collect chars
            bool inText = false;
            string fileName = @"..\..\source.xml";
            string onlyText = string.Empty;
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                // reading file line by line
                string line = reader.ReadLine();
                while (line != null)
                {
                    onlyText = string.Empty;
                    for (int i = 0; i < line.Length; i++)
                    {
                        string curSymbol = string.Empty + line[i];
                        
                        // if we're at position to start getting chars, which is between > and <
                        if (inText)
                        {
                            // if we reach < we must put inText to false, it's time to stop adding chars
                            if (curSymbol == "<")
                            {
                                inText = false;
                            }
                            else
                            {
                                // and if it's not empty space or Tab we add to our variable onlyText current char
                                if (curSymbol != " " && curSymbol != "\t")
                                {
                                    onlyText = onlyText + line[i];   
                                }                               
                            }                            
                        }

                        // and if the current char is > it's time to start getting chars
                        if (curSymbol == ">")
                        {
                            inText = true;     
                        }                        
                    }

                    // if we get any chars - we write it
                    if (onlyText.Length > 0)
                    {
                        Console.WriteLine(onlyText);   
                    }
                    
                    // and get new line.
                    line = reader.ReadLine();
                }
            }

            Console.ReadKey();
        }
    }
}
