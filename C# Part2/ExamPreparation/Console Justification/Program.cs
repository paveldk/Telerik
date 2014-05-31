namespace Console_Justification
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            string currentLine = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                string[] currLineWords = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < currLineWords.Length; j++)
                {
                    text.Append(currLineWords[j]);
                    text.Append(" ");    
                }               
            }

            string[] words = text.ToString().Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            
            int count = 0;
            List <string> result = new List<string>();
            string temp = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                count = count + words[i].Length;
                if (count > width)
                {
                    result.Add(temp);
                    temp = words[i] + " ";
                    count = words[i].Length;
                }
                else
                {
                    temp = temp + words[i] + " ";
                }
                count++;
            }

            result.Add(temp);

            for (int i = 0; i < result.Count; i++)
            {
                result[i] = result[i].TrimEnd(' ');

                if (result[i].Length < width)
                {
                    int difference = width - result[i].Length;

                    int spacePos = result[i].IndexOf(' ');

                    if (spacePos != -1)
                    {
                        while (difference > 0)
                        {
                            spacePos = result[i].IndexOf(' ');
                            while (spacePos != -1)
                            {
                                if (difference > 0)
                                {
                                    result[i] = result[i].Insert(spacePos, " ");
                                    difference--;
                                }

                                int index = 1;

                                while (!char.IsLetterOrDigit(result[i][spacePos + index]))
                                {                                  
                                    index++;
                                }
                                spacePos = result[i].IndexOf(' ', spacePos + index);
                                
                            }

                        }    
                    }

                }   
            }

            foreach (var line in result)
            {
                Console.WriteLine(line);    
            }
        }
    }
}
