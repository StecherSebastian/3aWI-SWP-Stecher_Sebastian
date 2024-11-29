using System;

namespace MyFirstCat
{
    class Cat : Animal
    {
        public Cat(DateTime birthdate, string name = "not defiend", string color = "nothing", int legs = 4) : base(name, color, birthdate, legs) {}
        public override void Speak()
        {
            Console.WriteLine($"{Name}: *miau*");
        }
        public override string ToString()
        {
            return $"{Name} is {Color}, is {Age} years old and walks on {Legs} Legs.";
        }
    }
}
