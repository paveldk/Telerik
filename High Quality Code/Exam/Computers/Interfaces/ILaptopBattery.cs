namespace ComputerParts
{
    public interface ILaptopBattery
    {
        int Percentage
        {
            get;
            set;
        }

        void Charge(int procents);
    }
}
