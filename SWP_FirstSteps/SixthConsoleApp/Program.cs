/* Programmieraufgabe 6:
 * Erweitern Sie ihre Konsolenapplikation in der Art, dass zuerst eine mathematische Operation abgefragt wird:
 * Geben Sie die Entsprechende Nummer für die Auswahl einer mathematischen Operation an:
 * 1... Multiplizieren
 * 2... Dividieren
 * 3... Addieren
 * 4... Potenzieren
 * 5... Wurzelziehen
 * 6... Fakultät
 * 7... Invertieren
 */
Console.WriteLine("Programmierauftrag_06");

string? userInput = " ";

while (!String.Equals(userInput, "Beenden", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("\n Geben Sie dei entsprechende Numme für die Auswahl einer mathematischen Operation an: \n 1: Addieren \n 2: Subtrahieren \n 3: Multiplizieren \n 4: Dividieren \n 5: Potenzieren \n 6: Wurzelziehen \n 7: Fakultät \n 8: Invertieren \n Input: ");
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            CalculationAddition();
            break;
        case "2":
            CalculationSubtraction();
            break;
        case "3":
            CalculationMultiplication();
            break;
        case "4":
            CalculationDivision();
            break;
        case "5":
            CalculationPower();
            break;
        case "6":
            CalculationRoot();
            break;
        case "7":
            CalculationFakultaet();
            break;
        case "8":
            CalculationInvert();
            break;
    }
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
    (int inputValue1, int inputValue2) = GetTwoValues();
    double calculationResult = inputValue1 + inputValue2;
    Console.WriteLine($"Das Ergebnis der Addition ist {calculationResult}");
}

void CalculationSubtraction()
{
    Console.WriteLine("\n Subtraktion");
    (int inputValue1, int inputValue2) = GetTwoValues();
    double calculationResult = inputValue1 - inputValue2;
    Console.WriteLine($"Das Ergebnis der Subtraktion ist {calculationResult}");
}

void CalculationMultiplication()
{
    Console.WriteLine("\n Multiplikation");
    (int inputValue1, int inputValue2) = GetTwoValues();
    double calculationResult = inputValue1 * inputValue2;
    Console.WriteLine($"Das Ergebnis der Multiplikation ist {calculationResult}");
}

void CalculationDivision()
{
    Console.WriteLine("\n Division");
    (int inputValue1, int inputValue2) = GetTwoValues();
    while (inputValue2 == 0)
    {
        Console.WriteLine("\n ### Division durch 0 ungültig. ### \n");
        inputValue2 = GetOneValue();
    }
    double calculationResult = inputValue1 / inputValue2;
    Console.WriteLine($"Das Ergebnis der Division ist {calculationResult}");
}

void CalculationPower()
{
    Console.WriteLine("\n Potenz");
    (int inputValue1, int inputValue2) = GetTwoValues();
    double calculationResult = inputValue1;
    for (int i = 0; i < inputValue2 - 1; i++)
    {
        calculationResult *= inputValue1;
    }
    Console.WriteLine($"Das Ergebnsi von {inputValue1} hoch {inputValue2} ist {calculationResult}");
}

void CalculationRoot()
{
    Console.WriteLine("\n Wurzelziehen");
    (int inputValue1, int inputValue2) = GetTwoValues();
    while (inputValue1 < 0 || inputValue2 <= 0)
    {
        Console.WriteLine("\n ### Ungültige Eingabe - Wurzelexponent positiv und ungleich 0 sein & Radikand muss positiv sein: Versuchen sie es erneut ### \n");
        (inputValue1, inputValue2) = GetTwoValues();
    }
    double calculationResult = Math.Pow(inputValue1, (1.0 / inputValue2));
    Console.WriteLine($"Das Ergbnis der {inputValue2}-te Wurzel von {inputValue1} ist {calculationResult}");
}

void CalculationFakultaet()
{
    Console.WriteLine("\n Fakultät");
    int inputValue1 = GetOneValue();
    while(inputValue1 < 0)
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

void CalculationInvert()
{
    Console.WriteLine("\n Invertieren");
    int inputValue1 = GetOneValue();
    double calculationResult = inputValue1 - (2 * inputValue1);
    Console.WriteLine($"Die invertierte Zahl ist {calculationResult}");
}