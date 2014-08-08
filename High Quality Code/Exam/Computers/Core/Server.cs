namespace ComputerParts
{
    public class Server : IServer
    {
        private IExtendedMotherBoard motherboard;

        public Server() 
        { 
        }

        public Server(IExtendedMotherBoard motherboard)
        {
            this.motherboard = motherboard;
        }

        public void Process(int data)
        {
            this.motherboard.SaveRamValue(data);
            this.motherboard.DrawOnVideoCard(this.motherboard.SquareNumber(data));
        }
    }
}
