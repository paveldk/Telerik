/* Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 * */
namespace CheckIfBracketsAreCorrect
{
    using System;

    class Program
    {
        static void Main()
        {
            int brackets = 0;          
            string experssion = Console.ReadLine();

            for (int i = 0; i < experssion.Length; i++)
            {              
                if (experssion[i] == '(')
                {
                    // if during the loop we find ( we increase number of brackets
                    brackets++; 
                }
                else if (experssion[i] == ')')
                {
                    // and if we find ) we decrease it
                    brackets--;  
                }

                if (brackets < 0)
                {
                    /* and if at some point there is closing bracket before oppening the 
                     * bracket variable gonna become less than 0 so we just need to break
                     * */
                    break;    
                }
            }

            /* and to be the expression correct bracket needs to be 0 - exactly same number
             * openning and closing brackets
             * */
            if (brackets == 0)
            {
                Console.WriteLine("The expression {0} is correct!", experssion);                  
            }
            else
            {
                Console.WriteLine("The expression {0} isn't correct!", experssion); 
            }
        }
    }
}
