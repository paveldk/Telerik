// Refactor the following if statements: 
namespace TaskTwo
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Part one
            Potato potato;

            // ... 
            if (potato != null)
            {
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            } 
            
            // Part two
            bool inRange = MIN_X <= x & x <= MAX_X && MIN_Y <= y && y <= MAX_Y;

            if (inRange && shouldVisitCell)
            {
               VisitCell();
            } 
        }
    }
}
