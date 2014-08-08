namespace ComputerParts
{
    using System;

    public class ColorfulVideoCard : IVideoCard
    {
        public void Draw(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
