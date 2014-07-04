namespace Extensions
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            StringBuilder source = new StringBuilder();
            StringBuilder destination = new StringBuilder();

            source.Append("Let me test smth");

            destination.Append(source.SubString(0, 3));

            // Gonna print Let(from 0 three elements)
            Console.WriteLine(destination.ToString());

            int[] intTest = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Int array:");
            Console.WriteLine(intTest.Min());
            Console.WriteLine(intTest.Max());
            Console.WriteLine(intTest.Sum());
            Console.WriteLine(intTest.Product());
            Console.WriteLine(intTest.Average());

            string[] stringTest = new string[] { "1", "2", "3" };

            Console.WriteLine("String array:");
            Console.WriteLine(stringTest.Min());
            Console.WriteLine(stringTest.Max());
            Console.WriteLine(stringTest.Sum());
        }
    }
}
