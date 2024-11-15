using System;

namespace MyFirstCat
{
    class Cat : Animal
    {
        private string? _Color;
        private DateTime _BirthDate;
        public string? Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _BirthDate.Year);
            }
        }
        public Cat(DateTime birthdate, string name = "not defiend", string color = "nothing") : base(name)
        {
            Name = name;
            Color = color;
            _BirthDate = birthdate;
        }
        public override string ToString()
        {
            return $"Name: {Name} Color: {Color} Age: {Age}";
        }
    }
}
