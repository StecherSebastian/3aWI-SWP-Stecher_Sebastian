namespace MyFirstCat
{
    public class Cat : Animal
    {
        public Cat(DateTime birthdate, string name = "not defiend", string color = "nothing", string animalType = "Cat", int legs = 4) : base(name, color, birthdate, animalType, legs) { }
        public override void Speak()
        {
            Console.WriteLine($"{Name}: *miau*");
        }
        public override string ToString()
        {
            return $"The {AnimalType} named {Name} who is {Color}, is {Age} years old and walks on {Legs} Legs.";
        }
    }
}
