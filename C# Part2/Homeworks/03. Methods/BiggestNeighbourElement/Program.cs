/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
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

        Console.Write("Position :");
        int position = int.Parse(Console.ReadLine());

        if (BiggerNumber(arrayOfNumbers, position) == 1)
        {
            Console.WriteLine("The number {0} at position {1} in the array is bigger then it's neighbours!", arrayOfNumbers[position], position);    
        }
        else
        {
            Console.WriteLine("The number {0} at position {1} in the array isn't bigger then it's neighbours!", arrayOfNumbers[position], position); 
        }   
    }

    static int BiggerNumber(int[] arrayOfNumbers, int position)
    {
        if ((arrayOfNumbers[position] > arrayOfNumbers[position - 1]) &&
           (arrayOfNumbers[position] > arrayOfNumbers[position + 1]))
        {
            return 1;    // we could make it Bool method and return true or false but next taks says "Use the method from the previous exercise." and there we must returns the index of the first element - it can't be bool :)
        }
        else
        {
            return 0;
        }
    }
}
