namespace ComputerParts.ComputerFactory
{
    public abstract class Factory
    {
        public abstract ILaptop CreateLaptop();

        public abstract IComputer CreateComputer();

        public abstract IServer CreateServer();
    }
}
