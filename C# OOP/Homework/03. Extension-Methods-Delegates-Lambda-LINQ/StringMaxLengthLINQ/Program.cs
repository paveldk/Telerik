/* Write a program to return the string with maximum length from an array of strings. 
 * Use LINQ
 * */
namespace StringMaxLengthLINQ
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] stringArr = new string[] { "sddfd", "dsfdsfdsf", "dsf" };
            
            /* for this I used search in google and stackover : 
             * http://stackoverflow.com/questions/7975935/is-there-a-linq-function-for-getting-the-longest-string-in-a-list-of-strings
             * */

            var longest =
                from s in stringArr
                where s.Length == stringArr.Max(a => a.Length)
                select s;

            foreach (var item in longest)
            {
                Console.WriteLine(item);   
            }
        }
    }
}
