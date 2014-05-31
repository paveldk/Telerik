using System;
class Program
{
    static void Main()
    {
        Console.Write("Input array length: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++) //input elements for array
        {
            Console.Write("Input element {0} of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array); //we sort the array - for easier count, now the numbers gonna be group
        int currentCount = 1;//two counts, temp 
        int count = 1;//and final
        int number = array[0];//and the most frequent number
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i]==array[i-1])
            {
                currentCount++;     //if this is equal to previous ++ and the number stay the same - first one.   
            }
            else if (currentCount>count) //else only if currentcount is bigger than final, becouse if not we already find our targets, we:
            {
                count = currentCount;//get new value for the final variable
                currentCount = 1;     //start looking again for better sequence         
                number = array[i-1];//and save our new number
            }
               
        }

        Console.WriteLine("The most frequent number is {0} - {1} times.",number, count);
    }
}

