using System;

class Triangle
{
    static void Main()
    {
        Console.Write("Please input number of rows:");
        int rows = int.Parse(Console.ReadLine());

        int Inc = 1;

        for (int i = 1; i <= rows; i++)
        {
            string Empty = new String(' ', (((2 * rows) - 1) - Inc) / 2);
            string Full = new String('\u00A9', Inc);

            Console.Write("{0}{1}{0}", Empty, Full); 
                      
            Console.WriteLine();
            Inc = Inc + 2; 
        } 
    }
}
