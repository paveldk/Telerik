namespace Animals
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string dName, int dAge, string dSex) : base(dName, dAge, dSex)
        {
        }

        public void Say()
        {
            Console.WriteLine("Bau");
        }
    }
}
