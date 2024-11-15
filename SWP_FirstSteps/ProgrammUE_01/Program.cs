string? userInputString = " ";
string? userChoice = " ";
int userInputInt = 0;

while (!userInputString.Equals("Beenden", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("\nBitte geben sie eine ganze Zahl ein oder eine Zeichenkette: ");
    userInputString = Console.ReadLine();
    if (int.TryParse(userInputString, out userInputInt))
    {
        Console.Write("\nSie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausführen?\n1) Addition\n2) Multiplikation\n3) Division\n4) Fakultät\n5) Wurzelziehen\nInput: ");
        userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                CalculationAddition();
                break;
            case "2":
                CalculationMultiplication();
                break;
            case "3":
                CalculationDivision();
                break;
            case "4":
                CalculationFakultaet();
                break;
            case "5":
                CalculationRoot();
                break;
        }
    }
    else
    {
        Console.Write("\nSie haben eine Zeichenkette eingeben. Was wollen Sie damit machen?\n1) Alle Selbstlauge (a,e,i,o,u) entfernen\n2) Die Zeichenkette \"umdrehen\" (aus \"Hallo\" wird dann z.B. \"ollH\")\n3) Die Anzahl an Zeichen ausgeben\nInput: ");
        userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                string userInputStringNoVowels = " ";
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                foreach (char c in userInputString)
                {
                    if (Array.IndexOf(vowels, c) == -1)
                    {
                        userInputStringNoVowels += c;
                    }
                }
                Console.WriteLine($"Der String {userInputString} ohne Vokale lautet {userInputStringNoVowels}");
                break;
            case "2":
                string userInputStringTurned = " ";
                for (int i = userInputString.Length - 1; i >= 0; i--)
                {
                    userInputStringTurned += userInputString[i];
                }
                Console.Write($"Der String {userInputString} umgedreht lautet {userInputStringTurned}");
                break;
            case "3":
                Console.WriteLine($"Die eingegebene Zeichenkette enthält {userInputString.Length} Zeichen.");
                break;
        }
    }
    userChoice = " ";
}

int GetOneValue()
{
    int inputValue1;
    Console.Write("Bitte geben Sie eine Zahl ein: ");
    while (!int.TryParse(Console.ReadLine(), out inputValue1))
    {
        Console.WriteLine("### Invalid Input: Try again ###");
    }
    return inputValue1;
}

(int, int) GetTwoValues()
{
    int inputValue1;
    int inputValue2;
    Console.Write("Bitte geben Sie die erste Zahl ein: ");
    while (!int.TryParse(Console.ReadLine(), out inputValue1))
    {
        Console.WriteLine("### Invalid Input: Try again ###");
    }
    Console.Write("Bitte geben Sie die zweite Zahl ein: ");
    while (!int.TryParse(Console.ReadLine(), out inputValue2))
    {
        Console.WriteLine("### Invalid Input: Try again ###");
    }
    return (inputValue1, inputValue2);
}

void CalculationAddition()
{
    Console.WriteLine("\n Addition");
    int inputValue2 = GetOneValue();
    double calculationResult = userInputInt + inputValue2;
    Console.WriteLine($"Das Ergebnis der Addition ist {calculationResult}");
}

void CalculationMultiplication()
{
    Console.WriteLine("\n Multiplikation");
    int inputValue2 = GetOneValue();
    double calculationResult = userInputInt * inputValue2;
    Console.WriteLine($"Das Ergebnis der Multiplikation ist {calculationResult}");
}

void CalculationDivision()
{
    Console.WriteLine("\n Division");
    int inputValue2 = GetOneValue();
    while (inputValue2 == 0)
    {
        Console.WriteLine("\n ### Division durch 0 ungültig. ### \n");
        inputValue2 = GetOneValue();
    }
    double calculationResult = userInputInt / inputValue2;
    Console.WriteLine($"Das Ergebnis der Division ist {calculationResult}");
}

void CalculationFakultaet()
{
    Console.WriteLine("\n Fakultät");
    int inputValue1 = userInputInt;
    while (inputValue1 < 0)
    {
        Console.WriteLine("\n ### Fakultät von negativen Zahlen nicht definiert ### \n");
        inputValue1 = GetOneValue();
    }
    double calculationResult = 1;
    for (int i = 2; i <= inputValue1; i++)
    {
        calculationResult = calculationResult * i;
    }
    Console.WriteLine($"Die Fakultät von {inputValue1} ist {calculationResult}");
}

void CalculationRoot()
{
    Console.WriteLine("\n Wurzelziehen");
    int inputValue2 = GetOneValue();
    while (userInputInt < 0 || inputValue2 <= 0)
    {
        Console.WriteLine("\n ### Ungültige Eingabe - Wurzelexponent positiv und ungleich 0 sein & Radikand muss positiv sein: Versuchen sie es erneut ### \n");
        (userInputInt, inputValue2) = GetTwoValues();
    }
    double calculationResult = Math.Pow(userInputInt, (1.0 / inputValue2));
    Console.WriteLine($"Das Ergbnis der {inputValue2}-te Wurzel von {userInputInt} ist {calculationResult}");
}