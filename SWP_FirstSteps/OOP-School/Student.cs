namespace OOP_School
{
    public class Student : Human
    {
        public Student(DateTime birthdate, string lastName, string firstName, string gender) : base(birthdate, lastName, gender, firstName) { }
    }
}