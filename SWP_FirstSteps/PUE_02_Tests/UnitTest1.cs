using ProgrammUE_02;

namespace PUE_02_Tests
{
    public class Tests
    {
        private School _School;
        private Student _Student;
        private Classroom _Classroom;
        [SetUp]
        public void Setup()
        {
            _School = new School();
            _Student = new Student("3aWI", 0, new DateTime(2008, 05, 10));
            _Classroom = new Classroom(35, 20, false);
        }

        [Test]
        public void AddStudentToSchool_ReturnsObjectStudent()
        {
            _School.AddStudentToSchool(_Student);
            Assert.AreEqual(_Student, _School.Students[0]);
        }
        [Test]
        public void AddStudentToClassroom_ReturnsObjectStudent()
        {
            _Classroom.AddStudentToClassroom(_Student);
            Assert.AreEqual(_Student, _Classroom.Students[0]);
        }
    }
}