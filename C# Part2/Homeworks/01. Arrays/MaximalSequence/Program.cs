/*Write a program that finds the maximal sequence of equal elements in an array.
Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

 * */
using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Input lenght of array: ");
            int temp = int.Parse(Console.ReadLine());
            int [] array = new int [temp];

            for (int i = 0; i < array.Length; i++) //input elements for array
            {
                Console.Write("Input element {0} of array: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int count = 1; //variable for current sequence count
            int maxcount = 0; //variable for current max count
            int mostFrequent = array[0]; //valable to kept the most frequent element, first the 0 element

            for (int i = 1; i < array.Length; i++)
            {

                if (array[i-1]== array[i]) //if previos is equal to current count++
                {
                    count++;              
                }
                else // if not compare current count with max count
                {
                    if (count>maxcount) //if current is bigger max get's it's value
                    {
                        maxcount = count;
                        mostFrequent = array[i-1]; //get's previous element, couse current isn't equal anymore
                    }
                    count = 1;//then current begin from 1
                }

            }

            if (count > maxcount) //we must check again if the sequence is to the last element
            {
                maxcount = count;
                mostFrequent = array[array.Length - 1];
            }

            int[] sequenceArray = new int[maxcount]; //new array with lenght of the maxcount

            for (int i = 0; i < sequenceArray.Length; i++)
            {
                sequenceArray[i] = mostFrequent; //every element is the mostFrequent element
                Console.Write(sequenceArray[i] + " ");       
            }
        }
    }
