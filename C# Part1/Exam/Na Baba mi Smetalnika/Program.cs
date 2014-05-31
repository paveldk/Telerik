using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] smetalo = new int[8, n];

        for (int i = 0; i < 8; i++)
        {
            int Number = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;

            while (Number > 0)
            {
                remainder = Number % 2;
                Number /= 2;
                result = remainder.ToString() + result;
            }

            string temp = result;

            for (int j = 0; j < n - result.Length; j++)
            {
                temp = "0" + temp;
            }

            result = temp;

            for (int j = result.Length - 1; j >= 0; j--)
            {
                smetalo[i, j] = result[j] - 48;
            }

        }

        /*   for (int i = 0; i < 8; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write(smetalo[i, j]);   
               }
               Console.WriteLine();
           }*/

        do
        {
            string command = Console.ReadLine();
            int line = 0;
            int prustPos = 0;
            int count = 0;

            if (command == "stop")
            {
                break;
            }

            if (command == "right")
            {
                //plusa nishto ne pravi
                line = int.Parse(Console.ReadLine());
                prustPos = int.Parse(Console.ReadLine());
                count = 0;

                if (prustPos < 0)
                {
                    prustPos = 0;
                }
                if (prustPos > n)
                {
                    prustPos = n;
                }
                for (int i = prustPos; i < n; i++)
                {
                    if (smetalo[line, i] == 1)
                    {
                        count++;
                        smetalo[line, i] = 0;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    smetalo[line, n - 1 - i] = 1;
                }
            }

            if (command == "left")
            {
                //minusa nishto ne pravi
                line = int.Parse(Console.ReadLine());
                prustPos = int.Parse(Console.ReadLine());
                count = 0;

                if (prustPos >= n)
                {
                    prustPos = n-1;
                }

                if (prustPos < 0)
                {
                    prustPos = 0;
                }
                for (int i = 0; i <= prustPos; i++)
                {
                    if (smetalo[line, i] == 1)
                    {
                        count++;
                        smetalo[line, i] = 0;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    smetalo[line, i] = 1;
                }
            }

            if (command == "reset")
            {
                count = 0;

                for (int i = 0; i < 8; i++)
                {
                    count = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (smetalo[i, j] == 1)
                        {
                            count++;
                            smetalo[i, j] = 0;
                        }
                    }

                    for (int j = 0; j < count; j++)
                    {
                        smetalo[i, j] = 1;
                    }
                }


            }

            /*     for (int i = 0; i < 8; i++)
                 {
                     for (int j = 0; j < n; j++)
                     {
                         Console.Write(smetalo[i, j]);
                     }
                     Console.WriteLine();
                 }*/
        } while (true);

        long resultat = 0;
        for (int i = 0; i < 8; i++)
        {
            long multi = 1;
            string temp = "";

            for (int j = 0; j < n; j++)
            {
                temp = "" + smetalo[i, j] + temp;
            }

            for (int j = 0; j < n; j++)
            {
                resultat = resultat + Convert.ToInt64(temp[j] - 48) * multi;
                multi *= 2;
            }
        }

        long broi = 0;
        for (int i = 0; i < n; i++)
        {
            bool imaLi = false;
            for (int j = 0; j < 8; j++)
            {
                if (smetalo[j, i] == 1)
                {
                    imaLi = true;
                }
            }
            if (imaLi == false)
            {
                broi++;
            }
        }
        Console.WriteLine(resultat);
        Console.WriteLine(broi);
        Console.WriteLine(resultat * broi);

    }
}