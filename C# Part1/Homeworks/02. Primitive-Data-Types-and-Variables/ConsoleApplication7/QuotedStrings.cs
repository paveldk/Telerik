using System;

class QuotedStrings
{
    static void Main()
    {
        string WithQuotes = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(WithQuotes);
        string WithoutQuotes = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(WithoutQuotes);
    }
}