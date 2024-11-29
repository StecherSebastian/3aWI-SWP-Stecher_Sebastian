using System;

namespace MyFirstCat
{
    internal class Creature
    {
        private DateTime _BirthDate;

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _BirthDate.Year);
            }
        }
        public Creature(DateTime birthdate) 
        {
            _BirthDate = birthdate;
        }
    }
}
