/*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
 * Example: The target substring is "in". The text is as follows:
 * We are living in an yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day. 
 * We will move out of it in 5 days.
 * The result is: 9.
*/
namespace CountSubstringInString
{
    using System;

    class Program
    {
        static void Main()
        {
            // string text = Console.ReadLine();
            // string substring = Console.ReadLine();
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string substring = "in";
            int count = 0;
            int index = 0;

            do
            {
                index = text.IndexOf(substring, index);
                index++;
                count++;
            }
            while (index > 0);

            Console.WriteLine(count);
        }
    }
}
