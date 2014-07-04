/* Write a program that reads a string, reverses it and prints the result at the console.
 * Example: "sample"  "elpmas".
 * */
namespace ReadReversePrintString
{
    using System;
 
    class Program
    {
        static void Main()
        {
            string myString = Console.ReadLine();
            string reverseString = string.Empty;

            for (int i = 0; i < myString.Length; i++)
            {
                reverseString = myString[i] + reverseString;    
            }

            Console.WriteLine(reverseString);
        }
    }
}
