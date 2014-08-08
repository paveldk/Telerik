namespace ComputerParts.ComputerFactory
{
    using System.Collections.Generic;
    using ComputerParts;

    public class DellFactory : Factory
    {
        private readonly IVideoCard colorfullVideoCard = new ColorfulVideoCard();
        private readonly IVideoCard monochromeVideoCard = new MonochromeVideoCard();
        private readonly ILaptopBattery battery = new LaptopBattery();
        private IRam ram;
        private ICpu cpu;
        private IEnumerable<IHardDrive> hardDrives;
        private IComputer pc;
        private ILaptop laptop;
        private IServer server;

        public override ILaptop CreateLaptop()
        {
            this.ram = new Ram(8);
            this.cpu = new Cpu32Bit(4);
            this.hardDrives = new[] { new HardDrive(1000, false, 0) };

            var motherboard = new MotherBoard(this.cpu, this.ram, this.hardDrives, this.colorfullVideoCard);
            this.laptop = new Laptop(motherboard, new LaptopBattery());

            return this.laptop;
        }

        public override IComputer CreateComputer()
        {
            this.ram = new Ram(8);
            this.cpu = new Cpu64Bit(4);
            this.hardDrives = new[] { new HardDrive(1000, false, 0) };
            var motherboard = new MotherBoard(this.cpu, this.ram, this.hardDrives, this.colorfullVideoCard);
            this.pc = new Computer(motherboard);
            return this.pc;
        }

        public override IServer CreateServer()
        {
            this.ram = new Ram(64);
            this.cpu = new Cpu64Bit(8);
            this.hardDrives = new List<IHardDrive> { new HardDrive(0, true, 2, new List<IHardDrive> { new HardDrive(2000, false, 0), new HardDrive(2000, false, 0) }) };

            var motherboard = new MotherBoard(this.cpu, this.ram, this.hardDrives, this.monochromeVideoCard);
            this.server = new Server(motherboard);
            return this.server;
        }
    }
}