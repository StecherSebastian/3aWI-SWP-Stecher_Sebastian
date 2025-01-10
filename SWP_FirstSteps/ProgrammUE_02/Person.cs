using System.ComponentModel;

namespace ProgrammUE_02
{
    public class Person
    {
        private DateTime _Birthdate;
        public enum _AllowedGenders
        {
            m = 0,
            w = 1,
            d = 2
        }
        private _AllowedGenders _Gender;
        public _AllowedGenders Gender 
        { 
            get { return _Gender; } 
            set { _Gender = value; } 
        }

        public Person(DateTime birthdate, _AllowedGenders gender) 
        {
            _Birthdate = birthdate;
            _Gender = gender;
        }
    }
}
