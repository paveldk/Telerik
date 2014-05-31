using System;

class PrintMatrix
{
    static void Main()
    {
        /*Write a program that reads from the console a positive integer number 
         * N (N < 20) and outputs a matrix*/
        int n = 0;
        do
        {
            Console.Write("Input N (N>0 and N<20): ");
            n= int.Parse(Console.ReadLine());  
  
        } while (!(n>0)&&(n<20));
        
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(j+1+i+" ");
            }
            Console.WriteLine();
        }

    }
}
