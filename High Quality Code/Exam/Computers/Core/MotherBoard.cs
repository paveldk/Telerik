namespace ComputerParts
{
    using System.Collections.Generic;

    public class MotherBoard : IExtendedMotherBoard
    {
        private readonly IVideoCard videoCard;
        private readonly IRam ram;
        private readonly IEnumerable<IHardDrive> hardDrives;
        private readonly ICpu cpu;

        public MotherBoard(ICpu cpu, IRam ram, IEnumerable<IHardDrive> hardDrives, IVideoCard videoCard)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.hardDrives = hardDrives;
            this.videoCard = videoCard;
        }

        public int LoadRamValue()
        {
            return this.ram.LoadValue();
        }

        public void SaveRamValue(int value)
        {
            this.ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.videoCard.Draw(data);
        }

        public int Rand(int a, int b)
        {
            var result = this.cpu.Rand(a, b);
            return result;          
        }

        public string SquareNumber(int data)
        {
            var result = this.cpu.SquareNumber(data);
            return result;
        }
    }
}
