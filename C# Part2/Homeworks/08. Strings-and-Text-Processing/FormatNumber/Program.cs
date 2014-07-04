/*Write a program that reads a number and prints it as a decimal number, hexadecimal number,
 * percentage and in scientific notation. Format the output aligned right in 15 symbols.
 * */
namespace CountSubstringInString
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            // string text = Console.ReadLine();
            // string searchWord = Console.ReadLine();

            // changing the culture, so the floats to be with .
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal number = decimal.Parse(Console.ReadLine());

            string result = string.Empty;

            result = string.Format("Decimal : {0,15:D}", (int)number);
            Console.WriteLine(result);
            result = string.Format("Hexadecimal : {0,15:X}", (int)number);
            Console.WriteLine(result);
            result = string.Format("Percent : {0,15:P}", number);
            Console.WriteLine(result);
            result = string.Format("Scientific notation : {0,15:E}", number);
            Console.WriteLine(result);         
        }
    }
}
