using System;

namespace AnimalsNasledqwane
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("jony", 1, "pekinez");
            d.Bark();
            d.Eat();
            Puppy p = new Puppy("sharo", 1, "pincher");
            p.Bark();
            p.Eat();
            p.Weep();
            p.Print();
        }
    }
}
