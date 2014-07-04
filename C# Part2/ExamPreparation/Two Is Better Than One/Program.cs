using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Is_Better_Than_One
{
    class Program
    {
        static void Main()
        {
            string task1 = Console.ReadLine();
            string task2 = Console.ReadLine();
            decimal percent = decimal.Parse(Console.ReadLine());

            int index = task1.IndexOf(" ");
            long firstNumber = long.Parse(task1.Substring(0, index));
            long secondNumber = long.Parse(task1.Substring(index));

            int count = 0;

            for (long i = firstNumber; i < secondNumber; i++)
            {
                StringBuilder temp = new StringBuilder();
                for (int j = i.ToString().Length - 1; j >=0 ; j--)
                {
                    if (i.ToString()[j] == '3' || i.ToString()[j] == '5')
                    {
                        temp.Append(i.ToString()[j]); ; 
                    }
                    else
                    {
                        break;
                    }
                }
                if (i.ToString().Equals(temp.ToString()))
                {
                    count++;    
                }
            }

            Console.WriteLine(count);


            var secondTaskNumbersListParts = task2.Split(',');
            var numbers = new List<int>();
            foreach (var numberAsString in secondTaskNumbersListParts)
            {
                numbers.Add(int.Parse(numberAsString));
            }

            numbers.Sort();

            int countOfSmallerOrEqualNumber = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                countOfSmallerOrEqualNumber = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (Convert.ToInt32(numbers[i]) >= Convert.ToInt32(numbers[j]))
                    {
                        countOfSmallerOrEqualNumber++;
                    }
                }

                if (countOfSmallerOrEqualNumber >= numbers.Count * (percent / 100))
                {
                    countOfSmallerOrEqualNumber = Convert.ToInt32(numbers[i]);
                    break;
                }   
            }

            if (countOfSmallerOrEqualNumber == 0)
            {
                countOfSmallerOrEqualNumber = numbers[numbers.Count - 1];    
            }

            Console.WriteLine(countOfSmallerOrEqualNumber);
        }
    }
}
