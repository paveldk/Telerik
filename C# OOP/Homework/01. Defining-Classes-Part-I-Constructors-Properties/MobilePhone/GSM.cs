namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        /* Here we have little bit more stuffs:
         *  - static Constructor
         *  - 3 more without DRY - 1 with obligatory, other with the 4 fields using build types and 1 with everythng
         *  - static Property(for the Iphone)
         *  - 4 methods - Add, Delete Calls, Clear History and Calculate price
         *  - override toString
         * */
        private static GSM iPhone4S;
        private string model;
        private string manifacturer;
        private double? price = null;
        private string owner = null;
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
        private List<Call> callHistory;

        static GSM()
        {
            iPhone4S = new GSM("Iphone 4S", "Apple", 1500, "Not me EVER");
        }

        public GSM(string gsmModel, string gsmManifacturer)
        {
            this.CallHistory = new List<Call>();
            this.Model = gsmModel;
            this.Manifacturer = gsmManifacturer;
        }

        public GSM(string gsmModel, string gsmManifacturer, double gsmPrice, string gsmOwner) : this(gsmModel, gsmManifacturer)
        {
            this.Model = gsmModel;
            this.Manifacturer = gsmManifacturer;
            this.Price = gsmPrice;
            this.Owner = gsmOwner;
        }

        public GSM(string gsmModel, string gsmManifacturer, double gsmPrice, string gsmOwner, Battery gsmBatteryCharacteristics, Display gsmDisplayCharacteristics) : this(gsmModel, gsmManifacturer, gsmPrice, gsmOwner)
        {            
            this.batteryCharacteristics = gsmBatteryCharacteristics;
            this.displayCharacteristics = gsmDisplayCharacteristics;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
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

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manifacturer can't be null or empty");
                }

                this.manifacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can't be 0 or negative");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner can't be null or empty");
                }

                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            private set
            {
                this.callHistory = value;
            }
        }
        
        public void AddCall(Call newCall)
        {
            // just add to List the call from the Main
            this.CallHistory.Add(newCall);
        }

        public void DeleteCall(Call oldCall)
        {
            // remove from List the call from Main(if exists)
            this.CallHistory.Remove(oldCall);
        }

        public void ClearHistory()
        {
            // Clear the List
            this.CallHistory.Clear();
        }

        public decimal CalculateCost(decimal price)
        {
            /* calculate all the duration in the List, devide the total sum to 60
             * (to make them in minutes), multiply with the parameter price and return it
             * */
            
            decimal totalCost = 0;
            decimal totalDuration = 0;

            foreach (var call in this.callHistory)
            {
                totalDuration = totalDuration + call.Duration; 
            }

            totalDuration = totalDuration / 60;

            totalCost = totalDuration * price;

            return totalCost;
        }

        public override string ToString()
        {
            // I'm using StringBuilder, becouse if his method AppendLine, in that way every field is on new line
            StringBuilder information = new StringBuilder();
            information.AppendLine("Model: " + this.Model);
            information.AppendLine("Manifacturer: " + this.Manifacturer);
            information.AppendLine("Price: " + this.Price);
            information.AppendLine("Owner: " + this.Owner);
            information.AppendLine("Battery:");
            information.Append(string.Empty + this.batteryCharacteristics);
            information.AppendLine("Display:");
            information.Append(string.Empty + this.displayCharacteristics);

            return information.ToString();
        }
    }
}
