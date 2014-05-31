/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Lenght :");
        int length = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            arrayOfNumbers[i] = random.Next(0, 100);
            Console.WriteLine(arrayOfNumbers[i] + " ");
        }

        Console.WriteLine("The first element in this array which is bigger than it's two neighbour is the element {0} at position {1}", arrayOfNumbers[BiggerNumber(arrayOfNumbers, 1)], BiggerNumber(arrayOfNumbers, 1));
    }

    static int BiggerNumber(int[] arrayOfNumbers, int position) 
    {
        // We don't need the position but the task says : Use the method from the previous exercise.
        // I prefer calling it that way and without the "1" in the main, that way:
        // static int BiggerNumber(int[] arrayOfNumbers)
        for (int i = 1; i < arrayOfNumbers.Length - 1; i++)
        {
            if ((arrayOfNumbers[i] > arrayOfNumbers[i - 1]) &&
              (arrayOfNumbers[i] > arrayOfNumbers[i + 1]))
            {
                return i;    
            }            
        }

        return -1;       
    }
}
