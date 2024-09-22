Console.WriteLine("Hello, SWP!");


/*
 * Schreiben sie eine C# Konsolenanwendung welche
 * _ Eine Eingabe über die Tastatur einliest 
 * _ mit <Enter> soll die Eingabe "abgeschlossen" werden und der eingegebene String auf der Konsole ausgegeben werden
 * _ Bei Eingabe von "Beenden" soll das Programm beendet werden
 */

string userinput = " ";

while (userinput != "Beenden")
{
    Console.Write("Bitte gebe eine Zeichenfolge ein oder Beenden um das Programm zu beenden: ");
    userinput = Console.ReadLine();
    Console.WriteLine("Die eingegebene Zeichenfolge lautet: " + userinput);
}