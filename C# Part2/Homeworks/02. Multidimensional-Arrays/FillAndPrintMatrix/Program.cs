/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

 * */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input the width of the matrix: ");
        int width = int.Parse(Console.ReadLine());

        int[,] arrayOfNumbers = new int[width, width];
        int number = 1;

        //Variant A
        //      1	5	9	13
        //      2	6	10	14
        //      3	7	11	15
        //      4	8	12	16

        //That's easy don;t need explain
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                arrayOfNumbers[j, i] = number;
                number++;        
            }    
        }

        Console.WriteLine("Variant A:");
        Console.WriteLine(new String('-', 20));
        printArray(arrayOfNumbers);

        //Variant B
        //     1    8	9	16
        //     2	7	10	15
        //     3	6	11	14
        //     4	5	12	13

        //Here I'm using going up index if even and going down index if odd for j
        number = 1;
        for (int i = 0; i < width; i++)
        {
            if (i%2==0)
            {
                for (int j = 0; j < width; j++)
                {
                    arrayOfNumbers[j, i] = number;
                    number++;
                }               
            }
            else
            {
                for (int j = width-1; j >= 0; j--)
                {
                    arrayOfNumbers[j, i] = number;
                    number++;                    
                }
            }


        }

        Console.WriteLine("Variant B:");
        Console.WriteLine(new String('-', 20));
        printArray(arrayOfNumbers);

        //Variant C
        //      7	11	14	16
        //      4	8	12	15
        //      2	5	9	13
        //      1	3	6	10

        number = 1;
        Array.Clear(arrayOfNumbers, 0, arrayOfNumbers.Length);

        //I need to split the matrix in two on diagonal
        /*First part is filling downside 1-10 from the example. Index must be filled in this order:
         * Col      Row
         * width    0
         * ----------
         * width-1  0
         * width    1
         * ----------
         * width-2  0
         * width-1  1
         * width    2
         * ----------
         * width-3  0
         * width-2  1
         * width-1  2
         * width    3
         * and so on
         * The pattern is clear and I'm using j as Column index and Temp as Row index.
         * */
        for (int i = 0; i < width; i++)
        {
            int temp = 0;
            for (int j = width-i-1; j < width; j++)
            {                
                arrayOfNumbers[j,temp] = number;
                number++;
                temp++;
            }
        }
        
        //Second part is similar, but here the pattern is kind a opposite that's why Temp is for Column and j is for Row.
        for (int i = 0; i < width; i++)
        {
            int temp = 0;
            for (int j = i+1; j < width; j++)
            {
                arrayOfNumbers[temp,j] = number;
                number++;
                temp++;
            }
        }


        Console.WriteLine("Variant C:");
        Console.WriteLine(new String('-', 20));
        printArray(arrayOfNumbers);

        //Variant D*
        //      1	12	11	10
        //      2	13	16	9
        //      3	14	15	8
        //      4	5	6	7

        //Here I'm using 4 for loops for each direction I'm doing each of them till they reach current end row of the spiral matrix(where there isn't already number in) and all of that is till Number reach Length of the matrix(for 4*4 is 16 : 1-16).
        number = 1;
        int m = width;
        do
        {
            for (int i = width - m; i < m; i++)
            {
                arrayOfNumbers[i, width - m] = number;
                number++;
            }
            
            for (int i = width - m + 1; i < m; i++)
            {
                arrayOfNumbers[m - 1,i] = number;
                number++;
            }

            for (int i = m - 2; i >= width - m; i--)
            {
                arrayOfNumbers[i,m - 1] = number;               
                number++;
            }

            for (int i = m - 2; i > width - m; i--)
            {

                arrayOfNumbers[width - m, i] = number;               
                number++;
            }
        
            m--;

        } while (number <= arrayOfNumbers.Length);

        Console.WriteLine("Variant D:");
        Console.WriteLine(new String('-', 20));
        printArray(arrayOfNumbers);
    }

    //Method for print of the matrix
    private static void printArray(int[,] matrix)
    {
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                Console.Write("{0,6}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

