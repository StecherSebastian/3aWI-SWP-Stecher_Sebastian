using MyFirstCat;

string? userInputString = " ";
DateTime userInputDate = new DateTime(0001, 01, 01);
AnimalShelter shelterDornbirn = new AnimalShelter();

while (!String.Equals(userInputString, "Exit", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("\nPossible Options:\n 1) Create Cat\n 2) See Content Animal Shelter\n or Exit\n*:");
    userInputString = Console.ReadLine();
    switch (userInputString)
    {
        case "1":
            Console.Write("\nWhen was the cat born? (YYYY/MM/DD)\n*:");
            userInputString = Console.ReadLine();
            while (!DateTime.TryParse(userInputString, out userInputDate))
            {
                Console.Write("\n### Invalid Date: Please Try Again ###\n*:");
                userInputString = Console.ReadLine();
            }
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
            shelterDornbirn.printAnimalShelter();
            break;
    }
}