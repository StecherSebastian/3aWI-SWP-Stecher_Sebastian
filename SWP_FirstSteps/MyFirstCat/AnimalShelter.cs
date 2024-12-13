namespace MyFirstCat
{
    public class AnimalShelter
    {
        private List<Animal> _Animals;
        public List<Animal> Animals
        {
            get { return _Animals; }
            set
            {
                if (_Animals == value) return;
                _Animals = value;
            }
        }
        public AnimalShelter()
        {
            Animals = new List<Animal>();
        }
        public void AddAnimal(Animal a) 
        { 
            Animals.Add(a);
        }
        public void printAnimalShelter()
        {
            Console.WriteLine($"There are {NumberOfAnimals} Animals in the Animal Shelter of which are {NumberOfCats} Cats and {NumberOfDogs} Dogs");
            Console.WriteLine("\nThe Shelter in Dornbirn contains:");
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.ToString());
                animal.Speak();
            }
        }
        public int NumberOfAnimals { get { return Animals.Count; } }
        public int NumberOfCats
        {
            get { return _Animals.Where(a => a.GetType() == typeof(Cat)).Count(); }
        }
        public int NumberOfDogs
        {
            get { return _Animals.Where(a => a.GetType() == typeof(Dog)).Count(); }
        }
    }
}