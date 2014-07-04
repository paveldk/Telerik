namespace Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string fName, int fAge, string fSex)
            : base(fName, fAge, fSex)
        {
        }

        public void Say()
        {
            Console.WriteLine("Kvak");
        }
    }
}
