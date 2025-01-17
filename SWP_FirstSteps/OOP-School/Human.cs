namespace OOP_School
{
    public class Human
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        private DateTime _Birthdate;
        public int Age { get { return DateTime.Now.Year - _Birthdate.Year; } }
        private string _Gender;
        public string Gender { get; }
        public Human(DateTime birtdate, string lastName, string gender, string firstName = "") 
        {
            _Birthdate = birtdate;
            FamilyName = lastName;
            _Gender = gender;
        }
    }
}
