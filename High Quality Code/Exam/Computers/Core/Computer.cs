namespace ComputerParts
{
    public class Computer : IComputer
    {
        private const string WinMessage = "You win!";
        private const string LostMessage = "You didn't guess the number {0}.";
        private readonly IExtendedMotherBoard motherboard;

        public Computer() 
        { 
        }

        public Computer(IExtendedMotherBoard motherboard)
        {
            this.motherboard = motherboard;
        }

        public void Play(int guessNumber)
        {
            int randomnumber = this.motherboard.Rand(1, 10);
            
            if (randomnumber != guessNumber)
            {
                this.motherboard.DrawOnVideoCard(string.Format(LostMessage, randomnumber));
            }
            else
            {
                this.motherboard.DrawOnVideoCard(WinMessage);
            }
        }
    }
}
