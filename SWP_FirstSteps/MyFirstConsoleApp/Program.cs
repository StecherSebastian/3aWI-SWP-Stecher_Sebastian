Console.WriteLine("Hello, SWP!");


/*
 * Programmierauftrag 01
 * 
 * Schreiben sie eine C# Konsolenanwendung welche
 * _ Eine Eingabe über die Tastatur einliest 
 * _ mit <Enter> soll die Eingabe "abgeschlossen" werden und der eingegebene String auf der Konsole ausgegeben werden
 * _ Bei Eingabe von "Beenden" soll das Programm beendet werden
 */

string? userinputString = " ";

while (userinputString != "Beenden")
{
    Console.Write("Bitte gebe eine Zeichenfolge ein oder Beenden um das Programm zu beenden: ");
    userinputString = Console.ReadLine();
    Console.WriteLine("Die eingegebene Zeichenfolge lautet: " + userinputString);
}


/*
 * Programmierauftrag 02
 *
 * Erweitern Sie ihre Konsolenanwendung. sodass sie eine natürliche Zahl einlesen können. 
 * Ihr Programm soll dann die Eingabe in einen Integer konvertieren. 
 * Verschaffen Sie sich zuerst einen Überblick über die elementaren Datentypen von C# 
 * und wie sie diese "umwandeln" (konvertieren) können. 
 */

userinputString = " ";
int userinputInt = 0;

while (true)
{
    Console.Write("Bitte gib eine beliebige Zahl ein: ");

    userinputString = Console.ReadLine();

    if (userinputString == "Beenden")
    {
        break;
    }

    int.TryParse(userinputString, out userinputInt);

    Console.WriteLine("Die eingegebene Zahl lautet: " + userinputInt);
    Console.WriteLine("Die eingegebene Zahl verdoppelt lautet: " + (userinputInt * 2));
}