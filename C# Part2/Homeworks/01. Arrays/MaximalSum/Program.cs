/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?

*/
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

        int sum = array[0]; 
        int currentSum = array[0];
        int Start = 0; 
        int currentStart = 0;
        int Sequence = 1; 
        int currentSequence = 1;
        for (int i = 1; i < array.Length; i++) //only with 1 loop 
        {
            if (array[i] + currentSum >= array[i])//for every turn we check if current element + currentsum is bigger then the current element      
            {
                currentSum = array[i] + currentSum;//if so we add next element
                currentSequence++;//and increasing the sequence by 1(we have sum of 2,3,4..N elements)
            }
            else
            {
                currentSum = array[i];//if not we start over again
                currentStart = i;//getting new start element for new test
                currentSequence = 1;//and sequence of 1(so far)
            }
           
            if (currentSum > sum)//check if current sum is bigger then final if so - we change the end variables
            {
                sum = currentSum;
                Sequence = currentSequence;
                Start = currentStart;
            }
        }

       // for (int i = Start; i < Start + Sequence; i++)
      //      Console.Write("{0} ", array[i]);//print the part of the array we're interested in - from start N elements


        Console.WriteLine(sum);//print max one
    }
}


