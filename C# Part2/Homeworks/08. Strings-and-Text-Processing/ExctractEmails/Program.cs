/* Write a program for extracting all email addresses from given text. All substrings that 
 * match the format <identifier>@<host>…<domain> should be recognized as emails.
 * */
namespace ExctractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            // the text is taken from Nakov's book
            string text = @"Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

            // in emails usually allowed chars are digits and letters, "." and "_" so we use all other usually used chars as splitting conditions
            string[] emails = text.Split(new char[] { ',', ' ', '!', '?','-','=',':',';' }, StringSplitOptions.RemoveEmptyEntries);

            int index = 1;

            // then we loop
            for (int i = 0; i < emails.Length; i++)
            {
                if (Regex.IsMatch(emails[i], @"[\w.]{2,50}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
                {
                    // then we check if it's email to be email it has to have 2 to 50 chars then @ then 2 to 20 chars then . and then 2 to 6 chars, if so - print
                    Console.WriteLine("Email[{0}] - {1}", index, emails[i]);
                    index++;
                }    
            }
        }
    }
}
