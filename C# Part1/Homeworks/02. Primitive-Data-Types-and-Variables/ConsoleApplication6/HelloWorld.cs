using System;

class HelloWorld
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object bothwords = word1 +" "+ word2;
        Console.WriteLine(bothwords);
        string StrHelloWorld = (string) bothwords;
        Console.WriteLine(StrHelloWorld);
    }
}
