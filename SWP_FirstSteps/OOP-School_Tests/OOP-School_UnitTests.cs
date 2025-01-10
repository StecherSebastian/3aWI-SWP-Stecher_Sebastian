using OOP_School;
namespace OOP_School_Tests
{
    public class Tests
    {
        private School _School;
        private Schoolclass _Schoolclass;
        private Schoolclass _Schoolclass2;
        private Student _Student;
        private Student _Student2;

        [SetUp]
        public void Setup()
        {
            _School = new School("HTL Dornbirn", "HTL", "Dornbirn");
            _Schoolclass = new Schoolclass("3aWI", "HTL Dornbirn", "HTL", "Dornbirn");
            _Schoolclass = new Schoolclass("2aWI", "HTL Dornbirn", "HTL", "Dornbirn");
            _Student = new Student(new DateTime(2008, 05, 1), "Stecher", "Sebastian", "m");
            _Student2 = new Student(new DateTime(2007, 12, 21), "Fleisch", "Florian", "m");
        }

        [Test]
        public void ReadSchoolType_CreatObjectSchool_ReturnStringHTL()
        {
            Assert.AreEqual("HTL", _School.SchoolType);
        }
        [Test]
        public void AddSchoolclassToSchool_AddOneSchoolclass_ReturnsObjectSchoolclass()
        {
            _School.AddSchoolclassToSchool(_Schoolclass);
            Assert.AreEqual(_Schoolclass, _School.Schoolclasses[0]);
        }
        [Test]
        public void CountNumberOfSchoolClasses_AddTwoSchoolclasses_ReturnsIntegerWitValue2()
        {
            _School.AddSchoolclassToSchool(_Schoolclass);
            _School.AddSchoolclassToSchool(_Schoolclass2);
            Assert.AreEqual(2, _School.CountNumberOfSchoolclasses());
        }
        [Test]
        public void AddStudentToClass_AddOneStudent_ReturnsObjectStudent() 
        {
            _Schoolclass.AddStudentToClass(_Student);
            Assert.AreEqual(_Student, _Schoolclass.Students[0]);
        }
    }
}