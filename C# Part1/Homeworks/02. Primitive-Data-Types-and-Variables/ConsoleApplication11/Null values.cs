using System;

class Nullvalues
{
    static void Main()
    {
        int? someinteger = null;
        Console.WriteLine("This is the integer number with Null value -> " + someinteger);

        someinteger = someinteger + 5;
        Console.WriteLine("This is the integer number with Null + 5 value -> " + someinteger);

        double? somedouble = null;
        Console.WriteLine("This is the real number with Null value -> " + somedouble);

    }
}
