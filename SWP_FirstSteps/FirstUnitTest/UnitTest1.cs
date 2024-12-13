using MyFirstCat;
namespace FirstUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddAnimal_AddOneCatAndOneDog_ReturnsTwoAnimals()
        {
            var myAnimalShelter = new AnimalShelter();
            myAnimalShelter.AddAnimal(new Cat(new DateTime(2023, 07, 13), "Kitty", "white"));
            myAnimalShelter.AddAnimal(new Dog(new DateTime(2023, 07, 13), "Lessi", "grey"));
            Assert.IsTrue(myAnimalShelter.NumberOfAnimals == 2);
        }
    }
}