namespace MobilePhone
{
    using System;
    using System.Text;

    public class Call
    {
        /* Nothing special in here just creating the fields, properties for them with private 
         * sets, 1 constructors - with all properties and 1 override to ToString
         * */

        private DateTime date;
        private string dialedNumber;
        private uint duration;

        public Call(DateTime callDate, string callDialedNumber, uint callDuration)
        {
            this.Date = callDate;
            this.DialedNumber = callDialedNumber;
            this.Duration = callDuration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dialed number can't be null or empty");
                }

                this.dialedNumber = value;
            }
        }

        public uint Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't negative");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            // I'm using StringBuilder, becouse if his method AppendLine, in that way every field is on new line
            StringBuilder information = new StringBuilder();
            information.AppendLine("Call date and time: " + this.Date);
            information.AppendLine("Call number: " + this.DialedNumber);
            information.AppendLine("Duration(in sec): " + this.Duration);

            return information.ToString();
        }
    }
}
