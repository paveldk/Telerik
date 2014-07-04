namespace MobilePhone
{
    using System;
    using System.Text;

    public class Battery
    {
        /* Nothing special in here just creating the fields, properties for them with private 
         * sets, 2 constructors - one with obligatory field, one with all(withoud DRY) and
         * 1 override to ToString
         * */

        private string model;
        private double? hoursIdle = null;
        private double? hoursTalk = null;
        private BatteryType type;

        public Battery(string batteryModel)
        {
            this.Model = batteryModel;
        }

        public Battery(string batteryModel, double batteryHoursIdle, double batteryHoursTalk, BatteryType batteryType) : this(batteryModel)
        {
            this.HoursIdle = batteryHoursIdle;
            this.HoursTalk = batteryHoursTalk;
            this.Type = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model can't be null or empty");
                }

                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours can't be 0 or negative");
                }

                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours can't be 0 or negative");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            // I'm using StringBuilder, becouse if his method AppendLine, in that way every field is on new line
            StringBuilder information = new StringBuilder();
            information.AppendLine("Model: " + this.Model);
            information.AppendLine("Hours idle: " + this.HoursIdle);
            information.AppendLine("Hours talk: " + this.HoursTalk);
            information.AppendLine("Type: " + this.Type);

            return information.ToString();
        }
    }
}
