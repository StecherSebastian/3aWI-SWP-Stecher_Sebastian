namespace MyFirstCat
{
    public class Creature
    {
        public string Name { get; set; }
        private DateTime _BirthDate;
        private string? _Color;
        public string? Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _BirthDate.Year);
            }
        }
        public Creature(string name, string color, DateTime birthdate)
        {
            Name = name;
            _Color = color;
            _BirthDate = birthdate;
        }
    }
}
