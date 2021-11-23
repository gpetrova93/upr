using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsNasledqwane
{
    class Dog : Animal
    {
        private string poroda;
        public Dog(string name, int age, string poroda) :base(name,age)
        {
            this.poroda = poroda;
        }
        public void Bark()
        {
            Console.WriteLine("bark");
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("porodata mi e: " + poroda);
        }
    }
}
