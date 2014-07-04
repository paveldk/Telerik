using System;

class Program
{
    static void Main()
    {
        Console.Write("Input array length: ");
        int N = int.Parse(Console.ReadLine());

        string [] array = new string[N];

        for (int i = 0; i < array.Length; i++) //input elements for array
        {
            Console.Write("Input element {0} of string array: ", i);
            array[i] = Console.ReadLine();
        }

        string mid = array[N / 2];

        sort(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++) //print elements for array
        {
            Console.WriteLine(array[i]);
        }        
    }

    public static void sort(string[] arr, int left, int right)
    {
        int l = left; //start position
        int r = right; //end position
        string mid = arr[(left + right) / 2]; //compare value

        while (l <= r) //while in positions
        {
            while (arr[l].CompareTo(mid) < 0)//while current compare to mid is lower left going up
            {
                l++;
            }

            while (arr[r].CompareTo(mid) > 0)
            {
                r--; //while same about right - r going down
            }

            if (l <= r) //when left positon <= right - swap using temp variable
            {
                string temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;

                l++;
                r--;
            }
        }

        //and recursive if not
        if (left < r)
        {
            sort(arr, left, l);
        }

        if (l < right)
        {
            sort(arr, r, right);
        }
    }
}

