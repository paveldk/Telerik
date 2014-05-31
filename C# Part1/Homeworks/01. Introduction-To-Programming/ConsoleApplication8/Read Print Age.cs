using System;

class ReadPrintAge
{
    static void Main()
    {
        int age;
        Console.WriteLine("Please input your age:");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years gonna be: "+(age+10));
    }
}
