namespace ComputerParts
{
    using System;

    public class Cpu32Bit : ICpu
    {
        private const string LowNumber = "Number too low.";
        private const string HighNumber = "Number too high.";
        private const string SquareText = "Square of {0} is {1}.";
        private static readonly Random Random = new Random();

        public Cpu32Bit(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        public byte NumberOfCores
        {
            get;
            set;
        }

        public virtual int Rand(int a, int b)
        {
            int randomNumber;
            randomNumber = Random.Next(a, b);
            return randomNumber;
        }

        public virtual string SquareNumber(int data)
        {
            if (data < 0)
            {
                return LowNumber;
            }
            else if (data > 500)
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
