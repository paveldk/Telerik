namespace Task1
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
            string temp = string.Empty;
            string[] sevenNumeralSystem = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
            string sevenNumeralNumber = string.Empty;


            for (int i = 0; i < input.Length; i++)
            {
                temp = temp + input[i];
                for (int j = 0; j < sevenNumeralSystem.Length; j++)
                {
                    if (temp == sevenNumeralSystem[j])
                    {
                        sevenNumeralNumber = sevenNumeralNumber +j ;
                        temp = string.Empty;
                    }    
                }
            }

            int index = 0;
            decimal result = 0;

            for (int i = sevenNumeralNumber.Length - 1; i >= 0 ; i--)
            {
                decimal current = 1;
                for (int j = 0; j < index; j++)
                {
                    current = current * 7;    
                }

                result = result + ((sevenNumeralNumber[i] - 48) * current);
                index++;            
            }

            Console.WriteLine(result);
        }
    }
}
