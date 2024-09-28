//Console.WriteLine("Hello, SWP!");

/*
 * Programmierauftrag 01
 * 
 * Schreiben sie eine C# Konsolenanwendung welche
 * _ Eine Eingabe über die Tastatur einliest 
 * _ mit <Enter> soll die Eingabe "abgeschlossen" werden und der eingegebene String auf der Konsole ausgegeben werden
 * _ Bei Eingabe von "Beenden" soll das Programm beendet werden
 */
using System.Globalization;

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

/* 
 * Programmieraufgabe 3:
 * Erweitern Sie ihre Konsolenanwendung in der Art, dass der Datentyp des eingegebenen Strings identifiziert und ausgegeben wird.
 * Das Programm soll für true/false bzw. Wahr/falsch den Datentyp Bool verwenden,
 * für eine Kommazahl einen double (was ist der Unterschied zu einem Float?),
 * für eine Ganzzahl den Typ Integer und
 * für ein Datum einen Datumstyp
 * Initialisieren sie nach identifizieren des Datentyps auch jeweils eine Variable mit dem entsprechenden Typ.
 */
Console.WriteLine("\n Programmierauftrag_03");

userInputString = " ";
userInputInt = 0;
double userInputDouble = 0.0;
bool userInputBool = false;
char userInputChar = '"';
DateOnly userInputDate = new DateOnly();

while (!string.Equals(userInputString, "Beenden", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("Gib einen beliebige Datentyp ein (oder Beenden um das Programm zu beenden): ");
    userInputString = Console.ReadLine();

    if (int.TryParse(userInputString, out userInputInt))
    {
        Console.WriteLine($"Der eingegebene Datentyp ist INT: {userInputInt}");
    }
    else if (double.TryParse(userInputString, out userInputDouble) || double.TryParse(userInputString, CultureInfo.GetCultureInfo("de-DE"), out userInputDouble))
    {
        Console.WriteLine($"Der eingegebene Datentyp ist DOUBLE: {userInputDouble}");
    }
    else if (bool.TryParse(userInputString, out userInputBool))
    {
        Console.WriteLine($"Der eingegebene Datentyp ist BOOL: {userInputBool}");
    }
    else if (string.Equals(userInputString, "wahr", StringComparison.CurrentCultureIgnoreCase))
    {
        userInputBool = true;
        Console.WriteLine($"Der eingegebene Datentyp ist BOOL: {userInputBool}");
    }
    else if (string.Equals(userInputString, "falsch", StringComparison.CurrentCultureIgnoreCase))
    {
        userInputBool= false;
        Console.WriteLine($"Der eingegebene Datentyp ist BOOL: {userInputBool}");
    }
    else if (char.TryParse(userInputString, out userInputChar))
    {
        Console.WriteLine($"Der eingegebene Datentyp ist CHAR: {userInputChar}");
    }
    else if (DateOnly.TryParse(userInputString, out userInputDate))
    {
        Console.WriteLine($"Der eingegebene Datentyp is DATE: {userInputDate}");
    }
    else
    {
        Console.WriteLine($"Der eingegebene Datentyp ist STRING: {userInputString}");
    }
}