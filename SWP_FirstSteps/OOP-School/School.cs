namespace OOP_School
{
    public class School
    {
        private List<Schoolclass> _Schoolclasses;
        public List<Schoolclass > Schoolclasses { get { return _Schoolclasses; } }
        public void AddSchoolclassToSchool(Schoolclass a) { _Schoolclasses.Add(a); }
        public string SchoolName { get; set; }
        public string _SchoolLocation;
        public string SchoolLocation { get { return _SchoolLocation; } }
        private string _SchoolType;
        public string SchoolType { get { return _SchoolType; } }
        public School(string schoolName, string schoolType, string schoolLocation)
        {
            SchoolName = schoolName;
            _SchoolType = schoolType;
            _SchoolLocation = schoolLocation;
            _Schoolclasses = new List<Schoolclass>();
        }

        public int CountNumberOfSchoolclasses() { return _Schoolclasses.Count; }
    }
}