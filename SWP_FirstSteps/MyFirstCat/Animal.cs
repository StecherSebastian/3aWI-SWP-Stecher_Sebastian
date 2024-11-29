using System;

namespace MyFirstCat
{
    class Animal : Creature
    {
        public string Name { get; set; }

        public Animal(string name, DateTime birthdate) : base(birthdate)
        {
            this.Name = name;
        }
    }
}
