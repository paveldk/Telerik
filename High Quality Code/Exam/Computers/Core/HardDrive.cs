namespace ComputerParts
{
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive : IHardDrive
    {
        private readonly bool isInRaid;
        private readonly int hardDrivesInRaid;
        private readonly List<IHardDrive> hardDrives;
        private readonly int capacity;
        private readonly Dictionary<int, string> capacityData;

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.capacityData = new Dictionary<int, string>(capacity);
            this.hardDrives = new List<IHardDrive>();
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List<IHardDrive> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.capacityData = new Dictionary<int, string>(capacity);
            this.hardDrives = hardDrives;
        }

        public int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.hardDrives.Any())
                    {
                        return 0;
                    }

                    return this.hardDrives.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }
    }
}