using System;
using System.IO;


class Smetalnik
{
    static void Main(string[] args)
    {
        //autotest new stream, do comment if input is local
      /*  if (Environment.CurrentDirectory
                       .ToLower()
                       .EndsWith("bin\\debug"))
        {
            Console.SetIn(new StreamReader("test.005.in.txt"));
        }*/

        int smetaloWidth = int.Parse(Console.ReadLine());

        long[,] smetalo = new long[8, smetaloWidth];

        //fill array
        for (int row = 0; row < 8; row++)
        {
            long numberInput = long.Parse(Console.ReadLine());

            for (int col = 0; col < smetaloWidth; col++)
            {
                smetalo[row, col] = (numberInput >> smetaloWidth - 1 - col) & 1L;
            }
        }
        //falling "topcheta" :)
        while (true)
        {
            string command = Console.ReadLine();

            if (command == "stop")
                break;
            else if (command == "left")
            {
                int indexLine = int.Parse(Console.ReadLine());
                int indexPosition = int.Parse(Console.ReadLine());

                for (int i = 0; i < indexPosition; i++)
                {
                    for (int j = 1; j <= indexPosition-1; j++)
                    {
                        if ((j-1>0) && (j<32))
                        {
                            long mask = smetalo[indexLine, j - 1];
                            smetalo[indexLine, j - 1] |= smetalo[indexLine, j];
                            smetalo[indexLine, j] &= mask;                            
                        }

                    }
                }
            }
            else if (command == "right")
            {
                int indexLine = int.Parse(Console.ReadLine());
                int indexPosition = int.Parse(Console.ReadLine());

                for (int i = 0; i < indexPosition; i++)
                {
                    for (int j = 1; j <= indexPosition; j++)
                    {
                        if (smetaloWidth - j - 1>0)
                        {
                            long mask = smetalo[indexLine, smetaloWidth - j];
                            smetalo[indexLine, smetaloWidth - j] |= smetalo[indexLine, smetaloWidth - j - 1];
                            smetalo[indexLine, smetaloWidth - j - 1] &= mask;                            
                        }

                    }
                }
            }
            else if (command == "reset")
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int k = 0; k < smetaloWidth; k++)
                    {
                        for (int j = 1; j < smetaloWidth; j++)
                        {
                            long mask = smetalo[i, j - 1];
                            smetalo[i, j - 1] |= smetalo[i, j];
                            smetalo[i, j] &= mask;
                        }
                    }
                }
            }
        }

        //output
        string outputLine = "";
        long result = 0;
        int countEmptyCol = 0;

        //sum of lines like numbers
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < smetaloWidth; col++)
            {
                outputLine += "" + smetalo[row, col];
            }
            result += Convert.ToInt64(outputLine, 2);
            outputLine = "";
        }

        //empty columns counting
        for (int col = 0; col < smetaloWidth; col++)
        {
            long temp = 0;

            for (int row = 0; row < 8; row++)
            {
                temp += smetalo[row, col];
            }

            if (temp == 0)
                countEmptyCol++;
        }
        Console.WriteLine(result *= countEmptyCol);
    }

    // helper function - fancy method to print arrays in columns
    private static void PrintArray(long[,] array)
    {
        int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write(" "); Console.Write(array[row, column].ToString());
            }
            Console.WriteLine();
        }
    }
}