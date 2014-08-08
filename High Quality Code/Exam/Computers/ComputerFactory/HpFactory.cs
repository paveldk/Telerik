namespace ComputerParts.ComputerFactory
{
    using System.Collections.Generic;
    using ComputerParts;

    public class HpFactory : Factory
    {
        private readonly IVideoCard colorfullVideoCard = new ColorfulVideoCard();
        private readonly IVideoCard monochromeVideoCard = new MonochromeVideoCard();
        private readonly ILaptopBattery battery = new LaptopBattery();   
        private IComputer pc;
        private ILaptop laptop;
        private IServer server;

        public override ILaptop CreateLaptop()
        {
            var cpu = new Cpu64Bit(2);
            var harddrives = new[] { new HardDrive(500, false, 0) };
            var ram = new Ram(4);
            var motherboard = new MotherBoard(cpu, ram, harddrives, this.colorfullVideoCard);
            this.laptop = new Laptop(motherboard, this.battery);
            return this.laptop;
        }

        public override IComputer CreateComputer()
        {
            var cpu = new Cpu32Bit(2);
            var harddrives = new[] { new HardDrive(500, false, 0) };
            var ram = new Ram(2);
            var motherboard = new MotherBoard(cpu, ram, harddrives, this.colorfullVideoCard);
            this.pc = new Computer(motherboard);
            return this.pc;
        }

        public override IServer CreateServer()
        {
            var ram = new Ram(32);
            var cpu = new Cpu32Bit(4);
            var hardrives = new List<IHardDrive> { new HardDrive(0, true, 2, new List<IHardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) };
            var motherboard = new MotherBoard(cpu, ram, hardrives, this.monochromeVideoCard);
            this.server = new Server(motherboard);
            return this.server;
        }
    }
}