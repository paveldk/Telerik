// Refactor the following class using best practices for organizing straight-line code:
namespace TaskOne
{
    using System;
    using System.Linq;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();
            
            Peel(potato);
            Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);
            
            this.bowl.Add(carrot);
            this.bowl.Add(potato);
        }

        private Potato GetPotato()
        {
            // ...
        }

        private Carrot GetCarrot()
        {
            // ...
        }

        private Bowl GetBowl()
        {
            // ... 
        }

        private void Cut(Vegetable potato)
        {
            // ...
        }
    }
}
