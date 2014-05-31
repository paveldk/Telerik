/*Write a program that extracts from a given text all dates that match the format 
 * DD.MM.YYYY. Display them in the standard date format for Canada.
 * */
namespace ExctractDate
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            // again from Nakov's book
            string text = @"I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9) 14.06.1980.";

            // we split to words with all seperators we can include BUT .
            string[] words = text.Split(new char[] { ',', ' ', '!', '?', '-', '=', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            int index = 1;

            // then we loop
            for (int i = 0; i < words.Length; i++)
            {
                // we search for such words - {1 to 2 numbers}.{1 to 2 numbers}.{2 to 4 numbers}
                if (Regex.IsMatch(words[i], @"[\d]{1,2}\.[\d]{1,2}\.[\d]{2,4}"))
                {
                    // we trim the final. if the date is at the end of the sentence
                    words[i] = words[i].TrimEnd('.');
                    try
                    {
                        /* and we put in try catch becouse some of the words are not dates, 
                         * such as see section 7.3.12. When we reach it Parse will fail 
                         * and we'll go to exception, but we don't want to print anything - 
                         * the user will never know about it and the program will keep 
                         * working :)
                         * */
                        DateTime date = DateTime.Parse(words[i]);
                        string dateCanada = date.ToString("dd/MM/yy", CultureInfo.InvariantCulture);

                        Console.WriteLine("Date[{0}] - {1}", index, dateCanada);
                        index++;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
