namespace MyFirstCat
{
    public class Animal : Creature
    {
        private int _Legs;
        public int Legs { get { return _Legs; } }
        private string _AnimalType;
        public string AnimalType { get { return _AnimalType; } }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name}: *animal sound*");
        }
        public Animal(string name, string color, DateTime birthdate, string animalType, int legs) : base(name, color, birthdate)
        {
            _AnimalType = animalType;
            _Legs = legs;
        }
    }
}
