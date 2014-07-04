namespace CSharpBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static char[] separators = new char[] { ' ' };

        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            string tabulator = Console.ReadLine();

            List<string> words = new List<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    words.Add(line);    
                }
                
            }

            for (int i = 0; i < words.Count; i++)
            {              
                words[i] = Regex.Replace(words[i], @"\s+", " ");
                string[] substrings = Regex.Split(words[i], @"(\(|\)|-|\+|\*|/)");
                words[i] = words[i].TrimStart(' ');
                words[i] = words[i].TrimEnd(' ');
            }

            string temp = string.Empty;

            string currentTab = string.Empty;

            List<string> finalCode = new List<string>();

            int tabs = 0;

            for (int i = 0; i < words.Count; i++)
            {
                currentTab = string.Empty;
                for (int j = 0; j < tabs; j++)
                {
                    currentTab = currentTab + tabulator;
                }

                if (words[i].Contains("{") || words[i].Contains("}"))
                {
                    currentTab = string.Empty;
                    for (int j = 0; j < tabs; j++)
                    {
                        currentTab = currentTab + tabulator;
                    }

                    for (int j = 0; j < words[i].Length ; j++)
                    {
                        currentTab = string.Empty;
                        for (int k = 0; k < tabs; k++)
                        {
                            currentTab = currentTab + tabulator;
                        }
                        if (words[i][j] == '{')
                        {
                            if (!string.IsNullOrWhiteSpace(temp))
                            {
                                temp = temp.TrimStart(' ');
                                finalCode.Add(currentTab + temp);    
                            } 
                           
                            finalCode.Add(currentTab + words[i][j].ToString());
                            tabs++;
                            temp = string.Empty;
                        }
                        else if (words[i][j] == '}')
                        {                          
                            if(j != words[i].Length - 1)
                            {
                                if (words[i][j + 1] == ';')
                                {
                                    if (!string.IsNullOrWhiteSpace(temp))
                                    {
                                        temp = temp.TrimStart(' ');
                                        finalCode.Add(currentTab + temp);
                                    }
                                    tabs--;
                                    currentTab = string.Empty;
                                    for (int k = 0; k < tabs; k++)
                                    {
                                        currentTab = currentTab + tabulator;
                                    }

                                    finalCode.Add(currentTab + words[i][j].ToString());
                                    finalCode.Add(currentTab + words[i][j + 1].ToString());
                                    j++;
                                     
                                    temp = string.Empty;
                                }
                                else
                                {
                                    if (!string.IsNullOrWhiteSpace(temp))
                                    {
                                        temp = temp.TrimStart(' ');
                                        finalCode.Add(currentTab + temp);
                                    }

                                    tabs--;
                                    currentTab = string.Empty;
                                    for (int k = 0; k < tabs; k++)
                                    {
                                        currentTab = currentTab + tabulator;
                                    }
                                    
                                    finalCode.Add(currentTab + words[i][j].ToString());

                                    temp = string.Empty;
                                }
                            }
                            else
                            {
                                if (!string.IsNullOrWhiteSpace(temp))
                                {
                                    temp = temp.TrimStart(' ');
                                    finalCode.Add(currentTab + temp);
                                }

                                tabs--;
                                currentTab = string.Empty;
                                for (int k = 0; k < tabs; k++)
                                {
                                    currentTab = currentTab + tabulator;
                                }
                               
                                finalCode.Add(currentTab + words[i][j].ToString());

                                temp = string.Empty;
                            }
                        }
                        else
                        {
                            temp = temp + words[i][j].ToString();
                        }
                    }         
                }
                else
                {
                    finalCode.Add(currentTab + words[i]);
                }
                if (!string.IsNullOrWhiteSpace(temp))
                {
                    temp = temp.TrimStart(' ');
                    finalCode.Add(currentTab + temp);
                    temp = string.Empty;
                }
            }

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            foreach (var lines in finalCode)
            {
                Console.WriteLine(lines);    
            }
        }
    }
}
