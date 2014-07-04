/*Write a program that converts a string to a sequence of C# Unicode character literals. 
 * Use format strings. Sample input:
 * Hi!
 * Expected output:
 * \u0048\u0069\u0021
 * */
namespace CountSubstringInString
{
    using System;

    class Program
    {
        static void Main()
        {
            // string text = Console.ReadLine();
            // string searchWord = Console.ReadLine();
            string str = Console.ReadLine();

            foreach (char c in str)
            {
                Console.Write("\\u{0:X4} ", (int)c); 
            }

            Console.WriteLine();      
        }
    }
}
