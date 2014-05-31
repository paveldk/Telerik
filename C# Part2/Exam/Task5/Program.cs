namespace Task5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string dimensions = Console.ReadLine();
            int spaceIndex = dimensions.IndexOf(' ');
            int N = int.Parse(dimensions.Substring(0, spaceIndex));
            int M = int.Parse(dimensions.Substring(spaceIndex+1));

            int numberOfCoins = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];

            for (int i = 0; i < numberOfCoins; i++)
            {
                string coinLocation = Console.ReadLine();
                spaceIndex = coinLocation.IndexOf(' ');
                int coinX = int.Parse(coinLocation.Substring(0, spaceIndex));
                int coinY = int.Parse(coinLocation.Substring(spaceIndex + 1));
                matrix[coinX, coinY] = matrix[coinX, coinY] + 1;
            }

            int count = matrix[0, 0];
            int currentX = 0;
            int currentY = 0;

            //while (true)
            //{
            //    if (currentX < N - 1)
            //    {
            //        currentX += 1;
            //    }
            //    if (currentY < M - 1)
            //    {
            //        currentY += 1;
            //    }
            //    count = count + matrix[currentX, currentY];
            //    if (currentX == N - 1 && currentY == M - 1)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(count);

            //while (true)
            //{
            //    if (currentX < N - 1)
            //    {
            //        currentX += 1;
            //    }
            //    else
            //    {
            //        if (currentY < M - 1)
            //        {
            //            currentY += 1;
            //        }
            //    }
                
            //    count = count + matrix[currentX, currentY];
            //    if (currentX == N - 1 && currentY == M - 1)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(count);

            while (true)
            {
                if (currentY < M - 1)
                {
                    currentY += 1;
                }
                else
                {
                    if (currentX < N - 1)
                    {
                        currentX += 1;
                    }
                }

                count = count + matrix[currentX, currentY];
                if (currentX == N - 1 && currentY == M - 1)
                {
                    break;
                }
            }
            Console.WriteLine(count);

            // Solve
            //var answer = new int[N, M];
            //for (int x = 0; x < N; x++)
            //{
            //    for (int y = 0; y < M; y++)
            //    {
            //        int up = 0, left = 0;
            //        if (x > 0)
            //        {
            //            up = answer[x - 1, y];
            //        }

            //        if (y > 0)
            //        {
            //            left = answer[x, y - 1];
            //        }

            //        answer[x, y] = Math.Max(up, left) + matrix[x, y];
            //    }
            //}

            //// Print answer
            //Console.WriteLine(answer[N - 1, M - 1]);
        }
    }
}
