Console.WriteLine("Hello, SWP!");


/*
 * Programmierauftrag 01
 * 
 * Schreiben sie eine C# Konsolenanwendung welche
 * _ Eine Eingabe über die Tastatur einliest 
 * _ mit <Enter> soll die Eingabe "abgeschlossen" werden und der eingegebene String auf der Konsole ausgegeben werden
 * _ Bei Eingabe von "Beenden" soll das Programm beendet werden
 */
Console.WriteLine("\n Programmierauftrag_01");

string? userInputString = " ";

while (userInputString != "Beenden")
{
    Console.Write("Bitte gebe eine Zeichenfolge ein oder Beenden um das Programm zu beenden: ");
    userInputString = Console.ReadLine();
    Console.WriteLine("Die eingegebene Zeichenfolge lautet: " + userInputString);
}


/*
 * Programmierauftrag 02
 *
 * Erweitern Sie ihre Konsolenanwendung. sodass sie eine natürliche Zahl einlesen können. 
 * Ihr Programm soll dann die Eingabe in einen Integer konvertieren. 
 * Verschaffen Sie sich zuerst einen Überblick über die elementaren Datentypen von C# 
 * und wie sie diese "umwandeln" (konvertieren) können. 
 */
Console.WriteLine("\n Programmierauftrag_02");

userInputString = " ";
int userInputInt = 0;

while (true)
{
    Console.Write("Bitte gib eine beliebige Zahl ein: ");

    userInputString = Console.ReadLine();

    if (userInputString == "Beenden")
    {
        break;
    }

    int.TryParse(userInputString, out userInputInt);

    Console.WriteLine("Die eingegebene Zahl lautet: " + userInputInt);
    Console.WriteLine("Die eingegebene Zahl verdoppelt lautet: " + (userInputInt * 2));
}

/* Erweitern Sie ihre Konsolenanwendung in der Art, dass nach dem Einlesen der Natürlichen Zahl eine Abfrage erscheint,
 * in der Sie eine Mathematische Operation auswählen können...
 * Dies kann zum Beispiel so ausschauen:
 * Geben Sie eine Zahl zwischen 1 und 3 ein um eine Mathematische Operation auszuwählen:
 * 1) Quadrat
 * 2) Wurzel
 * 3) Fakultät
 */
Console.WriteLine("\n Programmierauftrag_04");

userInputString = " ";
userInputInt = 0;

while (!String.Equals(userInputString, "Beenden", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("Bitte geben Sie eine Natürliche Zahl ein (oder Beenden um zu beenden):");
    userInputString = Console.ReadLine();
    if (int.TryParse(userInputString, out userInputInt))
    {
        Console.Write("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine mathematische Operation für die vorher eingegebene Zahl zu wählen: \n 1) Quadrat \n 2) Wurzel \n 3) Fakultät \n Zahl: ");
        userInputString = Console.ReadLine();
        switch (userInputString)
        {
            case "1":
                userInputInt *= userInputInt;
                Console.WriteLine($"Quadrat der eingegebenen Zahl: {userInputInt}");
                break;
            case "2":
                userInputInt = (int)Math.Sqrt(userInputInt);
                Console.WriteLine($"Wurzel der eingegebenen Zahl: {userInputInt}");
                break;
            case "3":
                int userInputFakultaet = 1;
                for (int i = 2; i <= userInputInt; i++)
                {
                    userInputFakultaet = userInputFakultaet * i;
                }
                Console.WriteLine($"Fakultät der eingegebenen Zahl: {userInputFakultaet}");
                break;
        }
    }
}