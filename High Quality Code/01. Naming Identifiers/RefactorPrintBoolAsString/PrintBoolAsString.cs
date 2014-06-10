// Task 1. Refactor the following examples to produce code with well-named C# identifiers:

using System;

class PrintBoolAsString
{
    const int MaxCount = 6;

    public static void Метод_За_Вход()
    {
        PrintBoolAsString.PrintInConsole instance = new PrintBoolAsString.PrintInConsole();
        instance.Print(true);
    }

    class PrintInConsole
    {
        public void Print(bool boolVariable)
        {
            string boolVariableAsString = boolVariable.ToString();
            Console.WriteLine(boolVariableAsString);
        }
    }
}
