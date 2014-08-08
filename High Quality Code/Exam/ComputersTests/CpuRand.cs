namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ComputerParts;

    [TestClass]
    public class CpuRand
    {
        private ICpu cpu32;

        [TestInitialize]
        public void Initialization()
        {
            cpu32 = new Cpu32Bit(4);                    
        }

        [TestMethod]
        public void RandMethodShouldReturnValueInCorrectBounds()
        {
            Random rand = new Random();
            int randomNumber = cpu32.Rand(5, 6);
            var expected = 5;

            Assert.AreEqual(expected, randomNumber); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IfMInValueISGreaterThenMaValueExceptionShouldBeTrown()
        {
            Random rand = new Random();
            int randomNumber = cpu32.Rand(10, 1);
        }

    }
}
