namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ComputerParts;
    using Telerik.JustMock;

    [TestClass]
    public class LaptopBatteryChargeTest
    {
        private ILaptopBattery battery;
        private IExtendedMotherBoard motherboard;
        private ILaptop laptop;

        [TestInitialize]
        public void CreateParts()
        {
            // I need motherboard only for creation of the laptop, not for the test, so I don't need real motherboard - using Mock one
            motherboard = Mock.Create<IExtendedMotherBoard>();
            battery = new LaptopBattery();
        }

        [TestMethod]
        public void AddingNegativeValueForChargeShouldDropCurrentCharge()
        {
            battery.Percentage = 100;
            laptop = new Laptop(motherboard, battery);
            laptop.ChargeBattery(-1);

            Assert.AreEqual(99, battery.Percentage); 
        }

        [TestMethod]
        public void AddingNegativeValueBiggerThenCurrentValueShouldMakeCurrentChargeToZero()
        {
            battery.Percentage = 100;
            laptop = new Laptop(motherboard, battery);
            laptop.ChargeBattery(-101);

            Assert.AreEqual(0, battery.Percentage);
        }

        [TestMethod]
        public void AddingValueToCurrentValueShouldIncreaseCurrentCharge()
        {
            battery.Percentage = 50;
            laptop = new Laptop(motherboard, battery);
            laptop.ChargeBattery(10);

            Assert.AreEqual(60, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNeverBeBiggerThen100()
        {
            battery.Percentage = 50;
            laptop = new Laptop(motherboard, battery);
            laptop.ChargeBattery(60);

            Assert.AreEqual(100, battery.Percentage);
        }

        [TestMethod]
        public void AddingNUllPercentageShouldThrowReferenceNullExeption()
        {
            battery.Percentage = 50;
            laptop = new Laptop(motherboard, battery);
            laptop.ChargeBattery(60);

            Assert.AreEqual(100, battery.Percentage);
        }

    }
}
