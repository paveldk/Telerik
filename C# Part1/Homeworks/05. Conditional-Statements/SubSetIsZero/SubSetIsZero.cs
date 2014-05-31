using System;

class SubSetIsZero
{
    static void Main()
    {
        //We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.

        int[] numbers = new int[5];
        numbers[0]=3;
        numbers[1]=-3;
        numbers[2]=1;
        numbers[3]=2;
        numbers[4]=-1;
        int sum; 

        
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i]==0)
            {
                Console.WriteLine(numbers[i]);
            }
            for (int j = i+1; j < 5; j++)
            {
                sum = numbers[i] + numbers[j];
                if (sum==0)
                {
                    Console.WriteLine(numbers[i]+" "+numbers[j]);
                }

                for (int k = j+1; k < 5; k++)
                {
                    sum = sum + numbers[k];
                    if (sum == 0)
                    {
                        Console.WriteLine(numbers[i]+" "+numbers[j]+" "+numbers[k]);
                    }

                    for (int l = k + 1; l < 5; l++)
                    {
                        sum = sum + numbers[l];
                        if (sum == 0)
                        {
                            Console.WriteLine(numbers[i] + " " + numbers[j] + " " + numbers[k]+" "+numbers[l]);
                        }

                    }
                }
            }            
        }


    }
}
