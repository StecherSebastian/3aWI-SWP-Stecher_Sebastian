namespace ProgrammUE_02
{
    public class Student : Person
    {
        private string _Schoolclass;
        public string Schoolclass { get { return _Schoolclass; } }

        public Student(string schoolclass, _AllowedGenders gender, DateTime birthdate) : base(birthdate, gender)
        {
            _Schoolclass = schoolclass;
        }
    }
}
