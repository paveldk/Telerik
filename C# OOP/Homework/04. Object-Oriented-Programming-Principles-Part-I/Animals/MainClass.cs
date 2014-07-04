namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {      
            // Cats
            var cats = new List<Cat>(); 
            Kitten femaleCat;

            femaleCat = new Kitten("Loly", 3);
            cats.Add(femaleCat);

            femaleCat = new Kitten("Moly", 12);
            cats.Add(femaleCat);

            femaleCat = new Kitten("Doly", 2);
            cats.Add(femaleCat);

            var maleCats = new List<TomCat>();
            TomCat maleCat;

            maleCat = new TomCat("Tom", 6);
            cats.Add(maleCat);

            maleCat = new TomCat("Maxuel", 10);
            cats.Add(maleCat);

            maleCat = new TomCat("Muri", 1);
            cats.Add(maleCat);

            // Dogs
            var dogs = new List<Dog>();
            Dog dog;

            dog = new Dog("Sharo", 8, "male");
            dogs.Add(dog);

            dog = new Dog("Pesho", 6, "male");
            dogs.Add(dog);

            dog = new Dog("Kaya", 3, "female");
            dogs.Add(dog);

            // Frogs
            var frogs = new List<Frog>();
            Frog frog;

            frog = new Frog("Kvaki", 5, "male");
            frogs.Add(frog);

            frog = new Frog("Kvuki", 12, "male");
            frogs.Add(frog);

            frog = new Frog("Kveki", 2, "female");
            frogs.Add(frog);

            Console.WriteLine("Avarage cats age is {0}", cats.Average(c => c.Age));
            Console.WriteLine("Avarage dog age is {0}", dogs.Average(d => d.Age));
            Console.WriteLine("Avarage frog age is {0}", frogs.Average(f => f.Age));
        }
    }
}
