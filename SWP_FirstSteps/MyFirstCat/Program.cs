using MyFirstCat;

string? userInputString = " ";
DateTime userInputDate = new DateTime(0001, 01, 01);
AnimalShelter shelterDornbirn = new AnimalShelter();

while (!String.Equals(userInputString, "Exit", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("\nPossible Options:\n 1) Create Cat\n 2) Create Dog\n 3) See Content Animal Shelter\n or Exit\n*:");
    userInputString = Console.ReadLine();
    switch (userInputString)
    {
        case "1":
            Console.Write("\nWhen was the cat born? (YYYY/MM/DD)\n*:");
            GetDate();
            Cat myCat = new Cat(userInputDate);
            Console.Write("\nWhich color has the cat?\n*:");
            userInputString = Console.ReadLine();
            myCat.Color = userInputString;
            Console.Write("\nWhat is the name of the cat?\n*:");
            userInputString = Console.ReadLine();
            myCat.Name = userInputString;
            shelterDornbirn.Animals.Add(myCat);
            break;
        case "2":
            Console.Write("\nWhen was the dog born? (YYYY/MM/DD)\n*:");
            GetDate();
            Dog myDog = new Dog(userInputDate);
            Console.Write("\nWhich color has the dog?\n*:");
            userInputString = Console.ReadLine();
            myDog.Color = userInputString;
            Console.Write("\nWhat is the name of the dog?\n*:");
            userInputString = Console.ReadLine();
            myDog.Name = userInputString;
            shelterDornbirn.Animals.Add(myDog);
            break;
        case "3":
            shelterDornbirn.printAnimalShelter();
            break;
    }
}
DateTime GetDate()
{
    string input = Console.ReadLine();
    DateTime date = new DateTime(0001, 01, 01);
    while (!DateTime.TryParse(input, out date))
    {
        Console.Write("\n### Invalid Date: Please Try Again ###\n*:");
        input = Console.ReadLine();
    }
    return date;
}