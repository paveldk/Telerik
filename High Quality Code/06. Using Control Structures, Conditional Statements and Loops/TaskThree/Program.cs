// Refactor the following loop: 
namespace TaskThree
{
    using System;
    using System.Linq;

    class Program
    {    
        static void Main(string[] args)
        {
            bool found = false;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if ((i % 10 == 0) && (array[i] == expectedValue))
                {
                    found = true;
                }
            }

            // More code here
            if (found)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
