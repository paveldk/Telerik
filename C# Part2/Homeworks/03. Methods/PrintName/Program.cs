/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

 * */
using System;

class Program
{
    static void Main()
    {
        // two ways - one with calling method without params, one with params. For me more logical is with params, but the tasks is "to create method who asks for user name and prints Hello name" meaning that question must be IN the method.
        // PrintName();
        Console.Write("Your name: ");
        string name = Console.ReadLine();
        PrintName(name);
    }

  /*  static void PrintName()
    {
        Console.Write("Your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}", name);
    }*/

    static void PrintName(string name)
    {
        Console.WriteLine("Hello {0}", name);
    }
}
