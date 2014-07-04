/** Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
 * The idea of the sort is to repeatedly merge sublists to produce new sorted sublists. Once they're all sorted we have one final sorted array.
*/
using System;

class Program
{
    static public void DoMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[numbers.Length];
        int i, left_end, num_elements, tmp_pos;

        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);

        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }

        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];

        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];

        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void MergeSort(int[] numbers, int left, int right)
    {
        int mid;//recursive method which compare left and right part of the array

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSort(numbers, left, mid);
            MergeSort(numbers, (mid + 1), right);

            DoMerge(numbers, left, (mid + 1), right);
        }
    }


    static void Main(string[] args)
    {
        Console.Write("Input array length: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++) //input elements for array
        {
            Console.Write("Input element {0} of array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        MergeSort(array, 0, array.Length-1);//calling first method
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);

        Console.WriteLine();

    }
}

