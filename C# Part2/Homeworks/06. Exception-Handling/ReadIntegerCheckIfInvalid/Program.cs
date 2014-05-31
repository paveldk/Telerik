/*Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative,
 * print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
 * */
namespace ReadIntegerCheckIfInvalid
{
    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new Exception("Invalid number");
                }

                double sqrRoot = Math.Sqrt(number);
                Console.WriteLine(sqrRoot);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
                Console.ReadLine();
            }
        }
    }
}
