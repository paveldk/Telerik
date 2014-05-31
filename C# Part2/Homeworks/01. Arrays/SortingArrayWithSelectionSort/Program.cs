/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < array.Length; i++) //input elements for array
        {
            Console.Write("Input element {0} of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int min; // variable holding the INDEX of min element
        for (int i = 0; i < array.Length-1; i++)
        {
            min = i; //set the first as minimum

            for (int j = i+1; j < array.Length; j++) //compare the not sorted part(first time it's all but first element - it's suppose to be the minumim)
            {
                if (array[min]>array[j]) //check if really the first is minimum, if not min variable get the INDEX of those element which is smaller and so on till find small from 2 to last(3 to last, 4 to last....last-1 to last)
                {
                    min = j;    
                }    
            }
            int temp = array[i]; // hold temporary i element
            array[i]=array[min]; //i element get the minimum from not sorted part
            array[min] = temp;//the index where the minimum element from not sorted part was get's the i element from temp variable

            //so on till the array is sorted....max easier with array.sort :)
        }

        for (int i = 0; i < array.Length; i++) 
        {
            Console.Write(array[i] + " "); //print elements
        }
    }
}
