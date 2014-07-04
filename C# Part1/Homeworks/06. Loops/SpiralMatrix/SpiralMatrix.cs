using System;

class SpiralMatrix
{
    static void Main()
    {
        /** Write a program that reads a positive integer number N (N < 20) from
         * console and outputs in the console the numbers 1 ... N number
         * arranged as a spiral.*/

        int n = 0;
        do
        {
            Console.Write("Input N (N>0 and N<20): ");
            n = int.Parse(Console.ReadLine());

        } while (!(n > 0) && (n < 20));

        string[,] spiral = new string[n,n];
        int number = 1;

        int m = n;
        do
        {
            
            for (int i = n-m; i < m; i++)
            {
                //If the length of the number is 1 I will put 0 infront(01), so the matrix gonna be more clear, at least till N<10
                if (number.ToString().Length!=1)
                {
                    spiral[n-m, i] = number.ToString();
                }
                else
                {
                    spiral[n - m, i] = "0"+number.ToString();
                }
                
                number++;
            }

            for (int i = n-m+1; i < m; i++)
            {
                if (number.ToString().Length != 1)
                {
                    spiral[i, m - 1] = number.ToString();    
                }
                else
                {
                    spiral[i, m - 1] = "0"+number.ToString();
                }
                number++;
            }
            
            for (int i = m-2; i >= n-m; i--)
            {
                if (number.ToString().Length != 1)
                {
                   spiral[m - 1, i] = number.ToString();   
                }
                else
                {
                    spiral[m - 1, i] = "0"+number.ToString(); 
                }
                number++;
            }

            for (int i = m - 2; i > n-m; i--)
            {
                if (number.ToString().Length != 1)
                {
                    spiral[i, n - m] = number.ToString();    
                }
                else
                {
                    spiral[i, n - m] = "0"+number.ToString();
                }
                number++;
            }

            m--;
            
        } while (number<=n*n);
        

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiral[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    }
}
