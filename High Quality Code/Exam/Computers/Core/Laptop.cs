namespace ComputerParts
{
    public class Laptop : ILaptop
    {
        private const string BatteryStatus = "Battery status: {0}%";
        private readonly ILaptopBattery battery;
        private readonly IMotherboard motherboard;

        public Laptop() 
        { 
        }

        public Laptop(IMotherboard motherboard, ILaptopBattery battery)
        {
            this.motherboard = motherboard;
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.motherboard.DrawOnVideoCard(string.Format(BatteryStatus, this.battery.Percentage));         
        }
    }
}
