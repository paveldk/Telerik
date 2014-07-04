using System;

class Polynomials
{
   
    static void Main()
    {
        //input data
        string a = Console.ReadLine();
        int Int;
        long Long;
        double Double;

        
        if (Int32.TryParse(a, out Int))
        {
            Console.WriteLine("int");
        }
        else if(Int64.TryParse(a, out Long))
        {
            Console.WriteLine("long");
        }
        else if (double.TryParse(a, out Double))
        {
            Console.WriteLine("double");
        }
    }
}