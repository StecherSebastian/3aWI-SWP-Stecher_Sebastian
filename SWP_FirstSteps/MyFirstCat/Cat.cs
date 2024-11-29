using System;

namespace MyFirstCat
{
    class Cat : Animal
    {
        private string? _Color;
        public string? Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }
        public Cat(DateTime birthdate, string name = "not defiend", string color = "nothing") : base(name, birthdate)
        {
            Color = color;
        }
        public override string ToString()
        {
            return $"Name: {Name} Color: {Color} Age: {Age}";
        }
    }
}
