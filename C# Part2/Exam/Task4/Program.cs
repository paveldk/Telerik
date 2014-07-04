namespace Task4
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            byte[] inputBuffer = new byte[1024];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            string searchWord = Console.ReadLine();
            searchWord = searchWord.ToUpper();
            int lines = int.Parse(Console.ReadLine());
            List<string> oldText = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string line = Console.ReadLine();
                           
                string pattern = @"\b" + searchWord + @"\b";
                line = Regex.Replace(line, pattern, searchWord, RegexOptions.IgnoreCase);

                line = Regex.Replace(line, @"\.|\?|\!|\,|\(|\)|\-|\;", " ");
                line = Regex.Replace(line, @"\s+", " ");
                oldText.Add(line);
            }

            SortedDictionary<int, string> newText = new SortedDictionary<int, string>();

            for (int i = 0; i < oldText.Count; i++)
            {
                int index = oldText[i].IndexOf(searchWord);
                int count = 0;
                if (index != -1)
                {
                    count = 1;    
                }
                else
                {
                    count = 0;
                }

                while (!(index == -1))
                {
                    index = oldText[i].IndexOf(searchWord, index + 1);
                    count++;
                }
                if (count != 0)
                {
                    count = count - 1;
                }
                if (count>0)
                {
                    try
                    {
                        newText.Add(count, oldText[i]);
                    }
                    catch (System.ArgumentException)
                    {
                        string temp = string.Empty;
                        int pos = oldText[3].IndexOf("who");
                        temp = oldText[3].Substring(pos);
                        Console.Error.WriteLine(temp);   
                      
                    }
                                        
                }
                
            }

            int indexDict = newText.Keys.Max();
            for (int i = indexDict; i >= 0; i--)
            {
                if (newText.ContainsKey(i))
                {
                    string pattern = @"\b" + searchWord + @"\b";
                    newText[i] = Regex.Replace(newText[i], pattern, searchWord.ToUpper(), RegexOptions.IgnoreCase);

                    newText[i] = Regex.Replace(newText[i], @"\.|\?|\!|\,|\(|\)|\;|\-", string.Empty);
                    newText[i] = Regex.Replace(newText[i], @"\s+", " ");

                    string[] substrings = Regex.Split(newText[i], @"(\(|\)|-|\+|\*|/)");

                    Console.WriteLine(newText[i]);
                }

            }
        }
    }
}