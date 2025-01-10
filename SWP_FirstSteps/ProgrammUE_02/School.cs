namespace ProgrammUE_02
{
    public class School
    {
        private List<Student> _Students;
        public List<Student> Students 
        { 
            get { return _Students; } 
            set { _Students = value; }
        }
        public School() { _Students = new List<Student>(); }
        public void AddStudentToSchool(Student student) { _Students.Add(student); }
    }
}
