namespace ComputerParts
{
    using System;

    public class MonochromeVideoCard : IVideoCard
    {
        public void Draw(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
