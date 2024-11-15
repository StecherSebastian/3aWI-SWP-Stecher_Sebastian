using System;

namespace MyFirstCat
{
    class Cat
    {
        private string? _Color;
        private DateTime _BirthDate;
        private string? _Name;
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
        public Cat(DateTime birthdate)
        {
            _BirthDate = birthdate;
        }
        public string? Name { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} Color: {Color} Age: {Age}";
        }
    }
}
