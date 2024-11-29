using System;

namespace MyFirstCat
{
    class Cat : Animal
    {
        public Cat(DateTime birthdate, string name = "not defiend", string color = "nothing") : base(name, color, birthdate) {}
        public override string ToString()
        {
            return $"Name: {Name} Color: {Color} Age: {Age}";
        }
    }
}
