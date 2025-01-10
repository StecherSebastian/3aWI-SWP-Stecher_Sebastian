namespace OOP_School
{
    public class Schoolclass : School
    {
        public string ClassName { get; set; }
        private List<Student> _Students;
        public List<Student> Students 
        {  
            get { return _Students; }
            set 
            { 
                if (_Students == value) return;
                _Students = value;
            }
        }
        public void AddStudentToClass(Student a)
        {
            _Students.Add(a);
        }
        public Schoolclass (string className, string schoolName, string schoolType, string schoolLocation) : base(schoolName, schoolType, schoolLocation)
        {
            ClassName = className;
            _Students = new List<Student>();
        }
    }
}
