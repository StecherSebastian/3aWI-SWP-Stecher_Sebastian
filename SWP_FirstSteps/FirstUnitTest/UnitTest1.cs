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
        [Test]
        public void AverageAgeOfAnimals_AddOneCatAndOneDog_ReturnsTheirAverageAge()
        {
            var myAnimalShelter = new AnimalShelter();
            var dogBirthdate = new DateTime(2022, 07, 13);
            var catBirthdate = new DateTime(2023, 07, 13);
            myAnimalShelter.AddAnimal(new Cat(catBirthdate, "Kitty", "white"));
            myAnimalShelter.AddAnimal(new Dog(dogBirthdate, "Lessi", "grey"));
            int catAge = DateTime.Now.Year - catBirthdate.Year;
            int dogAge = DateTime.Now.Year - dogBirthdate.Year;
            double averageAge = (catAge + dogAge) / 2.0;
            Assert.IsTrue(myAnimalShelter.AverageAgeOfAnimals == averageAge);
        }
    }
}