namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ComputerParts;

    [TestClass]
    public class CpuSquareNumber
    {
        private ICpu cpu32, cpu64, cpu128;

        [TestInitialize]
        public void CreateParts()
        {
            cpu32 = new Cpu32Bit(4);
            cpu64 = new Cpu64Bit(4);
            cpu128 = new Cpu128Bit(4);
        }

        [TestMethod]
        public void IfNumberIsBellow0ShouldReturnCorrectMessagefor64BitCpu()
        {
            var result = cpu64.SquareNumber(-1);
            var expected = "Number too low.";
            Assert.AreEqual(expected, result); 
        }

        [TestMethod]
        public void IfNumberIsBellow0ShouldReturnCorrectMessagefor128BitCpu()
        {
            var result = cpu128.SquareNumber(-1);
            var expected = "Number too low.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IfNumberIsBellow0ShouldReturnCorrectMessagefor32BitCpu()
        {
            var result = cpu32.SquareNumber(-1);
            var expected = "Number too low.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IfNumberIsOver500For32BitCpuShouldReturnCorectMessage()
        {
            var result = cpu32.SquareNumber(501);
            var expected = "Number too high.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IfNumberIsOver1000For64BitCpuShouldReturnCorectMessage()
        {
            var result = cpu64.SquareNumber(1001);
            var message = "Number too high.";
            Assert.AreEqual(message, result);
        }

        [TestMethod]
        public void IfNumberIsOver2000For128BitCpuShouldReturnCorectMessage()
        {
            var result = cpu128.SquareNumber(2001);
            var expected = "Number too high.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TheMethodShouldReturnCorrectValuefor32BitCpu()
        {
            var result = cpu32.SquareNumber(500);
            var expected = "Square of 500 is 250000.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TheMethodShouldReturnCorrectValuefor64BitCpu()
        {
            var result = cpu64.SquareNumber(1000);
            var expected = "Square of 1000 is 1000000.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TheMethodShouldReturnCorrectValuefor128BitCpu()
        {
            var result = cpu128.SquareNumber(2000);
            var expected = "Square of 2000 is 4000000.";
            Assert.AreEqual(expected, result);
        }
    }
}
