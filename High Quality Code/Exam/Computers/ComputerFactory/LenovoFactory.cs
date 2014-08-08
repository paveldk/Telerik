namespace ComputerParts.ComputerFactory
{
    using System.Collections.Generic;
    using ComputerParts;

    public class LenovoFactory : Factory
    {
        private readonly IVideoCard colorfullVideoCard = new ColorfulVideoCard();
        private readonly IVideoCard monoChromeVideoCard = new MonochromeVideoCard();
        private readonly ILaptopBattery battery = new LaptopBattery();
        private IComputer pc;
        private ILaptop laptop;
        private IServer server;

        public override ILaptop CreateLaptop()
        {
            var cpu = new Cpu64Bit(2);
            var ram = new Ram(16);
            var hardDrives = new[] { new HardDrive(1000, false, 0) };
            var motherboard = new MotherBoard(cpu,  ram, hardDrives, this.colorfullVideoCard);

            this.laptop = new Laptop(motherboard, new LaptopBattery());

            return this.laptop;
        }

        public override IComputer CreateComputer()
        {
            var ram = new Ram(4);
            var cpu = new Cpu64Bit(4);
            var hardrives = new[] { new HardDrive(2000, false, 0) };
            var motherboard = new MotherBoard(cpu, ram, hardrives, this.monoChromeVideoCard);
            this.pc = new Computer(motherboard);
            return this.pc;
        }

        public override IServer CreateServer()
        {
            var ram = new Ram(64);
            var cpu = new Cpu128Bit(2);
            var hardrives = new List<IHardDrive> { new HardDrive(0, true, 2, new List<IHardDrive> { new HardDrive(500, false, 0), new HardDrive(500, false, 0) }) };
            var motherboard = new MotherBoard(cpu, ram, hardrives, this.monoChromeVideoCard);
            this.server = new Server(motherboard);
            return this.server;
        }
    }
}
