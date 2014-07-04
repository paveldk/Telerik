namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var inputParts = input.Split(' ');
            var path = new List<BigInteger>();
            foreach (var items in inputParts)
            {
                path.Add(BigInteger.Parse(items));
            }

            BigInteger mollyIndex = 0;
            BigInteger mollyScore = path[0];
            BigInteger dollyIndex = path.Count - 1;
            BigInteger dollyScore = path[path.Count - 1];


            BigInteger molyMoves = path[0];
            BigInteger dolyMoves = path[path.Count - 1];
            

            if (path[(int)mollyIndex] == 0 && path[(int)dollyIndex] == 0)
            {
                Console.WriteLine("Draw");
                Console.WriteLine(mollyScore + " " + dollyScore);
                Environment.Exit(0);
            }

            if (path[(int)mollyIndex] == 0)
            {
                Console.WriteLine("Dolly");
                Console.WriteLine(mollyScore + " " + dollyScore);
                Environment.Exit(0);
            }

            if (path[(int)dollyIndex] == 0)
            {
                Console.WriteLine("Molly");
                Console.WriteLine(mollyScore + " " + dollyScore);
                Environment.Exit(0);
            }

            path[0] = 0;
            path[path.Count - 1] = 0;

            BigInteger mollyTemp = 0;
            BigInteger dollyTemp = 0;

            while (true)
            {
                mollyIndex = (BigInteger)(mollyIndex + molyMoves) % path.Count;
                dollyIndex = (BigInteger)(dollyIndex - dolyMoves) % path.Count;

                if (dollyIndex < 0)
                {
                    dollyIndex = path.Count + dollyIndex;
                }

                if (mollyIndex == dollyIndex)
                {
                    if ((path[(int)mollyIndex] % 2) == 0)
                    {
                        mollyScore = mollyScore + (path[(int)mollyIndex] / 2);
                        dollyScore = dollyScore + (path[(int)dollyIndex] / 2);
                        molyMoves = path[(int)mollyIndex];
                        dolyMoves = path[(int)dollyIndex];
                        mollyTemp = 0;
                        dollyTemp = 0;
                    }
                    else
                    {
                        mollyScore = mollyScore + ((path[(int)mollyIndex] - 1) / 2);
                        dollyScore = dollyScore + ((path[(int)dollyIndex] - 1) / 2);
                        molyMoves = path[(int)mollyIndex];
                        dolyMoves = path[(int)dollyIndex];
                        mollyTemp = 1;
                        dollyTemp = 1;
                    }
                }
                else
                {
                    mollyScore = mollyScore + path[(int)mollyIndex];
                    dollyScore = dollyScore + path[(int)dollyIndex];
                    molyMoves = path[(int)mollyIndex];
                    dolyMoves = path[(int)dollyIndex];
                    mollyTemp = 0;
                    dollyTemp = 0;
                    //path[mollyIndex] = 0;
                    //path[dollyIndex] = 0;
                }

                if (path[(int)mollyIndex] == 0 && path[(int)dollyIndex] == 0)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine(mollyScore + " " + dollyScore);
                    break;
                }

                if (path[(int)mollyIndex] == 0)
                {
                    Console.WriteLine("Dolly");
                    Console.WriteLine(mollyScore + " " + dollyScore);
                    break;
                }

                if (path[(int)dollyIndex] == 0)
                {
                    Console.WriteLine("Molly");
                    Console.WriteLine(mollyScore + " " + dollyScore);
                    break;
                }

                

                path[(int)mollyIndex] = mollyTemp;
                path[(int)dollyIndex] = dollyTemp;
            }            
        }

    }
}