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
int inputValue1 = 0;
int inputValue2 = 0;
double calculationResult = 0;

while (!String.Equals(userInput, "Beenden", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("\n Geben Sie dei entsprechende Numme für die Auswahl einer mathematischen Operation an: \n 1: Addieren \n 2: Subtrahieren \n 3: Multiplizieren \n 4: Dividieren \n 5: Potenzieren \n 6: Wurzelziehen \n 7: Fakultät \n 8: Invertieren \n Input: ");
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            calculationAddition();
            break;
        case "2":
            calculationSubtraction();
            break;
        case "3":
            calculationMultiplication();
            break;
        case "4":
            calculationDivision();
            break;
        case "5":
            calculationPower();
            break;
        case "6":
            calculationRoot();
            break;
        case "7":
            calculationFakultaet();
            break;
        case "8":
            calculationInvert();
            break;
    }
}

void getOneValue()
{
    Console.Write("Bitte geben Sie eine Zahl ein: ");
    int.TryParse(Console.ReadLine(), out inputValue1);
}

void getTwoValues()
{
    Console.Write("Bitte geben Sie die erste Zahl ein: ");
    int.TryParse(Console.ReadLine(), out inputValue1);
    Console.Write("Bitte geben Sie die zweite Zahl ein: ");
    int.TryParse(Console.ReadLine(), out inputValue2);
}

void calculationAddition()
{
    Console.WriteLine("\n Addition");
    getTwoValues();
    calculationResult = inputValue1 + inputValue2;
    Console.WriteLine($"Das Ergebnis der Addition ist {calculationResult}");
}

void calculationSubtraction()
{
    Console.WriteLine("\n Subtraktion");
    getTwoValues();
    calculationResult = inputValue1 - inputValue2;
    Console.WriteLine($"Das Ergebnis der Subtraktion ist {calculationResult}");
}

void calculationMultiplication()
{
    Console.WriteLine("\n Multiplikation");
    getTwoValues();
    calculationResult = inputValue1 * inputValue2;
    Console.WriteLine($"Das Ergebnis der Multiplikation ist {calculationResult}");
}

void calculationDivision()
{
    Console.WriteLine("\n Division");
    getTwoValues();
    calculationResult = inputValue1 / inputValue2;
    Console.WriteLine($"Das Ergebnis der Division ist {calculationResult}");
}

void calculationPower()
{
    Console.WriteLine("\n Potenz");
    getTwoValues();
    calculationResult = inputValue1;
    for (int i = 0; i < inputValue2 - 1; i++)
    {
        calculationResult *= inputValue1;
    }
    Console.WriteLine($"Das Ergebnsi von {inputValue1} hoch {inputValue2} ist {calculationResult}");
}

void calculationRoot()
{
    Console.WriteLine("\n Wurzelziehen");
    getTwoValues();
    calculationResult = Math.Pow(inputValue1, (1.0 / inputValue2));
    Console.WriteLine($"Das Ergbnis der {inputValue2}-te Wurzel von {inputValue1} ist {calculationResult}");
}

void calculationFakultaet()
{
    Console.WriteLine("\n Fakultät");
    getOneValue();
    calculationResult = 1;
    for (int i = 2; i <= inputValue1; i++)
    {
        calculationResult = calculationResult * i;
    }
    Console.WriteLine($"Die Fakultät von {inputValue1} ist {calculationResult}");
}

void calculationInvert()
{
    Console.WriteLine("\n Invertieren");
    getOneValue();
    calculationResult = inputValue1 - (2 * inputValue1);
    Console.WriteLine($"Die invertierte Zahl ist {calculationResult}");
}