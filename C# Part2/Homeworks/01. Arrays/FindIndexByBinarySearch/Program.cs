/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
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

        Array.Sort(array);  // after the sort the array gonna change the index, if we input 0 4 2 1, it gonna be 0 1 2 4, so the index of 4 gonna change from 1 to 3, please notice that!!!!

        Console.Write("Input the searched element: ");
        int element = int.Parse(Console.ReadLine());

        if (binary_search(array, element, 0, array.Length)!=-1) //if it returns -1 so the element isn't in the array so we have to print No such element, else statement, but if it returns anything else - it's the index of the searched element
        {
            Console.WriteLine("The index into the sorted array of {0} is {1}", element, binary_search(array, element, 0, array.Length));  
        }
        else
        {
            Console.WriteLine("No such element in the array");
        }

        
    }

    static int binary_search(int[] arr, int key, int imin, int imax)
    {
        if (imax >= imin)
        {
            // calculate midpoint to cut set in half
            int imid = (imin + imax) / 2;

            // three-way comparison
            if (arr[imid] > key)
                // key is in lower subset
                return binary_search(arr, key, imin, imid - 1);
            else if (arr[imid] < key)
                // key is in upper subset
                return binary_search(arr, key, imid + 1, imax);
            else
                // key has been found
                return imid;
        }
        else
        {
            //if key is not in the array gonna return -1
            return -1;
        }
    }
}

