using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsNasledqwane
{
    class Animal
    {
        private string name;
        private int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Eat()
        {
            Console.WriteLine("eating");
        }
        public void Print()
        {
            Console.WriteLine("az sym " + name + "i sym na " + age + "godini");
        }
    }
}
