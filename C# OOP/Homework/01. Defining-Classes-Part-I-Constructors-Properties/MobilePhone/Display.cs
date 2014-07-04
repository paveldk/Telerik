namespace MobilePhone
{
    using System;
    using System.Text;

    public class Display
    {
        /* Nothing special in here just creating the fields, properties for them with private 
         * sets, 2 constructors - one with no fields(no obligatory once), one with all and
         * 1 override to ToString
         * */
        private double? size = null;
        private uint? numberOfColors = null;

        public Display()
        {
        }

        public Display(double displaySize, uint displayNumberOfColors)
            : this()
        {
            this.Size = displaySize;
            this.NumberOfColors = displayNumberOfColors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size can't be 0 or negative");
                }

                this.size = value;
            }
        }

        public uint? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            private set
            {
                if (value < 2)
                {
                    throw new ArgumentException("There must be at least two colors!");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            // I'm using StringBuilder, becouse if his method AppendLine, in that way every field is on new line
            StringBuilder information = new StringBuilder();
            information.AppendLine("Size: " + this.Size);
            information.AppendLine("Number of colors: " + this.NumberOfColors);

            return information.ToString();
        }
    }
}
