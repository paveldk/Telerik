using System;

class DifferentVariables
{
    static void Main()
    {
        //Write a program, that depending on user's choice inputs int, double or string variable. If the variable is integer or double, increase it with 1. If the variable is string, appends "a" at its end. The program must show the value of that variable as a console output. Use switch statement.

        Console.Write("Input value: ");
        string strvalue = Console.ReadLine();

        string type = "string";
        int intvalue;
        float floatvalue;

        if (int.TryParse(strvalue, out intvalue))
        {
            type = "integer"; 
        }

        if (float.TryParse(strvalue, out floatvalue))
        {
            type = "float"; 
        }

        switch (type)
        {
            case "string" :
                Console.WriteLine(strvalue+"*");
                break;
            case "integer" :
                Console.WriteLine(intvalue+1);
                break;
            case "float" :
                Console.WriteLine(floatvalue+1);
                break;
            default:
                break;
        }

    }
}
