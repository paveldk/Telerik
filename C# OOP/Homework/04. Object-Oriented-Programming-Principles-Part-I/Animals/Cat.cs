namespace Animals
{
    using System;

    public abstract class Cat : Animal, ISound
    {
        public Cat(string cName, int cAge, string cSex)
            : base(cName, cAge, cSex)
        {
        }

        public void Say()
        {
            Console.WriteLine("Myauu");
        }
    }
}
