// Refactor the following code to apply variable usage and naming best practices:
namespace TaskTwo
{
    using System;
    using System.Linq;

    class Program
    {
        public void PrintStatistics(double[] array)
        {
            double max = double.MinValue; 
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                sum += array[i];
            }

            PrintMax(max);
            PrintAvg(sum / array.Length);
        }
    }
}
