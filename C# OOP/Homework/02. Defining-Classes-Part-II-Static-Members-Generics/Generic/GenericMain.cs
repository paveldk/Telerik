// The task condition is in the file TaskCondition.docx
namespace Generic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GenericMain
    {
        static void Main()
        {
            // Declare double List with default constructor(10 elements) 
            GenericList<double> doubleList = new GenericList<double>();

            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                // Adding 3 element using Add method
                doubleList.Add(rand.Next(1, 100) + rand.NextDouble());       
            }

            // Accessing element by index 
            Console.WriteLine("The first element is {0}", doubleList[0]);

            // Getting count of the elements
            Console.WriteLine("Number of elements: {0}", doubleList.Count);
            
            // And printing them all
            Console.WriteLine("All elements");

            // using override toString - gonna print 3 elements with value and one 0(default size 4) 
            Console.WriteLine(doubleList.ToString()); 

            double max = doubleList.Max();
            double min = doubleList.Min();

            Console.WriteLine("Minimal element {0}", min);
            Console.WriteLine("Maximal element {0}", max);

            Console.WriteLine();

            // Declare a string List with exactly 4
            GenericList<string> books = new GenericList<string>(4);
            
            // Again add some, this time without loop
            books.Add("Wheel of time");
            books.Add("A song of Ice and Fire");
            books.Add("Lord of the rings");
            books.Add("Da Vinci's Code");
            
            // print them
            Console.WriteLine("Books: ");
            Console.WriteLine(books.ToString()); 

            Console.WriteLine();

            // remove element
            books.Remove(1);

            // and print them again
            Console.WriteLine("Books without one element: ");
            Console.WriteLine(books.ToString()); 

            Console.WriteLine();

            // But if we add another one, they gonna be 
            int index = 2;
            books.Insert(index, "Hobbit");
            Console.WriteLine("Books with new element on position {0}: ", index);
            Console.WriteLine(books.ToString()); 

            // Now the books are 4, so the default Capacity(4) is good enough for them:
            Console.WriteLine("Number of elements: {0}", books.Capacity);
            
            // but if we add another one it will increase to 8
            books.Insert(2, "New Book 1");
            Console.WriteLine(books.ToString()); 

            Console.WriteLine("Number of elements: {0}", books.Capacity);         
                                
            // Search for a book
            index = books.Find("Hobbit");
            if (index != -1)
            {
                Console.WriteLine("The book {1} is at index {0}", index, books[index]);    
            }
            else
            {
                Console.WriteLine("This book isn't in the DB");
            }

            Console.WriteLine();
                       
            // Clear the array
            books.Clear();

            // and print them again - nothing to see
            Console.WriteLine("Books after clearing - nothing: ");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }

            Console.WriteLine(books.ToString()); 
        }
    }
}
