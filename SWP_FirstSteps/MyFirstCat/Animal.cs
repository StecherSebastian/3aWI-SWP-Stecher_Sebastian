using System;

namespace MyFirstCat
{
    class Animal : Creature
    {
        private int _Legs;
        public int Legs { get { return _Legs; } }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name}: *animal sound*");
        }
        public Animal(string name, string color, DateTime birthdate, int legs) : base(name, color, birthdate) 
        {
            _Legs = legs;
        }
    }
}
