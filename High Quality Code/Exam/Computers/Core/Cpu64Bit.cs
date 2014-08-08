namespace ComputerParts
{
    public class Cpu64Bit : Cpu32Bit
    {
        private const string LowNumber = "Number too low.";
        private const string HighNumber = "Number too high.";
        private const string SquareText = "Square of {0} is {1}.";

        public Cpu64Bit(byte numberOfCores)
            : base(numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        public override string SquareNumber(int data)
        {
            if (data < 0)
            {
                return LowNumber;
            }
            else if (data > 1000)
            {
                return HighNumber;
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                return string.Format(SquareText, data, value);
            }
        }
    }
}
