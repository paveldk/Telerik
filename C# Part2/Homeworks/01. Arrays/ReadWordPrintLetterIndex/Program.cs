/*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.
*/
using System;

class Program
{
    static void Main()
    {
        //Similar to last only this time the type is CHAR :) Works only with Capital letters

        char [] array = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        Console.Write("Input a word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            if (binary_search(array, word[i], 0, array.Length) != -1) //if it returns -1 so the element isn't in the array so we have to print No such element, else statement, but if it returns anything else - it's the index of the searched element
            {
                Console.WriteLine(binary_search(array, word[i], 0, array.Length));
            }
            else
            {
                Console.WriteLine("No such element in the array");
            }            
        }
    }

    static int binary_search(char[] arr, char key, int imin, int imax)
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

